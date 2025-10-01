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
        public async Task<IActionResult> SendFromSender(string deviceToken, string title, string body)
        {
            if (string.IsNullOrEmpty(deviceToken) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(body))
            {
                ViewBag.Error = "Please provide device token, title, and body.";
                return View("Index");
            }

            var message = new Message()
            {
                Notification = new Notification
                {
                    Title = title,
                    Body = body
                },
                Token = deviceToken
            };


            string response = await FirebaseMessaging.DefaultInstance.SendAsync(message);

            ViewBag.Success = $"Successfully sent message: {response}";
            return View("Index");
        }

        [HttpPost]
        public async Task<IActionResult> SendFromSenderToAll(string title, string body)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(body))
            {
                ViewBag.Error = "Please provide title, body.";
                return View("Index");
            }

            var message = new Message()
            {
                Notification = new Notification
                {
                    Title = title,
                    Body = body
                },
                Topic = "mg"
            };


            string response = await FirebaseMessaging.DefaultInstance.SendAsync(message);

            ViewBag.Success = $"Successfully sent message: {response}";
            return View("Index");
        }

        [HttpPost]
        public async Task<IActionResult> SubscripeToTopic(string deviceToken, string topic)
        {
            if (string.IsNullOrEmpty(deviceToken) || string.IsNullOrEmpty(topic))
            {
                ViewBag.Error = "Please provide device token and topic.";
                return View("Index");
            }

            try
            {
                var response = await FirebaseMessaging.DefaultInstance.SubscribeToTopicAsync(
                    new List<string> { deviceToken }, topic);

                ViewBag.Success = $"Successfully subscribed {response.SuccessCount} device(s) to topic '{topic}'";
            }
            catch (Exception ex)
            {
                ViewBag.Error = $"Subscription failed: {ex.Message}";
            }

            return View("Index");
        }
    }
}