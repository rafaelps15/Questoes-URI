﻿using System;

namespace uri1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int fatorial = 1;
            for (int i = 1; i <= N; i++)
            {
                fatorial = fatorial * i;
                
            }
            Console.WriteLine(fatorial);
        }
    }
}
