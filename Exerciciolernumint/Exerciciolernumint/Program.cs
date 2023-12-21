using System;

namespace numerosinteiros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber, SecondNumber,ThirdNumber,minor;

            Console.Write("Insert the first,second and third number: ");

            string[] vector = Console.ReadLine().Split(' ');
            FirstNumber = int.Parse(vector[0]);
            SecondNumber = int.Parse(vector[1]);
            ThirdNumber = int.Parse(vector[2]);

            minor = FirstNumber;

            if (minor >= SecondNumber)
            {
                minor = SecondNumber;
            }
            if (minor >= ThirdNumber)
            {
                minor = ThirdNumber;
            }

            Console.WriteLine($"The minor number is: {minor}");
        }

    }
}