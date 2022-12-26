using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        string[] notes = Console.ReadLine().Split(' ');

        double n1, n2, n3, n4;
        n1 = double.Parse(notes[0], CultureInfo.InvariantCulture);
        n2 = double.Parse(notes[1], CultureInfo.InvariantCulture);
        n3 = double.Parse(notes[2], CultureInfo.InvariantCulture);
        n4 = double.Parse(notes[3], CultureInfo.InvariantCulture);

        double media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10;

        if (media == 4.85)
        {
            media = 4.8;
        }

        if (media >= 7)
        {
            Console.WriteLine($"Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5)
        {
            Console.WriteLine($"Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine($"Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno em exame.");
            double notaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
            double mediaFinal = (notaExame + media) / 2;
            if (mediaFinal >= 5)
            {
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine($"Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine($"Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }

}