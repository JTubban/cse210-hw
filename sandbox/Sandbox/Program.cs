// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Runtime;
// using System.Security.Cryptography.X509Certificates;
// using System.Linq;


// class Program
// {
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

    // static void Main(string[] args) 
    // {
    //     DateTime theCurrentTime = DateTime.Now;
    //     string dateText = theCurrentTime.ToShortDateString();

    //     Console.WriteLine(dateText);

    //     Console.WriteLine("James Tubban\nJuliet Tubban\nJaxx Tubban");

    //     string filename = "journal.txt";
    //     string[] lines = File.ReadAllLines(filename);

    //     foreach (string line in lines)
    //     {   
    //         string[] parts = line.Split("|");
    //         string firstName = parts[0];
    //         string middleName = parts[1];
    //         string lastName = parts[2];

    //         Console.WriteLine($"{firstName} {middleName} {lastName}");
    //     }
    // }

    //  static void Main(string[] args) 
    // {
    //     Account savings = new Account();
        
    // }
    // static void Main(string[] args) 
    // {   
    //     // Account savings = new Account();
    //     // savings._balance = 50;
    //     // savings.Deposit(100);

    //     // Console.WriteLine(savings._balance);
    
    //     List<Student> studentList = new List<Student>();

    //     Student student1 = new Student();
    //     student1._firstName = "James";
    //     student1._lastName = "Tubban";
    //     student1._age = 32;

    //     Student student2 = new Student();
    //     student2._firstName = "Juliet";
    //     student2._lastName = "Taguiam";
    //     student2._age = 31;

    //     studentList.Add(student1);
    //     studentList.Add(student2);

    //     foreach(Student student in studentList) {
    //         Console.WriteLine(student._firstName);
    //         Console.WriteLine(student._lastName);
    //     }

    // }

    // static void Main(string[] args) {
    //     Account savings = new Account();
    //     savings.Deposit(1000);
    //     savings.Deposit(2000);
    // }

    // static void Main(string[] args) {
    //     Person p1 = new Person("Software Engineer", "James", "Tubban");
    //     Person p2 = new Person();
    //     Console.WriteLine(p1.GetFormalSigniture());
    //     Console.WriteLine(p2.GetFormalSigniture());
    // }

    // static void Main(string[] args)
    // {
        // // Create Instance
        // Fraction fraction1 = new Fraction(10);

        // Console.WriteLine(fraction1.GetStringValue());
        // Console.WriteLine(fraction1.GetDecimalValue());

        // Random generateRandom = new Random();
        // List<string> myList = new List<string>{"My", "name", "is", "James", "I", "live", "in", "Cagayan", "Valley"};
        // int index = generateRandom.Next(myList.Count);

        // Console.WriteLine(myList[index]);

        // string joinedString = string.Join(" ", myList);
        // Console.WriteLine(joinedString);

        // string myName = "James";
        // int nameLength = myName.Length;

        // myName = "-" * nameLength;

        // Console.WriteLine(myName);



        // Console.WriteLine(myList[1]);
        
        // Console.WriteLine(generateRandom.Next(0, 2));
        // Console.WriteLine(myList[generateRandom.Next(myList.Count)]);
        // foreach(string l in myList) {
        //     Console.WriteLine(l);
        // }

        // IMPORTANT!!!!
        // string myName = "James";
        // string myString = new string('_', myName.Length);
        // Console.WriteLine(myString);
    // }

//     static void Main(string[] args)
//     {
//         List<string> words = new List<string>
//         {
//             "apple", "banana", "cherry", "date", "elderberry", "fig", "grape", "honeydew", "kiwi", "lemon"
//         };

//         Random random = new Random();

//         while (true)
//         {
//             Console.Clear();
//             Console.WriteLine("Press Enter to hide a random word:");
//             Console.WriteLine();

//             foreach (string word in words)
//             {
//                 Console.Write(random.Next(2) == 0 ? HideWord(word) : word);
//                 Console.Write(" ");
//             }

//             Console.ReadLine();

//         }
//     }

//     static string HideWord(string word)
//     {
//         return new string('_', word.Length);
//     }

//     public class Word1
//     {
//         public string _word;
//         public bool _isHidden;
//     }

//     static void Main(string[] args) 
//     {
//         Word1 word1 = new Word1();
//         word1._word = "My name is James and I live in the Philippines.";
//         word1._isHidden = false;

