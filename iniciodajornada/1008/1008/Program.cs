using System;

class URI
{

    static void Main(string[] args)
    {

        int num = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        double s = double.Parse(Console.ReadLine());
        double salario = s * h;
        Console.WriteLine($"NUMBER = {num}");
        Console.WriteLine($"SALARY = U$ {salario:0.00}");

    }

}