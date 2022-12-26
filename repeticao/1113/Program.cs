using System;

class URI
{

    static void Main(string[] args)
    {

        int x = 0, y = 0;
        int aux, soma = 0;
        for (int i = 0; ; i++)
        {
            string[] input = Console.ReadLine().Split();
            x = int.Parse(input[0]);
            y = int.Parse(input[1]);

            if (x == y) { break; }
            if (x > y) { Console.WriteLine("Decrescente"); }
            else { Console.WriteLine("Crescente"); }
        }

    }

}