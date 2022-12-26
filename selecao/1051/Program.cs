using System;

class URI
{

    static void Main(string[] args)
    {

        string dinheiro = Console.ReadLine();
        double grana = Convert.ToDouble(dinheiro);
        double imposto;
        double valor1, valor2, valor3;
        if (grana >= 0.00 && grana <= 2000.00)
        {
            Console.WriteLine($"Isento");
        }
        else if (grana > 2000.00 && grana <= 3000.00)
        {
            valor1 = grana - 2000;
            imposto = valor1 * 0.08;
            Console.WriteLine($"R$ {imposto:F2}");
        }
        else if (grana > 3000.00 && grana <= 4500.00)
        {
            valor1 = grana - 3000;
            valor2 = grana - (2000 + valor1);
            imposto = (valor2 * 0.08) + (valor1 * 0.18);
            Console.WriteLine($"R$ {imposto:F2}");
        }
        else if (grana > 4500.00)
        {
            valor1 = grana - 4500;
            valor2 = grana - (3000 + valor1);
            valor3 = grana - (valor1 + valor2 + 2000);
            imposto = (valor1 * 0.28) + (valor2 * 0.18) + (valor3 * 0.08);
            Console.WriteLine($"R$ {imposto:F2}");
        }

    }

}