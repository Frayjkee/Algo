using System;
using System.Security.Cryptography;

class Program

{
    static void Main()

    {

    Console.Write("Введте число а: ");
    int a = Convert.ToInt32(Console.ReadLine());

    if (a % 7 == 0 && a %  23 == 0)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("нет");
    }
    }
}