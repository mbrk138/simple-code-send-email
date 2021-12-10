using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_email_3._1.Model
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
        Task SendWelcomeEmailAsync(WelcomeRequest request);
    }
}
