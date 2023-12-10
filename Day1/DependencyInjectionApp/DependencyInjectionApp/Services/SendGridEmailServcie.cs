
namespace DependencyInjectionApp.Services
{
    public class SendGridEmailServcie : IEmailService
    {
        public SendGridEmailServcie() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("SendGridServcie created");
            Console.ResetColor();
        }
        public Task SendEmail(string details)
        {
            return Task.Run(() => {
                Console.ForegroundColor = ConsoleColor.Blue ;
                Console.WriteLine($"sending email to {details}");
                Console.ResetColor();
            });
          
        }
    }
}
