using System;

class URI
{

    static void Main(string[] args)
    {

        string name = Console.ReadLine();
        double sfix = double.Parse(Console.ReadLine());
        double sold = double.Parse(Console.ReadLine());
        double bonus = sold * 0.15;
        double salary = sfix + bonus;
        Console.WriteLine($"TOTAL = R$ {salary:0.00}");
    }

}