// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Line Comparison Computation Program on Master Branch");
using System;
namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {

            length test1 = new length();
            test1.coordinate();
            equality test2 = new equality();
            test2.compare();
        }
    }
}