using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;

namespace NinjectTest
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IMailSender>().To<MockMailSender>();
            Bind<ILogging>().To<MockLogging>();
        }
    }
}
