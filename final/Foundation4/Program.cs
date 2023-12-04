using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(30, 3.0);
        running.GetSummary();

        Console.WriteLine();

        Cycling cycling = new Cycling(45, 20.0);
        cycling.GetSummary();

        Console.WriteLine();

        Swimming swimming = new Swimming(60, 20);
        swimming.GetSummary();
    }
}