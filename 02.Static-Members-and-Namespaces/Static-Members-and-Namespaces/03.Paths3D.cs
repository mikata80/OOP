using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Members_and_Namespaces
{
    class loadPaths3D
    {
        public static void Main() { 

            Storage.getFilePath("points.txt",@"c:\Mikata\My Documents\Google Disk\SoftUniversity\OOP\02.Static-Members-and-Namespaces\Static-Members-and-Namespaces\Static-Members-and-Namespaces\storage");
            Storage.getFilePath("points1.txt", @"c:\Mikata\My Documents\Google Disk\SoftUniversity\OOP\02.Static-Members-and-Namespaces\Static-Members-and-Namespaces\Static-Members-and-Namespaces\storage");

        }
    }
    
    class Paths3D {
        
        private List<Point3D> points = new List<Point3D>();
        
        public Paths3D() { 
        }    

        
    }

    static class Storage {

        private static Dictionary<string, string> filePaths = new Dictionary<string, string>();

        public static void getFilePath(string fileName,string path) {
            filePaths.Add(fileName, path);
        }
    
    }
}
