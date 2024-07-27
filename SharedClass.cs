using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTeam
{
    //Create a shared class that it can inherit properties
    public class SharedClass
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }  
        public string Position { get; set; }
    }
}
