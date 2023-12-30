using System;

namespace Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber, LastNumber;

            string[] vetor = Console.ReadLine().Split(' ');
            FirstNumber = int.Parse(vetor[0]);
            LastNumber = int.Parse(vetor[1]);

            while (FirstNumber != LastNumber)
            {
                if (FirstNumber < LastNumber)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }

                //REINICIA O LOOP
                vetor = Console.ReadLine().Split(' ');
                FirstNumber = int.Parse(vetor[0]);
                LastNumber = int.Parse(vetor[1]);
            }
        }
    }
}
