using System;

class URI
{

    static void Main(string[] args)
    {

        double value = double.Parse(Console.ReadLine());
        double[] notas = { 100, 50, 20, 10, 5, 2, 1 };
        double[] moedas = { 50, 25, 10, 5, 1 };

        double quantidadeNotas = 0;
        double quantidadeMoedas = 0;
        double restanteNotas = Math.Truncate(value);
        double cents = (value - Math.Truncate(value)) * 100;


        Console.WriteLine($"NOTAS:");
        for (int i = 0; i <= notas.Length - 1; i++)
        {

            if (i == notas.Length - 1)
            {
                Console.WriteLine($"MOEDAS:");
                quantidadeNotas = Math.Floor(restanteNotas / notas[i]);
                restanteNotas = restanteNotas - quantidadeNotas * notas[i];
                Console.WriteLine($"{quantidadeNotas} moeda(s) de R$ {notas[i]:F2}");

            }
            else
            {
                quantidadeNotas = Math.Floor(restanteNotas / notas[i]);
                restanteNotas = restanteNotas - quantidadeNotas * notas[i];
                Console.WriteLine($"{quantidadeNotas} nota(s) de R$ {notas[i]:F2}");
            }
        }

        for (int i = 0; i <= moedas.Length - 1; i++)
        {
            quantidadeMoedas = Math.Floor(cents / moedas[i]);
            cents = cents - quantidadeMoedas * moedas[i];
            Console.WriteLine($"{quantidadeMoedas} moeda(s) de R$ {moedas[i] / 100:F2}");

        }
    }
}