using System;

namespace primitive_types
{
    class Program
    {
        static void Main(string[] args)
        {
        //    byte number = 23;
        //    int count = 5;
        //    float totalPrice = 33.23f;
        //    char character = 'Q';
        //    string name = "Chris";
        //    bool isActive = false;

           var number = 23;
           var count = 5;
           var totalPrice = 33.23f;
           var character = 'Q';
           var name = "Chris";
           var isActive = false;

           Console.WriteLine(number);
           Console.WriteLine(count);
           Console.WriteLine(totalPrice);
           Console.WriteLine(character);
           Console.WriteLine(name);
           Console.WriteLine(isActive);

           Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
           Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
        }
    }
}
