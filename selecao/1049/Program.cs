using System;

class URI
{

    static void Main(string[] args)
    {

        string[] categoria = new string[3];
        categoria[0] = Console.ReadLine();
        categoria[1] = Console.ReadLine();
        categoria[2] = Console.ReadLine();

        if (categoria[0] == "vertebrado")
        {
            if (categoria[1] == "ave")
            {
                if (categoria[2] == "carnivoro")
                {
                    Console.WriteLine("aguia");
                }
                else
                {
                    Console.WriteLine("pomba");
                }
            }
            else //mamifero
            {
                if (categoria[2] == "onivoro")
                {
                    Console.WriteLine("homem");
                }
                else
                {
                    Console.WriteLine("vaca");
                }
            }
        }
        else //invertebrado
        {
            if (categoria[1] == "inseto")
            {
                if (categoria[2] == "hematofago")
                {
                    Console.WriteLine("pulga");
                }
                else
                {
                    Console.WriteLine("lagarta");
                }
            }
            else
            {
                if (categoria[2] == "hematofago")
                {
                    Console.WriteLine("sanguessuga");
                }
                else
                { Console.WriteLine("minhoca"); }
            }
        }

    }

}