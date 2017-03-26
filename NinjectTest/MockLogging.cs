using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    class MockLogging : ILogging
    {
        public void Log(string message)
        {
            Console.WriteLine("Mock logging. {0}", message);
        }
    }
}
