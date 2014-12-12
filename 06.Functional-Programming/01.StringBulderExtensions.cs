using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    public static class StringBulderExtensions
    {
        static void Main()
        {
            string interval = " ";
            StringBuilder sb = new StringBuilder();
            sb.Append("Milen Petrov");
            sb.AppendLine();
            sb.Append("SoftUni");
            sb.Append(interval);
            sb.Append("Sofia");

            int[] items = { 1, 2, 3, 4, 5 };
            string[] strItems = { "Pesho", "Gosho", "Tosho", "Kiro" };
            
            Console.WriteLine(sb.Substring(0,4));
            Console.WriteLine();
            Console.WriteLine(sb.RemoveText("Milen Petrov"));
            Console.WriteLine();
            Console.WriteLine(sb.AppendAll(items));
            Console.WriteLine();
            Console.WriteLine(sb.AppendAll(strItems));
        }

        public static string Substring(this StringBuilder sb, int startIndex, int endLength)
        {
            string res = "";

            if (startIndex < 0 || startIndex > sb.Length)
            {
                throw new ArgumentOutOfRangeException("Start index must be > 0 and < of StringBuilder's length! ");
            }

            if (endLength > sb.Length)
            {
                endLength = sb.Length;
            }

            if (endLength < 0 || endLength < startIndex)
            {
                throw new ArgumentOutOfRangeException("End length must be > 0 and > of Start index! ");
            }

            for (int i = startIndex; i < endLength; i++)
            {
                res += sb[i];
            }
            return res;
        }

        public static string RemoveText(this StringBuilder sb, string text)
        {
            string res = sb.ToString().Replace(text, "");
            return res;
        }

        public static StringBuilder AppendAll<T>(this StringBuilder strBuilder,IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                strBuilder.AppendLine().Append(item.ToString()).Append(' ');
            }
            return strBuilder;
        }
    }
}
