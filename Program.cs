using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Initialize  Firebase Admin SDK
FirebaseApp.Create(new AppOptions()
{
    Credential = GoogleCredential.FromFile(@"C:\Users\Mosaad.Ghanem\key.json")
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Notification}/{action=Index}/{id?}");


app.Run();


















//{
//    "type": "service_account",
//  "project_id": "test-notification-94710",
//  "private_key_id": "0a74796f9f8aec07fc33e98349401a368449564e",
//  "private_key": "-----BEGIN PRIVATE KEY-----\nMIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQDCFSHAT+MzdNGa\nyWky3nuPdVDDzm4IwT+ulwcEq617AcFfl6vEId/idB+8+QBG/huui9zIP2gocwgy\neJPMJ1vti1OYplDgZs4QqNtBeO7n8pchTzQ7R9DuPsDzgaww5a6NV8xQfDeiMEGi\niLvtSUMrM4/YNWX28BmV+BJyJhhSCSr/afy1yLQAQAu9p9gKxkuXXOmbwow+KniA\n4IGlSnI5KPN8MT6U8bUA6UQNYOO7DO4bUuSwSxmq4Bk6IsRHz9zF0ERk9Zs4L+Qd\nfgp7gNq6+pByMvwbDTQWdqHO6fr+57Kj97PRpDdZPdijwJk0JMX3gpzMlWsYbo5m\nmIEW/bALAgMBAAECggEAAnHUsoDvGjNS/pGh5xehU83E/ipn/Wk9vZu+ZWMqNL3x\naxxUeAx7LvWKfs1eIQbLX3f4iHcv/y5vwH7/UZd/U28pVudlZmY1G0WdOWZmD/rg\nx3Uhccu2SIH22TpdamJCQBqGgs8Fvl/AO+VgBJ2jIHSuT6lghutAT0DILrLnJIVe\naKy0/gLa8JWkK3rciRhm+fbKjeAnAmjFqrJNmL7GSIf5f9RF25MFQQcZWPc0s/tE\ntOFdvoJcXpX5GYsS5Hlh7NDmHw9L8PGSCUiaNPBIzOFYGcMnUd+yk2zNiiMtBwin\nECZ9duDfNLu+l5OgPTDx484cwje8kzCXGlKpQEwzPQKBgQDxY8gWPSerF23yZAh/\nGBCrBHJlKyz4v6QXCFoOIFVgA2LRyVLs2zvtR7jD/4JFTAQ3Du+1dS3X6JlUK1iM\n19GdsipJ3Sw4DDiF/19T/FLAt/QRNru02P1pnYHEofUCEnr4ie28eb/GQebrhEMB\nO7nYIyaEhDNk+hRwf7jxRyYdRwKBgQDN1Fj4s0nAq9uiOnI4jfD99cKBwIeoGQes\n1qeK6wZtwRc3n2bd8eDwfRKc3/S9Yxp9AsBV4P5IcWKfX60V7h/s1a4PoY05irPs\ngXgHbJNvZcCSbSkal82Y0OlmkzpjEqsHsQxpWfV4z7fkL2TXchSxH99A9eTNPDoV\njkDqOSQpHQKBgGWocAttldcn9tWt6yYbLGnZZZPVqwrXKnPIwKRSWaIlyugusQ2v\nBn3XRqjEYkhsyxmk4K66uqPDAU/BMXmfKlgPQF/7FTRFcUh9U9g6217uGYtmUYbI\nG3DvNEdrLZPB1Kf27ngBjhIgju+As/dA//NWWlJUmpBcAV+fanOyUwrhAoGBAKbD\nRxqo2DZ8h0SXKffcOMbqGR9bSA3PycIlYDVTWjAOY6szQPrNgDwYeb4UTYwsAUgL\ntJ1f32X+R7NspyW/eqo+LfqIH43hbQlPlFofhAybWjzIqKbdGzyW9qOe4Y1nkJ54\nud+ZfSLW2NzN8VwFF/KyKgXNtAT8qOrSCJI8namZAoGAIN/xeFT4FQwscNYkOu3K\nDwslIvOy1sDp/OG3Tu71vKsFpYJiCLVwYlO3tUnJgByoRWuwyl6zyTm7VAN+n+UO\nxfzk6HEBjYv4bnPjsOOIQKW4vCXVeNPn8mspavKuBclf1mBgm2C2IO695IpYWv7g\nCQQo9y0ND2F3GOaQQZIsL+4=\n-----END PRIVATE KEY-----\n",
//  "client_email": "firebase-adminsdk-fbsvc@test-notification-94710.iam.gserviceaccount.com",
//  "client_id": "116994298926114824721",
//  "auth_uri": "https://accounts.google.com/o/oauth2/auth",
//  "token_uri": "https://oauth2.googleapis.com/token",
//  "auth_provider_x509_cert_url": "https://www.googleapis.com/oauth2/v1/certs",
//  "client_x509_cert_url": "https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-fbsvc%40test-notification-94710.iam.gserviceaccount.com",
//  "universe_domain": "googleapis.com"
//}
