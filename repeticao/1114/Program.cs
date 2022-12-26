using System;

class URI
{

    static void Main(string[] args)
    {

        int num = 0;
        for (int i = 0; num != 2002; i++)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 2002)
            {
                Console.WriteLine("Acesso Permitido"); break;
            }

            else { Console.WriteLine("Senha Invalida"); }
        }

    }

}