using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEFCoreApp.Domain
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

    }
}
