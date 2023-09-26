using System;
using System.Collections.Generic;
// using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");

        // Console.WriteLine();

        // Console.WriteLine("What is your favorite number? ");
        // string valueInText = Console.ReadLine();
        // int number = int.Parse(valueInText);
        // Console.WriteLine(number);

        // Random
        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1, 11);
        // Console.WriteLine(number);

        // Loops
        // string response = "yes";
        // while (response == "yes")
        // {
            // Console.Write("Do you want to continue? ");
            // response = Console.ReadLine();
        // }
        
        // string response;
        // do {
            // Console.Write("Do you want to continue? ");
            // response = Console.ReadLine();
        // }while (response == "yes")

        // for (int i=0; i<11; i++)
        // {
            // Console.WriteLine(i);
        // }

        // foreach (string color in colors)
        // {
            // Console.WriteLine(color);
        // }

        // LIST
        // List<string> names = new List<string>();
        // names.Add("James");
        // names.Add("Juliet");
        // names.Add("Jaxx");
        
        // Console.WriteLine(names.Count);

        // foreach (string name in names)
        // {
        //     Console.WriteLine(name);
        // }

        // for (int i=0; i<names.Count; i++)
        // {
        //     Console.WriteLine(names[i]);
        // }

        // Getting the list size
        // You can get the size of the list with the Count property.
        // C#
        // Console.WriteLine(words.Count);
        // Python
        // print(len(words))

        // W02 ASSIGNMENT
        // List<int> numbers = new List<int>(); 
        // bool exit = false;
        
        // Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        // while (!exit)
        // {
        //     Console.Write("Enter a number: ");
        //     string valueFromUser = Console.ReadLine();
        //     if (valueFromUser == "0")
        //     {
        //         exit = true;
        //     }
        //     else
        //     {
        //         int number = int.Parse(valueFromUser);
        //         numbers.Add(number);
        //     }
        // }

        // if (exit)
        // {
        //     double sumAll = 0;
        //     foreach(int number in numbers)
        //     {
        //         sumAll += number;
        //     }

        //     double items = numbers.Count;
        //     double average = sumAll / items;
        //     int largest = numbers.Max();

        //     Console.WriteLine($"The sum is: {sumAll}");
        //     Console.WriteLine($"The average is: {average}");
        //     Console.WriteLine($"The largest number is: {largest}");
        // }

        // List<int> numbers = new List<int>(); 
        // bool exit = false;
        
        // Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        // while (!exit)
        // {
        //     Console.Write("Enter a number: ");
        //     string valueFromUser = Console.ReadLine();
        //     if (valueFromUser == "0")
        //     {
        //         exit = true;
        //     }
        //     else
        //     {
        //         int number = int.Parse(valueFromUser);
        //         numbers.Add(number);
        //     }
        // }

        // if (exit)
        // {
        //     double sumAll = 0;
        //     foreach(int number in numbers)
        //     {
        //         sumAll += number;
        //     }

        //     double items = numbers.Count;
        //     double average = sumAll / items;
        //     int largest = numbers.Max();

        //     Console.WriteLine($"The sum is: {sumAll}");
        //     Console.WriteLine($"The average is: {average}");
        //     Console.WriteLine($"The largest number is: {largest}");
        // }

        void HelloWorld (string word)
        {
            Console.WriteLine($"Hello {word}!");
        }

        Console.Write("Please enter a word: ");
        string word = Console.ReadLine();

        HelloWorld(word);
    }
}