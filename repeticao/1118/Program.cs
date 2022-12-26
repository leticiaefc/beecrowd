using System;

class URI
{

    static void Main(string[] args)
    {

        double nota1, nota2;
        int resposta = 1;

        do
            if (resposta == 1)
            {

                do
                {
                    nota1 = double.Parse(Console.ReadLine());

                    if (nota1 < 0.0f || nota1 > 10.0f)
                    {
                        Console.WriteLine("nota invalida");
                    }

                } while (nota1 < 0.0f || nota1 > 10.0f);

                do
                {
                    nota2 = double.Parse(Console.ReadLine());

                    if (nota2 < 0.0f || nota2 > 10.0f)
                    {
                        Console.WriteLine("nota invalida");
                    }

                } while (nota2 < 0.0f || nota2 > 10.0f);
                double media = (nota1 + nota2) / 2;
                Console.WriteLine($"media = {media:F2}");
                Console.WriteLine("novo calculo (1-sim 2-nao)");

                do
                {
                    resposta = int.Parse(Console.ReadLine());
                    if (resposta < 1 || resposta > 2)
                    { Console.WriteLine("novo calculo (1-sim 2-nao)"); }

                } while (resposta < 1 || resposta > 2);


            } while (resposta == 1);

    }

}