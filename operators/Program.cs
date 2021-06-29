using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;
            var d = 10;

            // normal operations
            Console.WriteLine(d / c);

            // getting results in floating point numbers
            Console.WriteLine("floating point number");
            Console.WriteLine((float)d / (float)c);

            // using operator precedence
            Console.WriteLine("opeartor precedence");
            Console.WriteLine(a + b * c);
            Console.WriteLine((a + b) * c);

            // using comparison operators
            Console.WriteLine("Comparison Operators");
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(!(a != b));

            // logical operators
            Console.WriteLine("Logical Operators");
            Console.WriteLine(c > b && c > a);
            Console.WriteLine(c > b && c == a);
            Console.WriteLine(c > b || c == a);
        }
    }
}
