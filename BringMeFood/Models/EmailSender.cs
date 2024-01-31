using Microsoft.AspNetCore.Identity.UI.Services;

namespace BringMeFood.Models
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessaage)
        {
            return Task.CompletedTask;
        }
    }
}
