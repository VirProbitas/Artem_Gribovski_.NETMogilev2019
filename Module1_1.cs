using System;

class Program
{
    public static void Main()
    {
        int a;
        Console.Write("input a:");
        a = int.Parse(Console.ReadLine());

        int b;
        Console.Write("input b:");
        b = int.Parse(Console.ReadLine());

        int tmp;

        tmp = a;
        a = b;
        b = tmp;
        Console.WriteLine();

        Console.WriteLine("Output a=" +a);
        Console.WriteLine("Output b=" +b);
        Console.WriteLine();

    }
}