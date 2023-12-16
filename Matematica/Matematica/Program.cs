using System;

namespace matematica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultado = 14 % 3;
            double resultadoDois = 19 % 5;

            Console.WriteLine("O resto da divisão de 14 / 3 é: " + resultado);
            Console.WriteLine("O resto da divisão de 19 / 5 é: "+resultadoDois);           
        }
    }
}