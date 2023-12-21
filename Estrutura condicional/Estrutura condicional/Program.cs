using System;

namespace estruturacondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour;

            Console.Write("Insira as horas: ");
            hour = int.Parse(Console.ReadLine());

            /*Encadeamento de estruturas condicionais*/
            if (hour < 12) {
                Console.WriteLine("Bom dia!");
            }
            else if (hour < 18) {
            Console.WriteLine("Boa tarde!");
            }
            else
            {
                    Console.WriteLine("Boa noite!");
                }
            }
        }
    }
}
