using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Members_and_Namespaces
{

    class SoftUn
    {
        static void Main()
        {
            double point1 = DistanceCalculator.calcDistance(1, 2, 3, 4, 5, 6);
            double point2 = DistanceCalculator.calcDistance(-1, -45.78, 98.56, -445.45, 55, 66.66);
            Console.WriteLine("Distace = {0}", String.Format("{0:0.00}", point1));
            Console.WriteLine("Distace = {0}", String.Format("{0:0.00}", point2));
        }
    }
    static class DistanceCalculator
    {
        public static double calcDistance(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double x2x1 = Math.Pow((x2 - x1), 2);
            double y2y1 = Math.Pow((y2 - y1), 2);
            double z2z1 = Math.Pow((z2 - z1), 2);
            double total = x2x1 + y2y1 + z2z1;
            return Math.Sqrt(total);
        }

    }


}
