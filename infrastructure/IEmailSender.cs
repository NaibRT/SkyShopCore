using System;
using System.Threading.Tasks;

namespace skyshopCore.infrastructure{
   public interface  IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}