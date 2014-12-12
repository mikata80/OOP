using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    interface IEmploee
    {
        public Department Deparment { get; set; }
        public double Salary{ get; set; }
    }
}
