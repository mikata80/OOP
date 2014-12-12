using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class SquareRoot
    {
        static void Main()
        {
            Console.Write("Entre a number:");

            try
            {
                uint num = uint.Parse(Console.ReadLine());
                Console.WriteLine("Sqrt = "+ Math.Sqrt(num));
            }
            catch (FormatException fe)
            {

                Console.WriteLine("Invalid number !");
             //   throw fe;
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("Invalid number !");
               // throw oe;
            }
            finally{
                Console.WriteLine("Good bye");
            }

        }

    }
}
