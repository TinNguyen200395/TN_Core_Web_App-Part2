using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TN_Core_Web_App.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
