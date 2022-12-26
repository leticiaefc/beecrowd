using System;

class URI
{

    static void Main(string[] args)
    {

        double p1, p2, A, B, media;
        p1 = 3.5;
        p2 = 7.5;
        A = double.Parse(Console.ReadLine());
        B = double.Parse(Console.ReadLine());
        media = (A * p1 + B * p2) / (p1 + p2);
        Console.WriteLine($"MEDIA = {media:0.00000}");

    }

}