using System;
using System.Globalization;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com seu nome completo: ");
            string name = Console.ReadLine();

            Console.Write("Quantos quartos tem em sua casa: ");
            int NumberOfRooms = int.Parse(Console.ReadLine());

            Console.Write("Entre com o preço de um produto: ");
            double ProductPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com seu último nome, idade, e altura (Mesma linha): ");
            string[] InfoVector = Console.ReadLine().Split(' ');
            string LastName = InfoVector[0];
            int age = int.Parse(InfoVector[1]);
            double weight = double.Parse(InfoVector[2], CultureInfo.InvariantCulture);

            Console.WriteLine("As informações inseridas foram: ");
            Console.WriteLine("Seu nome: " + name);
            Console.WriteLine("Número de quartos: " + NumberOfRooms);
            Console.WriteLine("Preço de um produto: " + ProductPrice.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Último nome, idade e altura (Mesma linha e com vetores): " + InfoVector[0] + ", " + InfoVector[1] + ", " + InfoVector[2]);
            Console.WriteLine("Último nome, idade e altura exibidas por variáveis:");
            Console.WriteLine(LastName);
            Console.WriteLine(age);
            Console.WriteLine(weight);
        }
    }
}
