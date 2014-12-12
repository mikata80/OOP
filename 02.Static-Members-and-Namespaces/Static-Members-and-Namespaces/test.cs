using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Members_and_Namespaces
{
    class test
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Get the directories currently on the C drive.
                DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();

                // Write each directory name to a file. 
                using (StreamWriter sw = new StreamWriter("points.txt"))
                {
                    foreach (DirectoryInfo dir in cDirs)
                    {
                        sw.WriteLine(dir.Name);

                    }
                }

                // Read and show each line from the file. 
                string line = "";
                using (StreamReader sr = new StreamReader("points.txt"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
