using System;

class URI
{

    static void Main(string[] args)
    {

        int i;
        int par = 0;
        int impar = 0;
        int pos = 0;
        int neg = 0;
        for (i = 0; i < 5; i++)
        {
            int valor = int.Parse(Console.ReadLine());
            if (valor % 2 == 0)
            {
                par++;
            }
            else
            {
                impar++;
            }
            if (valor > 0)
            {
                pos++;
            }
            else if (valor < 0)
            {
                neg++;
            }
        }
        Console.WriteLine($"{par} valor(es) par(es)");
        Console.WriteLine($"{impar} valor(es) impar(es)");
        Console.WriteLine($"{pos} valor(es) positivo(s)");
        Console.WriteLine($"{neg} valor(es) negativo(s)");

    }

}