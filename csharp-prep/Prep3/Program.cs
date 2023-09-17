using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int count = 0;
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine($"What is the magic number? {magicNumber}");
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            string message;

            count++;

            if (magicNumber < guess)
            {
                message = "Lower";
            }
            else if (magicNumber > guess)
            {
                message = "Higher";
            }
            else
            {
                message = $"You guessed it!\nIt takes you {count} guesses. Congratulations!";
            }
            Console.WriteLine(message);
        }
    }
}