using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClass
{
    class Person
    {
        private string personName;

        public string Name
        {
            get
            {
                return this.personName;
            }
            set
            {
                this.personName = value;
            }
        }
        public Person(string name)
        {
            this.Name = name;
        }
    }
}
