using System;

class URI
{

    static void Main(string[] args)
    {

        int time = int.Parse(Console.ReadLine());
        int speed = int.Parse(Console.ReadLine());
        double liters = (time * speed) / 12.00;
        Console.WriteLine($"{liters:F3}");

    }

}