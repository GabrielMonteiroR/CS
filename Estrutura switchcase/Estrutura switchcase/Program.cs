using System;
using System.Diagnostics.Tracing;

namespace swithcase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual o dia da semana: ");
            int NumberInserted = int.Parse(Console.ReadLine());

            string day;

            switch (NumberInserted)
            {
                case 1:
                    day = "Domingo";
                    break;

                case 2:
                    day = "Segunda";
                    break;

                case 3:
                    day = "Terça-Feira";
                    break;

                case 4:
                    day = "Quarta-feira";
                    break;

                case 5:
                    day = "Quinta-feira";
                    break;

                case 6:
                    day = "Sexta-feira";
                    break;

                case 7:
                    day = "sábado";
                    break;

                default:
                    day = "Entrada invalida";
                    break;
            }
            Console.WriteLine(day);
        }


    }
}
