using System;

namespace stringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Habieber";
            var lastName = "Kadhi";

            var fullName = firstName + " " + lastName;

            var crushName = string.Format("My crush is {0} {1}", firstName, lastName);

            Console.WriteLine(fullName);
            Console.WriteLine(crushName);

            var countries = new string[3] {"Switzerland", "German", "France"};
            var allCountries = string.Join(",", countries);
            Console.WriteLine(allCountries);
        }
    }
}
