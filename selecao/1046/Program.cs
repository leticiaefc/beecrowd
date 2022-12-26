using System;

class URI
{

    static void Main(string[] args)
    {

        string[] tempo = Console.ReadLine().Split(' ');

        int inicio = int.Parse(tempo[0]);
        int fim = int.Parse(tempo[1]);

        if (fim <= inicio)
        {
            fim += 24;
        }

        Console.WriteLine($"O JOGO DUROU {fim - inicio} HORA(S)");

    }

}