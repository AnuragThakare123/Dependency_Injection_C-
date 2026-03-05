namespace Dependency_Injection.Services
{
    public class EmailServices : IEmailService
    {
      string IEmailService.sendEmail(string to, string subject, string body)
        {
            // throw new NotImplementedException();
          return $"Email sent to {to} with subject '{subject}'" ;
        }
    }
}
 