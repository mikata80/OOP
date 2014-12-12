using System;


namespace Static_Members_and_Namespaces
{
    class StaticMembers
    {
        static void Main()
        {
            Point3D point = new Point3D(12, 13, 14);
            //Point3D point2 = new Point3D(5.5, 7.56, 100.99);
            Console.WriteLine(Point3D.StartPoint);
            Console.WriteLine(point.ToString());
            //Console.WriteLine(point2.ToString());
            //double p = DistanceCalculator.DistanceCalculator.calcDistance(1, 2, 3, 4, 5, 6);
            //Console.WriteLine(p);
        }

    }

    class Point3D
    {
        private double X;
        private double Y;
        private double Z;
        private static readonly Point3D startPoint;

        static Point3D()
        {
            Point3D.startPoint = new Point3D(0, 0, 0);
        }
        public static Point3D StartPoint
        {
            get
            {
                return startPoint;
            }

        }
        public Point3D(double X, double Y, double Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public override string ToString()
        {
           // return String.Format("Before\n{0}\nAfter\nX: {1} Y: {2} Z: {3}", StratPoint, X, Y, Z);
            return String.Format("Point => X:{0} Y:{1} Z:{2}",X, Y, Z);
        }
    }
}
