using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello my World!");
            Console.WriteLine("Hello my World (part 2)!");

            var r = Sum(1m, 2m);
            var b = Mult(2m, 5m);
            var c = Sub(3m, 2m);
            var d = Div(2m, 0m);
        }

        static object Div(decimal v1, decimal v2)
        {
            if (v2 == 0)
                return 0;

            return v1 / v2;
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
