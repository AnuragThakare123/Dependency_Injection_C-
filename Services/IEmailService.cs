namespace Dependency_Injection.Services
{
    public interface IEmailService
    { 

        string sendEmail(string to, string subject, string body);
    }
}
