using System;

namespace problemaexemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Totalvalue = 50.0;
            int minute;


            Console.Write("Quantos minutos foram utilizados: ");
            minute = int.Parse(Console.ReadLine());

            if(minute > 100 )
            { 
        
            Totalvalue += (((double)minute - 100) * 2.0);
            Console.Write($"valor a pagar: R${Totalvalue}");
            }
            else
            {
                Console.Write($"O Total deu R$ {Totalvalue}");
            }
        }
    }
}
