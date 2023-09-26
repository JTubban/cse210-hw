using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); 
        bool exit = false;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (!exit)
        {
            Console.Write("Enter a number: ");
            string valueFromUser = Console.ReadLine();
            if (valueFromUser == "0")
            {
                exit = true;
            }
            else
            {
                int number = int.Parse(valueFromUser);
                numbers.Add(number);
            }
        }

        if (exit)
        {
            double sumAll = 0;
            foreach(int number in numbers)
            {
                sumAll += number;
            }

            double items = numbers.Count;
            double average = sumAll / items;
            int largest = numbers.Max();

            Console.WriteLine($"The sum is: {sumAll}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largest}");
        }
    }
}