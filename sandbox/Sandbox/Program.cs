using System;
using System.Collections.Generic;
using System.IO;
// using System.Linq;


class Program
{
    // static void Main(string[] args)
    // {
        // Console.WriteLine("Hello Sandbox World!");

        // Console.WriteLine();

        // Console.WriteLine("What is your favorite number? ");
        // string valueInText = Console.ReadLine();
        // int number = int.Parse(valueInText);
        // Console.WriteLine(number);

        // List<String> questions = new List<string>
        // {
        //     "What is the capital of France?",
        //     "Who wrote the play 'Romeo and Juliet'?",
        //     "What is the largest planet in our solar system?",
        //     "How many continents are there on Earth?",
        // };

        // Random
        // Random randomGenerator = new Random();
        // int index = randomGenerator.Next(questions.Count);
        // Console.WriteLine(questions[index]);
        // Console.WriteLine(randomGenerator.Next(3));

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

        // void HelloWorld (string word)
        // {
        //     Console.WriteLine($"Hello {word}!");
        // }

        // Console.Write("Please enter a word: ");
        // string word = Console.ReadLine();

        // HelloWorld(word);
    // }

    // public class Student 
    // {
    //     public string _fullName;
    //     public int _currentYear;
    //     public int _birthYear;
    //     public double ComputeAge()
    //     {
    //         return _currentYear - _birthYear;
    //     }
    // }

    // Student person1 = new Student();
    // person1._fullName = "James Tubban";
    
    // static void Main(string[] args)
    // {
    //     Blind kitchen = new Blind();
    //     kitchen._width = 60;
    //     kitchen._height = 48;
    //     kitchen._color = "white";

    //     double materialAmount = kitchen.GetArea();
    //     // Console.WriteLine(materialAmount);

    //     Blind livingRoom = new Blind();
    //     livingRoom._width = 72;
    //     livingRoom._height = 52;
    //     livingRoom._color = "gray";

    //     double materialAmount1 = livingRoom.GetArea();
    //     // Console.WriteLine(materialAmount1);

    //     House johnsonHome = new House();

    //     johnsonHome._blinds.Add(kitchen);
    //     johnsonHome._blinds.Add(livingRoom);

    //     johnsonHome._owner = "Johnson Family";
    //     // johnsonHome._blinds[0]._width = 160;

    //     // Console.WriteLine(johnsonHome._owner);
    //     // Console.WriteLine(johnsonHome._blinds[1]._width);
    //     // Console.WriteLine(johnsonHome._blinds[1].GetArea());
    //     foreach (Blind b in johnsonHome._blinds)
    //     {
    //         Console.WriteLine(b.GetArea());
    //     }
    // }

    // static void Main(string[] args)
    // {
    //     Job job1 = new Job();
    //     job1._jobTitle = "Software Engineer";
    //     job1._company = "Microsoft";
    //     job1._startYear = 2019;
    //     job1._endYear = 2022;

    //     Job job2 = new Job();
    //     job2._jobTitle = "Manager";
    //     job2._company = "Apple";
    //     job2._startYear = 2022;
    //     job2._endYear = 2023;

    //     // job1.Display();
    //     // job2.Display();

    //     Resume myResume = new Resume();
    //     // myResume._myName = "Allison Rose";

    //     myResume._jobs.Add(job1);
    //     myResume._jobs.Add(job2);

    //     myResume.Display();
    // }

    static void Main(string[] args) 
    {
        // DateTime theCurrentTime = DateTime.Now;
        // string dateText = theCurrentTime.ToShortDateString();

        // Console.WriteLine(dateText);

        // Console.WriteLine("James Tubban\nJuliet Tubban\nJaxx Tubban");

        string filename = "journal.txt";
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {   
            string[] parts = line.Split("|");
            string firstName = parts[0];
            string middleName = parts[1];
            string lastName = parts[2];

            Console.WriteLine($"{firstName} {middleName} {lastName}");
        }
    }
}

