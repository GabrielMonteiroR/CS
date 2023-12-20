using System;

namespace exercicioTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o primeiro nome: ");
            string nameOne = Console.ReadLine();

            Console.Write("Insira a idade do primeiro nome: ");
            int ageOne = int.Parse(Console.ReadLine());

            Console.Write("Insira o segundo nome: ");
            string nameTwo = Console.ReadLine();

            Console.Write("Insira a idade do segundo nome: ");
            int ageTwo = int.Parse(Console.ReadLine());

            double averageAge = (double)(ageOne + ageTwo) / 2.0;

            Console.WriteLine("A idade média entre " + nameOne + " e " + nameTwo + " é igual a: " + averageAge.ToString("F1"));

            Console.Write("Insira o terceiro nome e a idade (separados por espaço): ");
            string[] vetor = Console.ReadLine().Split(' ');
            string nameThree = vetor[0];
            int ageThree = int.Parse(vetor[1]);

            Console.Write("Insira o quarto nome e a idade (separados por espaço): ");
            vetor = Console.ReadLine().Split(' ');
            string nameFour = vetor[0];
            int ageFour = int.Parse(vetor[1]);

            Console.WriteLine("Nome 3: " + nameThree);
            Console.WriteLine("Idade 3: " + ageThree);
            Console.WriteLine("Nome 4: " + nameFour);
            Console.WriteLine("Idade 4: " + ageFour);
        }
    }
}
