using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCompare
{
    public class length
    {
        public static void lengt()
        {
            Console.WriteLine("Welcome to Line Comparison Computation!");
            Console.WriteLine("Please enter a and b coordinates :");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter c and d coordinates :");
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double finalResult = Distance(a, b, c, d);
            Console.WriteLine("Distance between {0},{1} and {2},{3} is {4:F}", a, b, c, d, finalResult);

            static double Distance(double a, double b, double c, double d)
            {
                double temp1 = Math.Pow((c - a), 2);
                double temp2 = Math.Pow((d - b), 2);
                double result = Math.Sqrt(temp1 + temp2);
                return result;
            }

        }
    }
}