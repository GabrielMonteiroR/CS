using System;

namespace comofazercasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = 6.0;
            float c = 1.4f;
            int d = (int)b;

            double multiplicacao = ((double) c * b) * (double)a;

            Console.WriteLine(multiplicacao.ToString("F2"));   


        }
    }
}
