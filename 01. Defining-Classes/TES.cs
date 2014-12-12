using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Definig_Classes
{
    class TES
    {
        public string fName;

        public TES (){
        }
    }
    class vak:TES
    {
        
    }
    class MyClass
    {
        public static void Main() {
            vak v = new vak();
            v.fName = "aaa";
            Console.WriteLine(v.fName);

        }
    }

}
