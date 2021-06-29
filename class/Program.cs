using System;

namespace classdemo
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Person();
            student1.firstName = "Habieber";
            student1.lastName = "Kadhi";
            student1.Introduce();
        }
    }
}
