using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    public interface ILogging
    {
        void Log(string message);
    }

    class Logging : ILogging
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging. {0}", message);
        }
    }
}
