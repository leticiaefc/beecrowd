using System;

class URI
{

    static void Main(string[] args)
    {
        decimal A, B, C, p1, p2, p3, media;
        p1 = 2;
        p2 = 3;
        p3 = 5;
        A = decimal.Parse(Console.ReadLine());
        B = decimal.Parse(Console.ReadLine());
        C = decimal.Parse(Console.ReadLine());
        media = (A * p1 + B * p2 + C * p3) / (p1 + p2 + p3);
        Console.WriteLine($"MEDIA = {media:0.0}");
    }

}