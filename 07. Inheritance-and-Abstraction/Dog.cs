using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Animals
    {
        public Dog(string name, double age, string gender)
            : base(name, age, gender)
        {
            this.Name = name;
            this.Age = age;
            this.Genger = gender;
        }



        //public override void ProduceSound()
        //{
        //    Console.WriteLine("Bau,bau,bauuuuu!");
        //}

        public override void ProduceSound()
        {
            Console.WriteLine("Bau,bau,bauuuuu!");
        }
    }
}
