﻿using System;
using System.Runtime.Serialization;

namespace exemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, x;
            int soma = 0;

            N = int.Parse(Console.ReadLine());

            for (int i= 1; i <= N; i++)
            {
                x = int.Parse(Console.ReadLine());
                soma += x;
            }
            Console.WriteLine(soma);
        }
    }
}