using System;

class URI
{

    static void Main(string[] args)
    {

        string[] pxy1 = Console.ReadLine().Split(' ');
        string[] pxy2 = Console.ReadLine().Split(' ');
        double x1 = double.Parse(pxy1[0]);
        double y1 = double.Parse(pxy1[1]);
        double x2 = double.Parse(pxy2[0]);
        double y2 = double.Parse(pxy2[1]);
        double distance = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));

        double raiz = Math.Sqrt(distance);
        Console.WriteLine($"{raiz:F4}");

    }

}