//         List<Word1> wordList = new List<Word1>();
//         wordList.Add(word1);

//         List<string> strings = new List<string>();

//         string getSentence = wordList[0]._word;

//         foreach(string l in getSentence.Split(" ")) {
//             strings.Add(l);
//         }

//         List<string> randomWords = GenerateRandom(strings, 3);
        
//         Console.WriteLine("Random Words:");
//         foreach(string word in randomWords) {
//             Console.WriteLine(word);
//         }
//     }

//     static List<string> GenerateRandom(List<string> wordList, int count)
//     {
//         Random random = new Random();
//         List<string> selectedWords = new List<string>();

//         for(int i = 0; i < count; i++)
//         {
//             int index = random.Next(0, wordList.Count);
//             // randomWords.Add(wordList[index]);
//             string word = wordList[index];

//             // Replace the word with underscores
//             string underscoreWord = new string('_', word.Length);
//             selectedWords.Add(underscoreWord);
//         }

//         return selectedWords;
//     }

// }



//     static void Main()
//     {
//         List<string> wordList = new List<string>
//         {
//             "apple", "banana", "cherry", "dog", "elephant",
//             "frog", "grape", "hamburger", "igloo", "jazz"
//         };

//         int numberOfWordsToGenerate = 3; // Change this to the number of random words you want to replace.

//         List<string> randomWords = GenerateRandomWords(wordList, numberOfWordsToGenerate);

//         Console.WriteLine("Random Words:");
//         foreach (string word in randomWords)
//         {
//             Console.WriteLine(word);
//         }

//         ReplaceWordsWithUnderscores(wordList, randomWords);

//         Console.WriteLine("\nOriginal List with Replaced Words:");
//         foreach (string word in wordList)
//         {
//             Console.WriteLine(word);
//         }
//     }

//     static List<string> GenerateRandomWords(List<string> wordList, int count)
//     {
//         Random random = new Random();
//         List<string> randomWords = new List<string>();

//         for (int i = 0; i < count; i++)
//         {
//             int index = random.Next(0, wordList.Count);
//             randomWords.Add(wordList[index]);
//             wordList.RemoveAt(index); // Remove the word from the original list.
//         }

//         return randomWords;
//     }

//     static void ReplaceWordsWithUnderscores(List<string> wordList, List<string> randomWords)
//     {
//         foreach (string word in randomWords)
//         {
//             string underscoredWord = new string('_', word.Length);
//             wordList.Add(underscoredWord); // Put the underscored word back in the original list.
//         }
//     }

// }

// class Program
// {
//     static void Main()
//     {
//         Scripture scripture1 = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son...");
//         Scripture scripture2 = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him...");

//         var storage = new List<Scripture>();
//         storage.Add(scripture1);
//         storage.Add(scripture2);

//         Console.WriteLine("Welcome to the Scripture Memorizer program!");
//         Console.WriteLine("Press Enter to reveal scripture or type 'quit' to exit.");

//         while (true)
//         {
//             var randomScripture = storage.scriptures[new Random().Next(storage.scriptures.Count)];
//             randomScripture.Display();
//             ConsoleKeyInfo keyInfo = Console.ReadKey();
            
//             if (keyInfo.Key == ConsoleKey.Enter)
//             {
//                 randomScripture.HideRandomWord();
//                 if (randomScripture.AllWordsHidden())
//                 {
//                     Console.Clear();
//                     Console.WriteLine("Congratulations! You've hidden all the words in this scripture.");
//                     break;
//                 }
//             }
//             else if (keyInfo.Key == ConsoleKey.Q && keyInfo.Modifiers == ConsoleModifiers.Control)
//             {
//                 Console.Clear();
//                 Console.WriteLine("Exiting the program.");
//                 break;
//             }
//         }
//     }
// }

// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Scripture
// {
//     public string Reference { get; }
//     public string Text { get; }

//     private List<string> hiddenWords;

//     public Scripture(string reference, string text)
//     {
//         Reference = reference;
//         Text = text;
//         hiddenWords = new List<string>();
//     }

//     public bool AreAllWordsHidden()
//     {
//         return hiddenWords.Count == Text.Split(' ').Length;
//     }

//     public void HideRandomWord()
//     {
//         string[] words = Text.Split(' ');
//         Random random = new Random();
//         int randomIndex;
//         do
//         {
//             randomIndex = random.Next(0, words.Length);
//         } while (hiddenWords.Contains(words[randomIndex]));

