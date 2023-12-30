using System;

namespace soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int soma = 0;


            Console.Write("Insira o primeiro número: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Insira o segundo número: ");
            y = int.Parse(Console.ReadLine());

            for(int i=x; i<y; i++)
            {
                if( (double)i % 2 != 0)
                {
                    Console.WriteLine(i);
                    soma += i;
                }
            }
            Console.WriteLine($"A soma dos números impares entre {x} e {y} é: {soma}");
        }
    }
}
