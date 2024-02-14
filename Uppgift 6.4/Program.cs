using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in ett tal");
        double x = int.Parse(Console.ReadLine());
        Console.WriteLine("Skriv in ett till tal");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine($"Talet {x} upphöjt med {y} = {Potens(x, y)}");

    }
    static double Potens(double x, int y)
    {
        double a = 1;
        for (int i = 0; i < y; i++)
        {
            a *= x;
        }
        return a;
    }
}
