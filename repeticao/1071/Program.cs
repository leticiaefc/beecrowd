﻿using System;

class URI
{

    static void Main(string[] args)
    {

        int x;
        int y;
        int min;
        int max;
        int soma = 0;
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if (x < y)
        {
            min = x;
            max = y;
        }
        else
        {
            min = y;
            max = x;
        }

        for (int i = min + 1; i < max; i++)
        {
            if (i % 2 != 0)
            {
                soma = soma + i;
            }
        }
        Console.WriteLine(soma);

    }

}