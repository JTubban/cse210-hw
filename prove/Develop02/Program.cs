using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Journal journal = new Journal();

        string choice;
        do {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1") 
            {
                journal.AddEntry();
            }
            else if (choice == "2") {
                journal.Display();
            }
            else if (choice == "3") {
                journal.LoadFile();
            }
            else if (choice == "4"){
                journal.SaveFile();
            }

        }while (choice != "5");

        Console.WriteLine("Thank you, please update your journal again!");
    }
}