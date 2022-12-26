using System;

class URI
{

    static void Main(string[] args)
    {

        double R = double.Parse(Console.ReadLine());
        double volume = 4 / 3.0 * 3.14159 * R * R * R;
        Console.WriteLine($"VOLUME = {volume:F3}");

    }

}