using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Globalization;

namespace MethodOverloading
{
    internal class Program
    {
        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine($"Integer Sum: {sum}");
            return sum;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            decimal sum = num1 + num2;
            Console.WriteLine($"Decimal Sum: {sum}");
            return sum;
        }

        public static string Add(int num1, int num2, bool stayHard)
        {
            int sum = num1 + num2;
            string result;

            if (stayHard)
            {
                result = sum > 1 ? $"{sum} dollars" : $"{sum} dollar";
            }
            else
            {
                result = sum.ToString(CultureInfo.InvariantCulture);
            }

            Console.WriteLine($"String Sum: {result}");
            return result;
        }

        static void Main(string[] args)
        {
            // Call and display the result of the first Add method
            int intSum = Add(5, 10);

            // Call and display the result of the second Add method
            decimal decimalSum = Add(5.5m, 10.5m);

            // Call and display the result of the third Add method
            string strSum = Add(3, 2, true);


        }//else
    }
}