//         hiddenWords.Add(words[randomIndex]);
//         words[randomIndex] = new string('_', words[randomIndex].Length);
//         Text = string.Join(" ", words);
//     }
// }

// class ScriptureMemorizer
// {
//     private List<Scripture> scriptures;
//     private int currentScriptureIndex;

//     public ScriptureMemorizer()
//     {
//         scriptures = new List<Scripture>();
//         currentScriptureIndex = 0;
//     }

//     public void AddScripture(Scripture scripture)
//     {
//         scriptures.Add(scripture);
//     }

//     public void MemorizeScriptures()
//     {
//         Console.Clear();
//         Console.WriteLine("Welcome to the Scripture Memorizer program!");
//         Console.WriteLine("Press Enter to reveal the scripture, or type 'quit' to exit.");

//         while (currentScriptureIndex < scriptures.Count)
//         {
//             var currentScripture = scriptures[currentScriptureIndex];

//             if (currentScripture.AreAllWordsHidden())
//             {
//                 Console.Clear();
//                 Console.WriteLine("You've memorized this scripture!");
//                 currentScriptureIndex++;
//                 continue;
//             }

//             currentScripture.HideRandomWord();
//             currentScripture.Display();
//             string input = Console.ReadLine();

//             if (input.ToLower() == "quit")
//             {
//                 Console.Clear();
//                 Console.WriteLine("Exiting the program.");
//                 break;
//             }
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         var memorizer = new ScriptureMemorizer();

//         // Add your scriptures here
//         memorizer.AddScripture(new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
//         memorizer.AddScripture(new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."));

//         memorizer.MemorizeScriptures();
//     }
// }

// using System;


// class Program
// {

//     static void Main(string[] args)
//     {
//         Reference scriptureReference = new Reference("Proverbs","3","5-6");
//         Scripture scripture = new Scripture(scriptureReference, "Trust in the lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
//         ScriptureMemorizer scriptureMemorizer = new ScriptureMemorizer(scripture);

//         string userInput = "";

//         while (userInput != "quit" && scriptureMemorizer.HasWordsLeft() == true)
//         {
//             Console.Clear();
//             Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemorizer.ToString()));
//             Console.WriteLine();
//             Console.ReadLine();
//             scriptureMemorizer.removeWordsFromText();
//         }
//     }
// }

// using System;
// using System.Collections.Generic;
// using System.Text.Json;
// using System.Text.Json.Serialization;


// class Program
// {
//     static void Main(string[] args)
//     {
//         string filename = GetFileName();
//         List<Scripture> scriptures = LoadScripturesFromFile(filename);

//         Random random = new Random();
//         int index = random.Next(scriptures.Count);
//         Scripture scripture = scriptures[index];

//         UserInterface.DisplayMainMenu();
//         int difficulty = UserInterface.GetMenuOption() * 2;
//         Thread.Sleep(100);

//         // Display the complete scripture and prompt the user to press "Enter" or type "quit".
//         Console.Clear();
//         Console.WriteLine(scripture.ToString());
//         string input = UserInterface.Prompt("Press Enter to begin, or type 'quit' to exit:");

//         // Hide words one by one until all words are hidden or the user types "quit".
//         while (!scripture.AllWordsHidden() && !input.Equals("quit"))
//         {
//             // Hide some random words and display the modified scripture.
//             scripture.HideRandomWords(difficulty);
//             Console.Clear();
//             Console.WriteLine(scripture.ToStringAllHidden());

//             if (scripture.AllWordsHidden())
//             {
//                 // Display the final scripture with all words hidden.
//                 Console.WriteLine("Press Enter to exit.");
//                 Console.ReadLine();
//             }
//             else
//             {
//                 // Prompt the user to press "Enter" or type "quit".
//                 input = UserInterface.Prompt("Press Enter to continue, or type 'quit' to exit:");
//             }
//         }
//     }

//     public static string GetFileName()
//     {
//         string fileName = "";
//         bool isValidFileName = false;

//         while (!isValidFileName)
//         {
//             Console.Write("Enter the path to the JSON file containing the scriptures: ");
//             fileName = Console.ReadLine();

