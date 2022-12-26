using System;

class URI
{

    static void Main(string[] args)
    {

        int n1, n2, resposta = 1;
        int inter = 0, gremio = 0, empates = 0;
        int partidas = 0;

        do
        {
            string[] placar = Console.ReadLine().Split(' ');
            n1 = int.Parse(placar[0]);
            n2 = int.Parse(placar[1]);

            if (n1 > n2) { inter++; }
            else { gremio++; }
            if (n1 == n2) { empates++; }
            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            resposta = int.Parse(Console.ReadLine());
            partidas++;
        } while (resposta == 1);



        Console.WriteLine($"{partidas} grenais");
        Console.WriteLine($"Inter:{inter}");
        Console.WriteLine($"Gremio:{gremio}");
        Console.WriteLine($"Empates:{empates}");


        if (inter > gremio)
        {

            Console.WriteLine($"Inter venceu mais");
        }
        else
        {

            Console.WriteLine("Gremio venceu mais");
        }
    }

}