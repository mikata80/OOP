using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDisperser
{
    class StringDisperserExample 
    {
        static void Main()
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "taniy");
            StringDisperser stringDisperser1 = new StringDisperser("gosho", "pesho", "tanio","aaa");
            StringDisperser stringDisperser2 = (StringDisperser)stringDisperser.Clone();
            StringDisperser stringDisperser3 = new StringDisperser("aaaaa", "bbbb", "cccccc", "dddd");

            Console.WriteLine(stringDisperser.ToString());
            Console.WriteLine();
            
            Console.WriteLine("========================================");
            Console.WriteLine("GetHashCode: {0}", stringDisperser.GetHashCode());
            Console.WriteLine("GetHashCode: {0}", stringDisperser1.GetHashCode());
            Console.WriteLine("GetHashCode: {0}", stringDisperser2.GetHashCode());
            Console.WriteLine("Equal: {0}", stringDisperser.Equals(stringDisperser3));
            Console.WriteLine("==: {0}", stringDisperser == stringDisperser3);
            Console.WriteLine("!=: {0}", stringDisperser != stringDisperser3);

            Console.WriteLine("========================================");
            StringDisperser[] arr = { stringDisperser, stringDisperser1, stringDisperser2 ,stringDisperser3};
            Array.Sort(arr,
               (a, b) =>
                    a.ToString().CompareTo(b.ToString())
                    );
            foreach (var str in arr)
            {
                Console.WriteLine(str.ToString());
            }

            Console.WriteLine("========================================");
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine();

        }
    }
}