//             // Check if the file name is valid
//             try
//             {
//                 new FileInfo(fileName);
//                 isValidFileName = true;
//             }
//             catch (ArgumentException)
//             {
//                 Console.WriteLine("Invalid file name. Please enter a valid file name.");
//             }
//             catch (PathTooLongException)
//             {
//                 Console.WriteLine("File path is too long. Please enter a shorter file name.");
//             }
//             catch (NotSupportedException)
//             {
//                 Console.WriteLine("Invalid file name. Please enter a valid file name.");
//             }
//         }

//         return fileName;
//     }

//     public static List<Scripture> LoadScripturesFromFile(string filename)
//     {
//         List<Scripture> scriptures = new List<Scripture>();
//         try
//         {
//             using (StreamReader reader = new StreamReader(filename))
//             {
//                 string json = reader.ReadToEnd();
//                 scriptures = JsonSerializer.Deserialize<List<Scripture>>(json);
//             }
//             Console.WriteLine($"Scriptures loaded from file: {filename}");
//         }
//         catch
//         {
//             Console.WriteLine($"Error loading scriptures from file: {filename}");
//         }
//         return scriptures;
//     }
// }

// class UserInterface
// {
//     public static void DisplayMainMenu()
//     {
//         int DELAY = 50;

//         Console.WriteLine("\nScripture Memorizer App");
//         Thread.Sleep(DELAY);
//         Console.WriteLine("=======================");
//         Thread.Sleep(DELAY);
//         Console.WriteLine("On a scale from 1 to 3, choose the level of difficulty for the game?");
//         Console.WriteLine("Where 1 is easy, and 3 is hard.");
//     }

//     public static int GetMenuOption()
//     {
//         while (true)
//         {
//             Console.Write("> ");
//             string input = Console.ReadLine();

//             // check if input is a valid number between 1 and 3
//             if (int.TryParse(input, out int number) && number >= 1 && number <= 3)
//             {
//                 return int.Parse(input);
//             }
//             else
//             {
//                 Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
//             }
//         }
//     }

//     public static string Prompt(string message)
//     {
//         Console.Write(message + " ");
//         return Console.ReadLine().Trim().ToLower();
//     }
// }

// class Person
// {
//     public string GetName() {
//         return "John";
//     }
// }

// class Student1: Person
// {
//     public int GetId() {
//         return 12345;
//     }
// }

// class Program
// {
//     static void Main(string[] args) {
//         Student1 student = new Student1();

//         Console.WriteLine(student.GetId());
//         Console.WriteLine(student.GetName());

//     }
// }

// a parent class called Person
// public class Person1
// {   protected string _name;
//     private string _lastName;
//     // Person constructor
//     public Person1(string name, string lastName)
//     {
//         _name = name;
//         _lastName = lastName;
//     }

//     public string GetName()
//     {
//         return _name;
//     }

//     public string GetLastName()
//     {
//         return _lastName;
//     }
// }

// // a child class called Student
// public class Stud : Person1
// {
//     private string _number;
    
//     // calling the parent constructor using "base"!
//     public Stud(string name, string lastName, string number) : base(name, lastName)
//     {
//         _number = number;
//     }

//     public string GetNumber()
//     {
//         return _number;
//     }

//     public string StudentInfo()
//     {
//         // ERROR! This line doesn't work, because _name is private in the base class
//         return _name + " " + _number;
//     }
// }

// class Program
// {
//     static void Main(string[] args) {
//         Stud student = new Stud("Brigham", "Young", "234");
//         string name = student.GetName();
//         string number = student.GetNumber();
//         string last = student.GetLastName();
//         string fullName = $"{name} {last} {number}";
//         Console.WriteLine(name);
//         Console.WriteLine(last);
//         Console.WriteLine(number);
//         Console.WriteLine(fullName);
//     }
// }

// Equivalent of Stud class
// public class Stud
// {
//     private string _name;
//     private string _lastName;
//     private string _number;

//     public Stud(string name, string lastName, string number)
//     {
//         _name = name;
//         _lastName = lastName;
//         _number = number;
//     }

//     public string GetName()
//     {
//         return _name;
//     }

//     public string GetLastName()
//     {
//         return _lastName;
//     }

//     public string GetNumber()
//     {
//         return _number;
//     }
// }

// BOOK
// public class Book
// {
//     protected string _author = "";
//     protected string _title = "";

//     public void SetAuthor(string author)
//     {
//         _author = author;
//     }

