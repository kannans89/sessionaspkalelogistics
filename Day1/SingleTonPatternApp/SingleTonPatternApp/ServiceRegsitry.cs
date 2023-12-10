using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPatternApp
{
    internal class ServiceRegsitry
    {
        private static ServiceRegsitry? _bucket;
        private static object _lockObject = new object();
        private ServiceRegsitry() {
            Console.WriteLine("Service Regstiry created");
        }

        public void DoProcessing() {
            Console.WriteLine("registry doing searching "+this.GetHashCode());
        }


        public static ServiceRegsitry GetInstance() {
            lock (_lockObject)
            {
                if (_bucket == null)
                    _bucket = new ServiceRegsitry();

                return _bucket;
            }
        }

    }
}
