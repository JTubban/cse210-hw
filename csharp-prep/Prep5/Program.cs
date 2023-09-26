using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userFavNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userFavNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int useFavNumber = int.Parse(Console.ReadLine());
        return useFavNumber;
    }

    static int SquareNumber(int number)
    {
        int squarednumber = number * number;
        return squarednumber;
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"Brother {userName}, the square of your number is {squaredNumber}");
    }   
}