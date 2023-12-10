using DependencyInjectionApp;
using DependencyInjectionApp.MiddleWares;
using DependencyInjectionApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IEmailService, SendGridEmailServcie>();
var app = builder.Build();


//string myCompany = "KaleLogistics";
//Console.WriteLine(myCompany.Hello()); ;

//app.UseEmailSendingMiddleWare();

//app.UseMiddleware(typeof(EmailSenderMiddleWare));
app.UseMiddleware<EmailSenderMiddleWare>();

//app.UseEmailSenderMiddleWare();
app.MapDefaultControllerRoute();//{controller}/{action}/{id?}

//app.MapGet("/", () => "Hello World!");

app.Run();
