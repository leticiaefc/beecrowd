using System;

class URI
{

    static void Main(string[] args)
    {

        string[] numeros = Console.ReadLine().Split(' ');
        int n1 = int.Parse(numeros[0]);
        int n2 = int.Parse(numeros[1]);
        int n3 = int.Parse(numeros[2]);
        int aux;

        if (n1 > n2)
        {
            aux = n1;
            n1 = n2;
            n2 = aux;
        }
        if (n1 > n3)
        {
            aux = n1;
            n1 = n3;
            n3 = aux;
        }
        if (n2 > n3)
        {
            aux = n2;
            n2 = n3;
            n3 = aux;
        }

        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine();
        Console.WriteLine(numeros[0]);
        Console.WriteLine(numeros[1]);
        Console.WriteLine(numeros[2]);
    }

}