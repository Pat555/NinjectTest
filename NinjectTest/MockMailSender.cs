using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    class MockMailSender : IMailSender
    {
        private readonly ILogging logging;

        public MockMailSender(ILogging logging)
        {
            this.logging = logging;
            logging.Log("MockMailSender error log test.");
        }

        public void Send(string toAddress, string subject)
        {
            Console.WriteLine("Mocking mail to [{0}] with subject [{1}]", toAddress, subject);
        }
    }
}
