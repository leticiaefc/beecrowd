using System;

class URI
{

    static void Main(string[] args)
    {

        int agedays = int.Parse(Console.ReadLine());
        int anos = agedays / 365;
        int restoano = agedays % 365;
        int meses = restoano / 30;
        int restomeses = restoano % 30;
        int dias = restomeses;
        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");

    }

}