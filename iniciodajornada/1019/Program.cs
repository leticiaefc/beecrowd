using System;

class URI
{

    static void Main(string[] args)
    {

        int numero = int.Parse(Console.ReadLine());
        int hora = numero / 3600;
        int resto = numero % 3600;
        int minuto = resto / 60;
        int restom = resto % 60;
        int segundo = restom;

        Console.WriteLine($"{hora}:{minuto}:{segundo}");

    }

}