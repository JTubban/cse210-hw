using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Console.WriteLine();

        Console.WriteLine("What is your favorite number? ");
        string valueInText = Console.ReadLine();
        int number = int.Parse(valueInText);
        Console.WriteLine(number);

    }
}