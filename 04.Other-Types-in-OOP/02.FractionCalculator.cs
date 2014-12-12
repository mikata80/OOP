using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Other_Types_in_OOP
{
    class FractionCalculator
    {
        static void Main()
        {

            Fraction fraction1 = new Fraction(22, 7);
            Fraction fraction2 = new Fraction(40, 4);
            Fraction result = fraction1 + fraction2;
            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);
            Fraction result2 = fraction1 - fraction2;
            Console.WriteLine(result2.Numerator);
            Console.WriteLine(result2.Denominator);
            Console.WriteLine(result2);

        }

        struct Fraction
        {
            private long numerator;
            private long denominator;

            public Fraction(long numerator, long denominator)
                : this()
            {
                this.Numerator = numerator;
                this.Denominator = denominator;
            }
            public long Numerator
            {
                get
                {
                    return this.numerator;
                }
                set
                {
                    this.numerator = value;
                }
            }
            public long Denominator
            {
                get
                {
                    return this.denominator;
                }
                set
                {
                    if (value == 0)
                    {
                        throw new ArgumentOutOfRangeException("Denominator must be <> 0!");
                    }
                    this.denominator = value;
                }
            }

            public static Fraction operator -(Fraction frac1, Fraction frac2)
            {
                // 2/3 - 4/6
                long newNumerator = ((frac1.numerator * frac2.denominator) - (frac1.denominator * frac2.numerator));
                long newDenominator = frac1.denominator * frac2.denominator;
                return new Fraction(newNumerator, newDenominator);
            }

            public static Fraction operator +(Fraction frac1, Fraction frac2)
            {
                // 2/3 - 4/6
                long newNumerator = ((frac1.numerator * frac2.denominator) + (frac1.denominator * frac2.numerator));
                long newDenominator = frac1.denominator * frac2.denominator;
                return new Fraction(newNumerator, newDenominator);
            }
            public override string ToString()
            {
                decimal res = ((decimal)Numerator / (decimal)Denominator);
                return res.ToString();
            }
        }
    }



}

