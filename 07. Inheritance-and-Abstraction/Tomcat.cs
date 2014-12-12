using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string name, double age, string gender = "male")
            : base(name, age, gender)
        {
            this.Name = name;
            this.Age = age;
            this.Genger = gender;
        }
    }
}
