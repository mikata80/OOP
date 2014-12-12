using System;

namespace DelegatesEvents
{

    class InterestCalculator  
    {
        static void Main()
        {
            CalculateInterest compound = new CalculateInterest(GetCompoundInterest);
            CalculateInterest simple = new CalculateInterest(GetSimpleInterest);
            compound(500.00, 5.6, 10);
            simple(2500, 7.2, 15);
        }

        public delegate void CalculateInterest(double sum, double interest, int years);

        public static void GetCompoundInterest(double sum, double interest, int years)
        {
            double inter = (1 + (interest / 100)/12);
            double res = sum * Math.Pow(inter, (years * 12));
            Console.WriteLine(String.Format("{0:0.00##}",res));
        }

        public static void GetSimpleInterest(double sum, double interest, int years)
        {
            double res = sum * (1 + interest / 100 * years);
            Console.WriteLine(String.Format("{0:0.00##}", res));
        }

        
    }
}
