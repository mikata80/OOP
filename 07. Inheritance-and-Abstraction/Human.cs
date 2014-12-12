using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanWorkerStudents
{
    abstract class Human
    {
        public string FirtsName { get; set; }
        public string LastName { get; set; }

        public Human(string firstname, string lastname)
        {
            this.FirtsName = firstname;
            this.LastName = lastname;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}",FirtsName,LastName);
        }
    }
}
