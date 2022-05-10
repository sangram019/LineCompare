using System;
using System.Collections.Generic;
using System.Text;


namespace LineComparison
{
    public class equality
    {
        public void compare()
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
            Console.WriteLine("Please enter p and q coordinates ");
            double p = Convert.ToDouble(Console.ReadLine());
            double q = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter r and s coordinates ");
            double r = Convert.ToDouble(Console.ReadLine());
            double s = Convert.ToDouble(Console.ReadLine());
            double finalResult2 = Distance(p, r, q, s);
            Console.WriteLine("Distance between {0},{1} and {2},{3} is {4:F}", p, q, r, s, finalResult2);
            int res = finalResult.CompareTo(finalResult2);
            Console.WriteLine(res);
            if (res == 0)
            {
                Console.WriteLine("Lengths are equal!");
            }
            if (res > 0)
            {
                Console.WriteLine("Line 1 is greater than line 2 ");
            }
            else
            {
                Console.WriteLine("Line 2 is greater than line 1 ");
            }
        }
    }
}