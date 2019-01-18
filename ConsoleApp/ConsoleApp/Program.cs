using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var r = Sum(1m, 2m);
            var b = Mult(2m, 5m);
            var c = Sub(3m, 2m);
        }

        static object Sub(decimal v1, decimal v2)
        {
            return v1 - v2;
        }

        static object Mult(decimal v1, decimal v2)
        {
            return v1 * v2;
        }

        static decimal Sum(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
