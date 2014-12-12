using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten:Cat
    {
        public Kitten(string name, double age, string gender = "female")
            :base(name,age,gender)
        {
            this.Name = name;
            this.Age = age;
            this.Genger = gender;
        }
    }
}
