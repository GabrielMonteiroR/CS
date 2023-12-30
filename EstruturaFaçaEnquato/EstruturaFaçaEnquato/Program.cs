using System;
using System.Globalization;
using System Globalization;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            char repetir;


            Console.WriteLine("Digite a temperatura em Celsius: ");
            C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            F = 9.0 * C / 5.0 + 32.0;

            Console.WriteLine(F);
        
        }
    }
}