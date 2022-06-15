using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coach_Travel_Web_App.EmailServices
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}
