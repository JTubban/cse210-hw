using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string filename = GetFileName();
        List<Scripture> scriptures = LoadScripturesFromFile(filename);

        Random random = new Random();
        int index = random.Next(scriptures.Count);
        Scripture scripture = scriptures[index];

        UserInterface.DisplayMainMenu();
        int difficulty = UserInterface.GetMenuOption() * 2;
        Thread.Sleep(100);

        Console.Clear();
        Console.WriteLine(scripture.ToString());
        string input = UserInterface.Prompt("Press Enter to begin, or type 'quit' to exit:");

        while (!scripture.AllWordsHidden() && !input.Equals("quit"))
        {
            scripture.HideRandomWords(difficulty);
            Console.Clear();
            Console.WriteLine(scripture.ToStringAllHidden());

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
            }
            else
            {
                input = UserInterface.Prompt("Press Enter to continue, or type 'quit' to exit:");
            }
        }
    }

    public static string GetFileName()
    {
        string fileName = "";
        bool isValidFileName = false;

        while (!isValidFileName)
        {
            Console.Write("Enter the path to the JSON file containing the scriptures (HINT: type 'verses.json'): ");
            fileName = Console.ReadLine();

            try
            {
                new FileInfo(fileName);
                isValidFileName = true;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid file name. Please enter a valid file name.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("File path is too long. Please enter a shorter file name.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Invalid file name. Please enter a valid file name.");
            }
        }

        return fileName;
    }

    public static List<Scripture> LoadScripturesFromFile(string filename)
    {
        List<Scripture> scriptures = new List<Scripture>();
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string json = reader.ReadToEnd();
                scriptures = JsonSerializer.Deserialize<List<Scripture>>(json);
            }
            Console.WriteLine($"Scriptures loaded from file: {filename}");
        }
        catch
        {
            Console.WriteLine($"Error loading scriptures from file: {filename}");
        }
        return scriptures;
    }
}

class UserInterface
{
    public static void DisplayMainMenu()
    {
        int DELAY = 50;

        Console.WriteLine("\nWelcome to Scripture Memorizer App!");
        Thread.Sleep(DELAY);
        Console.WriteLine("----------------------------------------------------");
        Thread.Sleep(DELAY);
        Console.WriteLine("Choose the level of difficulty for the game:");
        Console.WriteLine("1 is Easy | 2 is Normal | 3 is hard");
    }

    public static int GetMenuOption()
    {
        while (true)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number >= 1 && number <= 3)
            {
                return int.Parse(input);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
            }
        }
    }

    public static string Prompt(string message)
    {
        Console.Write(message + " ");
        return Console.ReadLine().Trim().ToLower();
    }
}