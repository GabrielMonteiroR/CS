using System;

namespace EntradaDeDados
{
    internal class program
    {
        static void Main(string[] args)
        {
            /* string frase = Console.ReadLine();
             string x = Console.ReadLine();
             string y = Console.ReadLine();
             string z = Console.ReadLine();
               */

            /*Exemplo de split*/
            

            string[] vetor = Console.ReadLine().Split(' ');
            string p1 = vetor[0];
            string p2 = vetor[1];
            string p3 = vetor[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    }
}
