using System;

class URI
{

    static void Main(string[] args)
    {

        string[] prod1 = Console.ReadLine().Split(' ');
        string[] prod2 = Console.ReadLine().Split(' ');
        double totalP1 = int.Parse(prod1[1]) * double.Parse(prod1[2]);
        double totalP2 = int.Parse(prod2[1]) * double.Parse(prod2[2]);
        Console.WriteLine($"VALOR A PAGAR: R$ {totalP1 + totalP2:F2}");
    }

}