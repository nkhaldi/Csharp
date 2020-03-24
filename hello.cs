using System;

class MailClass
{
	static void Main(string[] args)
	{
		Console.WriteLine("What is your name?");
		string name = Console.ReadLine();
		Console.WriteLine($"Hello, {name}!");
	}
}
