using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    class LINQExtensios
    {
        public static void Main()
        {
            string[] strItems = { "Pesho", "Gosho", "Tosho", "Kiro" ,"Kalin"};
            
            var res = strItems.Where(str => str.StartsWith("K"));
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        //public static IEnumerable<T> WhereNot<T>(this IEnumerable<T>,Func<T, bool> predicate)
        //{
        //    return IEnumerable<T>;
        //}
    }
}
