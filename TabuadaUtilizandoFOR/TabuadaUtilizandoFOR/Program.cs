using System;

namespace uri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.Write("Insira o um número para ver sua tabuada: ");
            numero = double.Parse(Console.ReadLine());

            for(int i = 0; i < 12; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}