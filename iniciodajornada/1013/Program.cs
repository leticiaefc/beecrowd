using System;

class URI
{

    static void Main(string[] args)
    {

        string[] numeros = Console.ReadLine().Split(' ');

        int primeiro = int.Parse(numeros[0]);
        int segundo = int.Parse(numeros[1]);
        int terceiro = int.Parse(numeros[2]);
        int maior12 = (primeiro + segundo + Math.Abs(primeiro - segundo)) / 2;
        int maiorDeTodos = (maior12 + terceiro + Math.Abs(maior12 - terceiro)) / 2;

        Console.WriteLine($"{maiorDeTodos} eh o maior");
    }

}