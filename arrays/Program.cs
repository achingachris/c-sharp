using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // if value not assinged, default values of the data type will be assigned

            var numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            //  boolean
            var isValid = new bool[3];
            isValid[0] = true;
            Console.WriteLine(isValid[0]);
            Console.WriteLine(isValid[1]);
            Console.WriteLine(isValid[2]);

            // strings
            var names = new string[3] {"Habieber", "K", "Kadhi"};
            // bug : does not print details
            Console.WriteLine(names);
        }
    }
}
