using System;

class URI
{

    static void Main(string[] args)
    {

        double valor = double.Parse(Console.ReadLine());


        double novoSalario = 0;
        double reajuste = 0;
        int percentual = 0;



        if (valor >= 0 && valor <= 400.00)
        {
            reajuste = valor * 0.15;
            novoSalario = valor * 1.15;
            percentual = 15;
        }
        else if (valor > 400.00 && valor <= 800.00)
        {
            reajuste = valor * 0.12;
            novoSalario = valor * 1.12;
            percentual = 12;
        }
        else if (valor > 800.00 && valor <= 1200.00)
        {
            reajuste = valor * 0.10;
            novoSalario = valor * 1.10;
            percentual = 10;
        }
        else if (valor > 1200 && valor <= 2000.00)
        {
            reajuste = valor * 0.07;
            novoSalario = valor * 1.07;
            percentual = 7;
        }
        else if (valor > 2000)
        {
            reajuste = valor * 0.04;
            novoSalario = valor * 1.04;
            percentual = 4;
        }
        Console.WriteLine($"Novo salario: {novoSalario:F2}");
        Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
        Console.WriteLine($"Em percentual: {percentual} %");

    }

}