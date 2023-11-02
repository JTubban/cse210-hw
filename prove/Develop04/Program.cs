using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");
        string choice = "";

        do{
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice) 
            {
                case "1":
                    // clear console
                    Console.Clear();
                    // Instantiate BreathingActivity
                    BreathingActivity breathing = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out. Clear your mind and focus on your breathing");
                    // display starting message
                    Console.WriteLine(breathing.GetStartingMessage());
                    Console.WriteLine();
                    // prompt the user for activity duration
                    Console.WriteLine(breathing.DurationMessage());

                    string breathingDuration = Console.ReadLine();
                    // clear console
                    Console.Clear();
                    // Breathing activity starts
                    breathing.BreathingExercise(breathingDuration);
                break;
                case "2":
                    // clear console
                    Console.Clear();
                    // Instantiate ReflectingActivity
                    ReflectingActivity reflecting = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    // display starting message
                    Console.WriteLine(reflecting.GetStartingMessage());
                    Console.WriteLine();
                    // prompt the user for activity duration
                    Console.WriteLine(reflecting.DurationMessage());

                    string reflectingDuration = Console.ReadLine();
                    // clear console
                    Console.Clear();
                    reflecting.ReflectingExercise(reflectingDuration);
                break;
                case "3":
                    // clear console
                    Console.Clear();
                    // Instantiate ListingActivity
                    ListingActivity listing = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    // display starting message
                    Console.WriteLine(listing.GetStartingMessage());
                    Console.WriteLine();
                    // prompt the user for activity duration
                    Console.WriteLine(listing.DurationMessage());
                    string listingDuration = Console.ReadLine();
                    // clear console
                    Console.Clear();
                    listing.ListingExercise(listingDuration);
                break;
            }
        }while(choice != "4");

    }
}