using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public void AddEntry()
    {
        // Set date/time object
        DateTime currentTime = DateTime.Now;
        string dateText = currentTime.ToShortDateString();
        // List of questions
        List<string> questions = new List<string>();
        questions.Add("What are the highlights of my day?");
        questions.Add("What challenges did I face today, and how did I handle them?");
        questions.Add("What am I grateful for today?");
        questions.Add("How did I feel emotionally today?");
        questions.Add("What did I learn today, big or small?");
        // Random generator
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(questions.Count);

        // newEntry Instance
        Entry newEntry = new Entry();
        newEntry._dateNow = dateText;
        newEntry._prompt = questions[randomNumber];
        // Prompt the user for a random question
        Console.WriteLine(newEntry._prompt);
        // Get the user response
        Console.Write("> ");
        string response = Console.ReadLine();
        newEntry._response = response;

        _entries.Add(newEntry);

        Console.WriteLine("New Entry has been added successfully!");
    }

    public void Display()
    {
        if (_entries.Count == 0) {
            Console.WriteLine("Empty list");
            Console.WriteLine();
        } else {
            foreach (Entry e in _entries) {
                Console.WriteLine($"Date: {e._dateNow} - Prompt: {e._prompt}\n{e._response}");
                Console.WriteLine();
            }
        }
    }

    public void LoadFile()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry newEntry = new Entry();
            newEntry._dateNow = date;
            newEntry._prompt = prompt;
            newEntry._response = response;

            _entries.Add(newEntry);
        }
        Console.WriteLine($"'{filename}' Loaded!");
    }

    public void SaveFile()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in _entries) {
                outputFile.WriteLine($"{e._dateNow}|{e._prompt}|{e._response}");
            }
        }

        Console.WriteLine("Journal saved!");
    }
}