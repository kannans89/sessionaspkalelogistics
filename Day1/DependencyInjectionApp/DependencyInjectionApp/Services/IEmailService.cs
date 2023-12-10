namespace DependencyInjectionApp.Services
{
    public interface IEmailService
    {
      Task SendEmail(string details);
    }
}
