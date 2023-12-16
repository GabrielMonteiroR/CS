using System;
using System.Globalization;

namespace varaiveis
{
    internal class program
    {
        static void Main(string[] args)
        {
            double x = 10.345542;
            double y = 12.413212;
            double z = 34.132121;
            
            /*Como limitar caracteres em numeros*/
            
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            /*Como contatenar variaveis*/

            Console.WriteLine("O valor de x é: " + x + ", o valor de y é: " + y + " e o valor de z é: " + z);
        }
    }
}