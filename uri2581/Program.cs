﻿using System;

namespace uri2581
{
    /*Toorg é o integrante mais sábio do grupo de heróis denominado Os Protetores da Via Láctea. Para qualquer pergunta,
    ele tem a resposta ideal! Escreva um programa que, dada uma pergunta, informe a resposta de Toorg.
    Entrada:
    A entrada terá diversos casos de teste.A cada caso de teste, um número N é apresentado, que representa o número de casos de teste.
    Em seguida, haverá N linhas, com as perguntas feitas para Toorg.
    Saída:
    Para cada caso de teste, imprima a resposta de Toorg.*/
    
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string frase = Console.ReadLine();
                Console.WriteLine("I am Toorg!");
            }
        }
    }
}