//     public void SetBookTitle(string title)
//     {
//         _title = title;
//     }

//     public string GetBookInfo()
//     {
//         return $"{_title} by {_author}";
//     }
// }

// public class PictureBook: Book
// {
//     private string _illustrator = "";
//     public void SetIllustrator(string illustrator)
//     {
//         _illustrator = illustrator;
//     }

//     public string GetPictureBookInfo()
//     {
//         return $"{_title} by {_author} illustrated by {_illustrator}.";
//     }
// }

// class Program
// {
//     static void Main(string[] args) {
//         Book book1 = new Book();
//         book1.SetAuthor("Smith");
//         book1.SetBookTitle("A great book");

//         Console.WriteLine(book1.GetBookInfo());

//         PictureBook book2 = new PictureBook();
//         book2.SetAuthor("Jones");
//         book2.SetBookTitle("A wonderful Picture Book");
//         book2.SetIllustrator("Burton");

//         Console.WriteLine(book2.GetBookInfo());
        
//         Console.WriteLine(book2.GetPictureBookInfo());
//     }
// }

// class Program
// {
//     static void Main(string[] args) {
        // Console.WriteLine("Going to sleep for a second...");

        // Thread.Sleep(5000);

        // Console.WriteLine("I'm back!!");
        
        // Console.Write(5);
        // Thread.Sleep(1000);
        // Console.Write("\b \b");
        // Console.Write(4);
        // Thread.Sleep(1000);
        // Console.Write("\b \b");
        // Console.Write(3);
        // Thread.Sleep(1000);
        // Console.Write("\b \b");
        // Console.Write(2);
        // Thread.Sleep(1000);
        // Console.Write("\b \b");
        // Console.Write(1);
        // Thread.Sleep(1000);
        // Console.Write("\b \b");
        // Console.Write("Done!");

        // for (int i = 5; i > 0; i--)
        // {
        //     Console.Write(i);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }

        // Console.Write("Done!");

        // List<string> animationStrings = new List<string>();
        // animationStrings.Add("|");
        // animationStrings.Add("/");
        // animationStrings.Add("-");
        // animationStrings.Add("\\");
        // animationStrings.Add("|");
        // animationStrings.Add("/");
        // animationStrings.Add("-");
        // animationStrings.Add("\\");

        // DateTime startTime = DateTime.Now;
        // DateTime endTime = startTime.AddSeconds(10);

        // Console.WriteLine(startTime);
        // Console.WriteLine(endTime);

    //     while (DateTime.Now < endTime) 
    //     {
    //         foreach(string s in animationStrings)
    //         {
    //             Console.Write(s);
    //             Thread.Sleep(200);
    //             Console.Write("\b \b");
    //         }
    //     }

        // Random r = new Random();

        // Console.WriteLine(r.Next(1, 10));
        // Console.WriteLine(r.Next(1, 10));      
// }

// class Program
// {
//     static void Main(string[] args)
//     {

//     }

// }

// public class Number
// {
//     private int _number = 0;

//     public void Accumulator()
//     {
//         _number = _number + 1;
//     }
// }

// POLYMORPHISM
// HourlyEmployee h = new HourlyEmployee();
// EmployeeTesting t = new EmployeeTesting();

// Console.WriteLine(h.CalculatePay());
// Console.WriteLine(t.CalculatePay());

// List<Employee> employees = new List<Employee>();
// employees.Add(new EmployeeTesting());
// employees.Add(new HourlyEmployee());

// foreach(Employee employee in employees)
// {
//     Console.WriteLine(employee.CalculatePay());
// }

// static string Choice()
// {
//     Console.WriteLine("The types of Goals are:");
//     Console.WriteLine("  1. Simple Goal");
//     Console.WriteLine("  2. Eternal Goal");
//     Console.WriteLine("  3. Checklist Goal");
//     Console.Write("Which type of Goal would you like to create? ");
//     string userChoice = Console.ReadLine();
//     return userChoice;
// }

// string choice = Choice();

// Console.WriteLine(choice);

// string m = myGoals[1];
// string[] parts = m.Split(',');

// parts[0] = "James";


// Console.WriteLine(myGoals[0]);

// foreach(string s in myGoals)
// {
//     string[] parts = s.Split(",");

//     string title = parts[0 + 1];

//      Console.WriteLine(title);
// }

