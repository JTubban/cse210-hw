using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        Video video1 = new Video();
        video1._title = "Bohemian Rhapsody";
        video1._author = "Queen";
        video1._length = "355";
        video1._comment.AddComment("Gary McCane", "You did a fantastic job!");
        video1._comment.AddComment("Jackson Crow", "Your creativity is truly impressive.");
        video1._comment.AddComment("Emma Johnson", "I appreciate your hard work and dedication.");
        video1._comment.AddComment("Sophia Davis", "Your positive attitude brightens the room.");

        Video video2 = new Video();
        video2._title = "Blind Lights";
        video2._author = "The Weeknd";
        video2._length = "202";
        video2._comment.AddComment("Johnny Gun", "Great attention to detail!");
        video2._comment.AddComment("Mary Brown", "You're a valuable team member.");
        video2._comment.AddComment("Joseph Knight", "Thank you for your excellent contribution.");

        Video video3 = new Video();
        video3._title = "Shape of You";
        video3._author = "Ed Sheeran";
        video3._length = "294";
        video3._comment.AddComment("Noah Wilson", "Thank you for your excellent contribution.");
        video3._comment.AddComment("Lucas Thomas", "Your kindness is always appreciated.");
        video3._comment.AddComment("Harper Thompson", "Your enthusiasm is contagious.");
        video3._comment.AddComment("Oliver Harris", "I'm grateful for your positive impact.");

        Organizer organizer = new();
        organizer._videos.Add(video1);
        organizer._videos.Add(video2);
        organizer._videos.Add(video3);

        organizer.Display();
    }
}