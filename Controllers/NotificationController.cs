using FirebaseAdmin.Messaging;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SenderApp.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Send(string deviceToken, string title, string body)
        {
            if (string.IsNullOrEmpty(deviceToken) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(body))
            {
                ViewBag.Error = "Please provide device token, title, and body.";
                return View("Index");
            }

            //var message = new Message()
            //{
            //    Notification = new Notification
            //    {
            //        Title = title,
            //        Body = body
            //    },
            //    Token = deviceToken
            //};
            var message = new Message()
            {
                Data = new Dictionary<string, string>()
                {
                    ["FirstName"] = "John",
                    ["LastName"] = "Doe"
                },
                Notification = new Notification
                {
                    Title = "Message Title",
                    Body = "Message Body"
                },

                //Token = deviceToken,
                Topic = "news"
            };

            string response = await FirebaseMessaging.DefaultInstance.SendAsync(message);

            ViewBag.Success = $"Successfully sent message: {response}";
            return View("Index");
        }
    }
}