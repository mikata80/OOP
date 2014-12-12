using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDisperser
{
    class test : StringDisperser
    {

    }

    class MyClass
	{
        static void Main() 
        {
            test t = new test();
            Console.WriteLine(t.ToString());
        }
	}
	
}
