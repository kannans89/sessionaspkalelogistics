using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class LightsHanldler : AutomationHanlderBase
    {
        public override void Handle(HomeConfiguration config)
        {
            Console.WriteLine("checking for lights");
            if (config.LightsOff)
            {
                Next(config);
            }
            else {
                throw new Exception("Some lights are on..abort mission");
            }
        }
    }
}