// for(int i = 1; i < myGoals.Count; i++)
// {
//     // Console.WriteLine(myGoals[i]);
//     string[] parts = myGoals[i].Split(',');
//     string goalTitle = parts[0];
//     Console.WriteLine(goalTitle);
// }

// READING Txt FILE
// string fileName = "myFile.txt";
// string[] lines = System.IO.File.ReadAllLines(fileName);

// foreach(string line in lines)
// {
//     string[] parts = line.Split(',');
//     Console.WriteLine(parts[1]);
// }

// List<string> goalsList = new List<string>
// {
//     "simpleGoal:Scripture reading,Read my scripture before bed time,100,false",
//     "eternalGoal:Sleep early,sleep at 9pm every night,100",
//     "checklistGoal:Attend the temple,Attend and perform any ordinance,50,500,3,0",
//     "simpleGoal:Scripture reading,Read my scripture before bed time,1000,false"
// };

// foreach(string goal in goalsList)
// {
//     string[] parts = goal.Split(',');

//     string[] splittedParts = parts[0].Split(':');

//     string goalTitle = splittedParts[0];

//     Console.WriteLine(goal.IndexOf(goalTitle));
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         ModifyGoals modify = new ModifyGoals();

//         string answer = "0"; 
//         int displayPoints = 0; 

//         string armor = "nothing";
//         string weapon = "fists";

//         do {
//             Console.WriteLine("");
//             Console.WriteLine($"Your champion is wearing {armor} and weilding his {weapon}.");
//             Console.WriteLine($"You have {displayPoints} points.");
//             Console.WriteLine("");
//             Console.WriteLine("Menu Options:");
//             Console.WriteLine("   1. Create New Goal");
//             Console.WriteLine("   2. List Goals");
//             Console.WriteLine("   3. Save Goals");
//             Console.WriteLine("   4. Load Goals");
//             Console.WriteLine("   5. Record Event");
//             Console.WriteLine("   6. Shop");
//             Console.WriteLine("   7. Quit");
//             Console.Write("Select a choice from the menu: ");
//             answer = Console.ReadLine(); 

//             if (answer == "1")
//             {
//                 Console.WriteLine("The types of Goals are: ");
//                 Console.WriteLine("   1. Simple Goal");
//                 Console.WriteLine("   2. Eternal Goal");
//                 Console.WriteLine("   3. Checklist Goal");
//                 Console.Write("Which type of goal would you like to create? ");
//                 answer = Console.ReadLine();

//                 if (answer == "1")
//                 {
//                     SimpleGoal goal = new SimpleGoal(); 
//                     goal.GetDetails();
//                     modify.AddGoal(goal);
//                 } 
//                 else if (answer == "2")
//                 {
//                     EternalGoal goal = new EternalGoal(); 
//                     goal.GetDetails(); 
//                     modify.AddGoal(goal);
//                 }
//                 else if (answer == "3")
//                 {
//                     ChecklistGoal goal = new ChecklistGoal(); 
//                     goal.GetDetails(); 
//                     modify.AddGoal(goal); 
//                 }
//             } 
//             else if (answer == "2")
//             {
//                 Console.WriteLine("The goals are: ");
//                 modify.DisplayGoals();
//             }
//             else if (answer == "3")
//             {
//                 modify.Save();
//             }
//             else if (answer == "4")
//             {
//                 modify.Load(); 
//             }
//             else if (answer == "5")
//             {   
//                 int goalNumber = 1;
//                 Console.WriteLine("The goals are:");
//                 List<Goals> goals = modify.GetGoals(); 
//                 foreach (Goals goal in goals)
//                 {   
//                     string name = goal.GetName(); 
//                     Console.WriteLine($"{goalNumber}. {name}");
//                     goalNumber++;
//                 }
//                 Console.Write("Which goal did you accomplish? ");
//                 answer = Console.ReadLine();

//                 int intAnswer = int.Parse(answer);
//                 int points = 0;

//                 goalNumber = 1;
//                 foreach (Goals goal in goals)
//                 {
//                     if (goalNumber == intAnswer)
//                     {
//                         points = goal.DoGoal(true);
//                         modify.AddPoints(points);
//                     }
//                     goalNumber++;
//                 }
//                 displayPoints = modify.GetPoints();
//                 Console.WriteLine($"Congradulations! You have earned {points} points!");
//                 Console.WriteLine($"You now have {displayPoints} points.");

