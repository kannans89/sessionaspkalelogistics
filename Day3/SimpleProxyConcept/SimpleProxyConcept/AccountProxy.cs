using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProxyConcept
{
    internal class AccountProxy:Account
    {
        public override void Deposit()
        {//before deposit
            Console.WriteLine("(deposit of proxy)Proxy doing work before calling real deposit");
            base.Deposit();
        }
    }
}
