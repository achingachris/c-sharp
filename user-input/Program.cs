using System;

namespace user_input
{
    class Test
	{
		public static void Main(string[] args)
		{
			string name;
			Console.WriteLine("What is your name?");
			name = Console.ReadLine();
			Console.WriteLine("Hello {0}, Welcome to the console", name);
		}
	}
}
