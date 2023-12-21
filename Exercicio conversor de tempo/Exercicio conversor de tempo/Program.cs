using System;

namespace exerciciotempo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int segundo;
            double minuto, hora,resto;

            Console.Write("Insira os segundos de duração do evento da fábrica: ");
            segundo = int.Parse(Console.ReadLine());

            minuto = (double)segundo / 60;
            hora = minuto / 60;
            resto = (double)segundo % 60;
            
            Console.WriteLine((int)minuto + ":" + resto);
            Console.WriteLine("Horas: " + (int)hora + ":" + (int)minuto + ":" + resto);

        


        }
    }
}
