using DependencyInjectionApp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace DependencyInjectionApp.MiddleWares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class EmailSenderMiddleWare
    {
        private readonly RequestDelegate _next;

        public EmailSenderMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext,IEmailService service)
        {
           // SendGridEmailServcie service = new SendGridEmailServcie();
            await service.SendEmail("admin@middleware");
            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    //public static class EmailSenderMiddleWareExtensions
    //{
    //    public static IApplicationBuilder UseEmailSenderMiddleWare(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<EmailSenderMiddleWare>();
    //    }
    //}
}
