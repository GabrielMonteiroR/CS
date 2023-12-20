using System;

namespace matematica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor de x: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de y:");
            double y = double.Parse(Console.ReadLine());

            double raiz = Math.Sqrt(x);
            double elevado = Math.Pow(x, y);
            double valorAbsoluto = Math.Abs(x);

            Console.WriteLine("A raiz quadrada de " + x + " é igual a: " + raiz);
            Console.WriteLine("O resultado de " + x + " elevado a " + y +" é igual a: " + elevado);
            Console.WriteLine("O valor absoluto de x é: " + valorAbsoluto);
        }
    }
}
