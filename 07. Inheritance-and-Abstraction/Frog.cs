using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog:Animals
    {
        public Frog(string name, double age, string gender)
            :base(name,age,gender)
        {
            this.Name = name;
            this.Age = age;
            this.Genger = gender;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Crackk,crackk,crackkkkkk!");
        }
    }
}
