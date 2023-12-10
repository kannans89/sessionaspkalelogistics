using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class LocksHandler : AutomationHanlderBase
    {
        public override void Handle(HomeConfiguration config)
        {
            Console.WriteLine("checking for locks");
            if (config.LocksOn)
            {
                Next(config);
            }
            else
            {
                throw new Exception("Some locks are not on..abort mission");
            }
        }
    }
}
