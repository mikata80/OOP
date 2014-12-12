using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class AnimalsExample
    {
        static void Main()
        {
            Dog sharo = new Dog("Sharo", 10, "male");
            Dog lady = new Dog("Lady", 3, "Female");
            Cat caty = new Cat("Caty", 4.4, "male");
            Kitten kitten = new Kitten("Kitence", 6.2);
            Tomcat jery = new Tomcat("Jery", 9.8);
            Frog cermit = new Frog("Cermit",4,"male");
            Frog frogie = new Frog("Forgie", 1.5, "male");

            List<Animals> allAnimals = new List<Animals>() {sharo,caty,kitten,jery,cermit,lady ,frogie};
            foreach (var animal in allAnimals)
            {
                Console.Write(animal.Name+ ", says: ");
                animal.ProduceSound();
            }
            // all kinds
            Dictionary<string, Tuple<int, double>> avgAges = new Dictionary<string, Tuple<int, double>>();
            foreach (var animal in allAnimals)
            {
                var key = animal.GetType();
                if (!avgAges.ContainsKey(key.Name))
                {
                    avgAges.Add(key.Name, new Tuple<int, double>(1, animal.Age));
                }
                else
                {
                    avgAges[key.Name] = new Tuple<int, double>(avgAges[key.Name].Item1 + 1, avgAges[key.Name].Item2 + animal.Age);
                }
            }

            Console.WriteLine();
            var res = from kind in avgAges
                      select kind.Key + " => average age: " + kind.Value.Item2 / kind.Value.Item1;
            foreach (var r in res)
            {
                Console.WriteLine(r);
            }
        }
    }
}
