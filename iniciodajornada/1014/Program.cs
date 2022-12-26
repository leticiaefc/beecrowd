using System;

class URI
{

    static void Main(string[] args)
    {

        int X = int.Parse(Console.ReadLine());
        float Y = float.Parse(Console.ReadLine());
        double quilometer = X / Y;

        Console.WriteLine($"{quilometer:F3} km/l");

    }

}