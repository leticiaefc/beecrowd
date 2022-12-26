using System;

class URI
{

    static void Main(string[] args)
    {

        string[] numeros = Console.ReadLine().Split(' ');
        int A = int.Parse(numeros[0]);
        int B = int.Parse(numeros[1]);

        int divisao;

        if (A < B)
        {
            divisao = B % A;
        }
        else
        {
            divisao = A % B;
        }
        if (divisao == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }

    }

}