using System;

namespace formuladebhaskara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;

            Console.Write("Insert the value of a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Insert the value of b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Insert the value of c: ");
            c = double.Parse(Console.ReadLine());

     
            delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta > 0)
            {
                // Duas soluções reais distintas
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Two real distinct solutions: x1 = {x1}, x2 = {x2}");
            }
            else if (delta == 0)
            {
                // Uma solução real única (raiz dupla)
                x1 = -b / (2 * a);
                Console.WriteLine($"One real double solution: x1 = x2 = {x1}");
            }
            else
            {
                // Não há soluções reais; soluções complexas conjugadas
                Console.WriteLine("No one real solution.");
            }
        }
    }
}
