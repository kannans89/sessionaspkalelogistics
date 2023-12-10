using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal abstract class AutomationHanlderBase
    {
        private AutomationHanlderBase? _next;

        public abstract void Handle(HomeConfiguration config);
        public void SucceedWith(AutomationHanlderBase nextInChain) { 
          _next = nextInChain;
        }

        protected void Next(HomeConfiguration config) { 
        
             if(_next!= null)
            {
                _next.Handle(config);
            }
        }
    }
}
