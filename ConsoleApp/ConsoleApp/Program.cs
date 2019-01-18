using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var r = Sum(1m, 2m);
        }

        static decimal Sum(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
