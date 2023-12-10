using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class AlarmHanlder : AutomationHanlderBase
    {
        public override void Handle(HomeConfiguration config)
        {
            Console.WriteLine("checking for alarms");
            if (config.AlarmsOn)
            {
                Next(config);
            }
            else
            {
                throw new Exception("Some alarms are not on..abort mission");
            }
        }
    }
}
