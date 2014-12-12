using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class EnterNumbers
    {
        static void Main()
        {
            EnterNumbers.enterNumbes(1, 10);
        }

        private static void enterNumbes(int start, int end)
        {
            List<Int32> list = new List<Int32>();
            int lastNum = 0;
            Console.WriteLine("Enter numbers from {0} to {1}", start, end);
            for (int i = start; i <= end; i++)
            {
                try
                {


                    int num = int.Parse(Console.ReadLine());
                    if (lastNum > num)
                    {
                        throw new ArithmeticException();
                    }
                    else
                    {
                        lastNum = num;
                    }
                    list.Add(num);

                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Invalid format! Enter again!");
                    throw fe;
                }
                catch (ArithmeticException ae)
                {
                    Console.WriteLine("Entered number! must be gather than last enterd number!");
                    throw ae;
                }

            }

            foreach (var n in list)
            {
                Console.Write(n + " ");

            }
            Console.WriteLine("\nGood bye!!!");
        }
    }
}
