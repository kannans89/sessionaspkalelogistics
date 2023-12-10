using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class HomeConfiguration
    {

        public bool LightsOff { get; set; }
        public bool LocksOn { get; set; }

        public bool AlarmsOn { get; set; }

        public HomeConfiguration() {
            LightsOff = true;
            LocksOn = true;
            AlarmsOn = true;
        }
    }
}
