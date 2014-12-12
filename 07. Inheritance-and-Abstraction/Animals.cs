using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animals : ISound
    {
        public string Name { get; set; }

        public double Age { get; set; }

        public string Genger { get; set; }

        public Animals(string name, double age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Genger = gender;
        }

        public abstract void ProduceSound();
    }
}
