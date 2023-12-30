using System;

namespace exercise
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int idadeTotal = 0;
            int idade;
            int contador = 0;


            Console.WriteLine("Insira as idades: ");
            idade = int.Parse(Console.ReadLine());

            while (idade > 0)
            {
                idadeTotal += idade;
                idade = int.Parse(Console.ReadLine());
                contador++;
                
            }
            Console.WriteLine($"MÉDIA DAS IDADES: {idadeTotal / contador}");

        }
    }
}