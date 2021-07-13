using System;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime().Now().Year();


            Console.WriteLine(dateTime.Year);
        }
    }
}
