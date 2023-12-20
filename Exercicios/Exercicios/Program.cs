using System;
using System.Globalization;

namespace exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, valorMetroQuadrado, area, ValorTotal;

            Console.Write(" Insira a largura do terreno em metros: ");
            largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write(" Insira o comprimento do terreno em metros:");
            comprimento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);  

            Console.Write(" Insira o valor de um m² em sua região: ");
            valorMetroQuadrado = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            area = largura * comprimento;
            ValorTotal = area * valorMetroQuadrado;

            Console.WriteLine("O tamanho do terreno é: " + area.ToString("F2") + "m².");
            Console.WriteLine("O valor do terreno é: " + ValorTotal.ToString("F2") + "R$.");
        }
    }
}
