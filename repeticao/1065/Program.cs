using System;

class URI
{

    static void Main(string[] args)
    {

        int i;
        int p = 0;
        for (i = 0; i < 5; i++)
        {
            int valor = int.Parse(Console.ReadLine());
            if (valor % 2 == 0)
            {
                p++;
            }
        }
        Console.WriteLine($"{p} valores pares");

    }

}