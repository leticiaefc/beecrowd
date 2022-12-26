using System;

class URI
{

    static void Main(string[] args)
    {

        int recebido = int.Parse(Console.ReadLine());
        Console.WriteLine(recebido);


        int cem = recebido / 100;
        int sobracem = recebido % 100;
        int cinquenta = sobracem / 50;
        int sobracinq = sobracem % 50;
        int vinte = sobracinq / 20;
        int sobravinte = sobracinq % 20;
        int dez = sobravinte / 10;
        int sobradez = sobravinte % 10;
        int cinco = sobradez / 5;
        int sobracinco = sobradez % 5;
        int dois = sobracinco / 2;
        int sobradois = sobracinco % 2;
        int um = sobradois;

        Console.WriteLine($"{cem} nota(s) de R$ 100,00");
        Console.WriteLine($"{cinquenta} nota(s) de R$ 50,00");
        Console.WriteLine($"{vinte} nota(s) de R$ 20,00");
        Console.WriteLine($"{dez} nota(s) de R$ 10,00");
        Console.WriteLine($"{cinco} nota(s) de R$ 5,00");
        Console.WriteLine($"{dois} nota(s) de R$ 2,00");
        Console.WriteLine($"{um} nota(s) de R$ 1,00");

    }

}