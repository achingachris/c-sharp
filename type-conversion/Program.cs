using System;

namespace type_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte b =2;
            // int i = b;
            // Console.WriteLine(i);

            // int i = 255;
            // byte b = (byte) i;

            // Console.WriteLine(b);

            // var number = "12345";
            // int i = Convert.ToInt32(number);

            // Console.WriteLine(i);

            try
            {
                
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Conversion Failed");
            }


            try
            {
               string str = "true";
               bool b = Convert.ToBoolean(str);
               Console.WriteLine(b);
            }
            catch (System.Exception)
            {
                
                Console.WriteLine("Conversion Failed");
            }

        }
    }
}
