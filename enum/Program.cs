using System;

namespace enumDemo
{
    public enum travelAir
    {
        economy = 12,
        premiumEconomy = 10,
        business = 5
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = travelAir.business;
            Console.WriteLine((int)method);
        }
    }
}
