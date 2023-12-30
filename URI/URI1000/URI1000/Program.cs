using System;
using System.Globalization;

namespace uri1000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, hours;
            double value,salary;

            number = int.Parse(Console.ReadLine());
            hours = int.Parse(Console.ReadLine());
            value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            salary = hours * value;

            Console.WriteLine($"NUMBER = {number}");
            Console.WriteLine($"SALARY = U$ {salary:F2}");

    
        }
    }
}