//             }else if (answer == "6")
//             {   
//                 Console.WriteLine("What would you like to buy? ");
//                 Console.WriteLine("   1. Wooden Sword (100)");
//                 Console.WriteLine("   2. Iron Sword (300)");
//                 Console.WriteLine("   3. Steel Sword (1200)");
//                 Console.WriteLine("   4. Lazer Sword (3500)");
//                 Console.WriteLine("   5. Wooden Armor (120)");
//                 Console.WriteLine("   6. Iron Armor (400)");
//                 Console.WriteLine("   7. Steel Armor (1500)");
//                 Console.WriteLine("   8. Chomatic Armor (4200)");
//                 Console.Write("> ");
//                 answer = Console.ReadLine();
//                 if (answer == "1")
//                 {
//                     if (displayPoints >= 100)
//                     {
//                         Console.WriteLine("Congradulations, you have bought a Wooden Sword!");
//                         modify.RemovePoints(100);
//                         weapon = "Wooden Sword";
//                     }
//                     else
//                     {
//                         Console.WriteLine("Sorry, you dont have enough points for that.");
//                     }
//                 }
//                 else if (answer == "2")
//                 {
//                     if (displayPoints >= 300)
//                     {
//                         Console.WriteLine("Congradulations, you have bought a Iron Sword!");
//                         modify.RemovePoints(300);
//                         weapon = "Wooden Iron";
//                     }
//                     else
//                     {
//                         Console.WriteLine("Sorry, you dont have enough points for that.");
//                     }
//                 }
//                 else if (answer == "3")
//                 {
//                     if (displayPoints >= 1200)
//                     {
//                         Console.WriteLine("Congradulations, you have bought a Steel Sword!");
//                         modify.RemovePoints(1200);
//                         weapon = "Steel Sword";
//                     }
//                     else
//                     {
//                         Console.WriteLine("Sorry, you dont have enough points for that.");
//                     }
//                 }
//                 else if (answer == "4")
//                 {
//                     if (displayPoints >= 3500)
//                     {
//                         Console.WriteLine("Congradulations, you have bought a Lazer Sword!");
//                         modify.RemovePoints(3500);
//                         weapon = "Lazer Sword";
//                     }
//                     else
//                     {
//                         Console.WriteLine("Sorry, you dont have enough points for that.");
//                     }
//                 }
//                 else if (answer == "5")
//                 {
//                     if (displayPoints >= 120)
//                     {
//                         Console.WriteLine("Congradulations, you have bought a Wooden Armor!");
//                         modify.RemovePoints(120);
//                         armor = "Wooden Armor";
//                     }
//                     else
//                     {
//                         Console.WriteLine("Sorry, you dont have enough points for that.");
//                     }
//                 }
//                 else if (answer == "6")
//                 {
//                     if (displayPoints >= 400)
//                     {
//                         Console.WriteLine("Congradulations, you have bought a Iron Armor!");
//                         modify.RemovePoints(400);
//                         armor = "Iron Armor";
//                     }
//                     else
//                     {
//                         Console.WriteLine("Sorry, you dont have enough points for that.");
//                     }
//                 }
//                 else if (answer == "7")
//                 {
//                     if (displayPoints >= 1500)
//                     {
//                         Console.WriteLine("Congradulations, you have bought a Steel Armor!");
//                         modify.RemovePoints(1500);
//                         armor = "Steel Armor";
//                     }
//                     else
//                     {
//                         Console.WriteLine("Sorry, you dont have enough points for that.");
//                     }
//                 }
//                 else if (answer == "8")
//                 {
//                     if (displayPoints >= 4200)
//                     {
//                         Console.WriteLine("Congradulations, you have bought a Chromatic Armor!");
//                         modify.RemovePoints(4200);
//                         armor = "Chromatic Armor";
//                     }
//                     else
//                     {
//                         Console.WriteLine("Sorry, you dont have enough points for that.");
//                     }
//                 } 
//                 else 
//                 {
//                     Console.WriteLine("That is not an item for sale");
//                 }

//             }
//             else if (answer == "7")
//             {
//                 Console.WriteLine("See you later, Allegator.");
//             }
//             else 
//             {
//                 Console.WriteLine("Invalid input");
//             }

//             displayPoints = modify.GetPoints();
//         } while (answer != "7");
//     }
// }

