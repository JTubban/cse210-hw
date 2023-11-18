using System;
using System.Xml.Serialization;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        Organizer organizer = new Organizer();
        
        string choice = "";
        int displayPoints = 0;

        string armor = "nothing";
        string weapon = "fists";

        do{
            Console.WriteLine();
            Console.WriteLine($"Your champion is wearing {armor} and weilding his {weapon}.");
            Console.WriteLine($"You have {displayPoints} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Saved Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Shop");
            Console.WriteLine("  7. Quit");
            
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of Goal would you like to create? ");
                    choice = Console.ReadLine();

                    switch(choice)
                    {
                        case "1":
                            SimpleGoal simpleGoal = new SimpleGoal();
                            simpleGoal.GetDetails();
                            organizer.AddGoal(simpleGoal);
                        break;
                        case "2":
                            EternalGoal eternalGoal = new EternalGoal();
                            eternalGoal.GetDetails();
                            organizer.AddGoal(eternalGoal);
                        break;
                        case "3":
                            ChecklistGoal checklistGoal = new ChecklistGoal();
                            checklistGoal.GetDetails();
                            organizer.AddGoal(checklistGoal);
                        break;
                    }
                break;
                case "2":
                    Console.WriteLine("The goals are: ");
                    organizer.DisplayGoals();
                break;
                case "3":
                    organizer.Save();
                break;
                case "4":
                    organizer.Load();
                break;
                case "5":
                    int goalNumber = 1;
                    Console.WriteLine("The goals are:");
                    List<Goals> goals = organizer.GetGoals();
                    foreach (Goals goal in goals)
                    {
                        string name = goal.GetName();
                        Console.WriteLine($"{goalNumber}. {name}");
                        goalNumber++;
                    }
                    Console.Write("Which goal did you accomplish? ");
                    choice = Console.ReadLine();

                    int intAnswer = int.Parse(choice);
                    int points = 0;

                    goalNumber = 1;
                    foreach (Goals goal in goals)
                    {
                        if (goalNumber == intAnswer)
                        {
                            points = goal.DoGoal(true);
                            organizer.AddPoints(points);
                        }
                        goalNumber++;
                    }
                    displayPoints = organizer.GetPoints();
                    Console.WriteLine($"Congratulations! You have earned {points} points!");
                    Console.WriteLine($"You now have  {displayPoints} points.");
                break;
                case "6":
                    Console.WriteLine("What would you like to buy? ");
                Console.WriteLine("   1. Wooden Sword (100)");
                Console.WriteLine("   2. Iron Sword (300)");
                Console.WriteLine("   3. Steel Sword (1200)");
                Console.WriteLine("   4. Valiant Sword (3500)");
                Console.WriteLine("   5. Wooden Armor (120)");
                Console.WriteLine("   6. Iron Armor (400)");
                Console.WriteLine("   7. Steel Armor (1500)");
                Console.WriteLine("   8. Sanctified Armor (4200)");
                Console.Write("> ");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    if (displayPoints >= 100)
                    {
                        Console.WriteLine("Congradulations, you have bought a Wooden Sword!");
                        organizer.RemovePoints(100);
                        weapon = "Wooden Sword";
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you dont have enough points to buy the item. Please earn more points!");
                    }
                }
                else if (choice == "2")
                {
                    if (displayPoints >= 300)
                    {
                        Console.WriteLine("Congradulations, you have bought a Iron Sword!");
                        organizer.RemovePoints(300);
                        weapon = "Wooden Iron";
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you dont have enough points to buy the item. Please earn more points!");
                    }
                }
                else if (choice == "3")
                {
                    if (displayPoints >= 1200)
                    {
                        Console.WriteLine("Congradulations, you have bought a Steel Sword!");
                        organizer.RemovePoints(1200);
                        weapon = "Steel Sword";
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you dont have enough points to buy the item. Please earn more points!");
                    }
                }
                else if (choice == "4")
                {
                    if (displayPoints >= 3500)
                    {
                        Console.WriteLine("Congradulations, you have bought a Valiant Sword!");
                        organizer.RemovePoints(3500);
                        weapon = "Valiant Sword";
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you dont have enough points to buy the item. Please earn more points!");
                    }
                }
                else if (choice == "5")
                {
                    if (displayPoints >= 120)
                    {
                        Console.WriteLine("Congradulations, you have bought a Wooden Armor!");
                        organizer.RemovePoints(120);
                        armor = "Wooden Armor";
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you dont have enough points to buy the item. Please earn more points!");
                    }
                }
                else if (choice == "6")
                {
                    if (displayPoints >= 400)
                    {
                        Console.WriteLine("Congradulations, you have bought a Iron Armor!");
                        organizer.RemovePoints(400);
                        armor = "Iron Armor";
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you dont have enough points to buy the item. Please earn more points!");
                    }
                }
                else if (choice == "7")
                {
                    if (displayPoints >= 1500)
                    {
                        Console.WriteLine("Congradulations, you have bought a Steel Armor!");
                        organizer.RemovePoints(1500);
                        armor = "Steel Armor";
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you dont have enough points to buy the item. Please earn more points!");
                    }
                }
                else if (choice == "8")
                {
                    if (displayPoints >= 4200)
                    {
                        Console.WriteLine("Congradulations, you have bought a Sanctified Armor!");
                        organizer.RemovePoints(4200);
                        armor = "Sanctified Armor";
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you dont have enough points to buy the item. Please earn more points!");
                    }
                } 
                else 
                {
                    Console.WriteLine("That is not an item for sale");
                }
                break;
            }
            
        }while(choice != "7");
    }
}