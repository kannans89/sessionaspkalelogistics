﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWithEFApp.Domain
{
    
    public class Organization
    {
     
        public int Id { get; set; } 
        public string Name { get; set; }

        //list of department

       // public virtual ICollection<Department> Departments { get; set; } = new List<Department>();
    }
}
