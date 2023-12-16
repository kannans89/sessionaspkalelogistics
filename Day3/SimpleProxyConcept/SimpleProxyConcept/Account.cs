using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProxyConcept
{
    internal class Account
    {

        public virtual void Deposit() {
            Console.WriteLine("deposit inside account (Expensive/Real object)");
        }
    }
}
