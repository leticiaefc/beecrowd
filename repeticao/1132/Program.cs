using System;

class URI
{

    static void Main(string[] args)
    {

        int n1, n2, aux, laco = 0, valor = 0;

        do
        {
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                aux = n1;
                n1 = n2;
                n2 = aux;
            }
            if (n1 == n2 && n1 % 13 != 0 && n2 % 13 != 0) ;
            {
                valor += n1;
                laco++;
            }
            for (int i = n1; i <= n2; i++)
            {
                if (i % 13 != 0)
                { valor += i; }
                laco++;

            }

        } while (laco <= 1);

        Console.WriteLine(valor - n1);

    }

}