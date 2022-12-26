using System;

class URI
{

    static void Main(string[] args)
    {


        int soma = 0;
        string[] v1 = Console.ReadLine().Split();
        int n1 = int.Parse(v1[0]);
        int n2 = int.Parse(v1[1]);
        while (n1 > 0 && n2 > 0)
        {
            if (n1 > n2)
            {
                for (int i = n2; i <= n1; i++)
                {
                    soma += i;
                    Console.Write($"{i} ");
                }
            }
            else if (n1 < n2)
            {
                for (int i = n1; i <= n2; i++)
                {
                    soma += i;
                    Console.Write($"{i} ");
                }
            }
            else
            {
                soma = n1;
                Console.WriteLine($"{n1} ");
            }
            Console.Write($"Sum={soma}");
            Console.WriteLine();
            v1 = Console.ReadLine().Split();
            n1 = int.Parse(v1[0]);
            n2 = int.Parse(v1[1]);
            soma = 0;

        }

    }

}