using System;

namespace enquanto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;

            Console.Write("Insira números inteiros até o 0: ");
            number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                sum += number;
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);












        }
    }
}
