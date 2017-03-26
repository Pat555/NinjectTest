using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    public interface IMailSender
    {
        void Send(string toAddress, string subject);
    }



    class MailSender : IMailSender
    {
        private readonly ILogging logging;

        public MailSender(ILogging logging)
        {
            this.logging = logging;
            logging.Log("Error log test.");
        }

        public void Send(string toAddress, string subject)
        {
            Console.WriteLine("Sending mail to [{0}] with subject [{1}]", toAddress, subject);
        }
    }
}
