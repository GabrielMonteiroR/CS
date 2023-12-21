using System;
using System.Globalization;


namespace exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double StudentFirstGrade,StudentSecondGrade,TotalGrade;

            Console.Write("What grade did the student get in the first semester: ");
            StudentFirstGrade = double.Parse(Console.ReadLine());

            Console.Write("What grade did the student get in the second semester: ");
            StudentSecondGrade = double.Parse(Console.ReadLine());

            TotalGrade = (StudentFirstGrade + StudentSecondGrade) / 2.0;

            if (TotalGrade >= 70)
            {
                Console.WriteLine(StudentFirstGrade + "+" + StudentSecondGrade + ": " + TotalGrade.ToString("F1",CultureInfo.InvariantCulture));
                Console.WriteLine("You're Approved!, Congrats!");
            }

            else if (TotalGrade >=40 && TotalGrade <= 69.9)

            {
                Console.WriteLine(StudentFirstGrade + StudentSecondGrade + ": " + TotalGrade.ToString("F1",CultureInfo.InvariantCulture));
                Console.WriteLine("You're in exam. ");
            }
            else {
                Console.WriteLine(StudentFirstGrade + StudentSecondGrade + ": " + TotalGrade.ToString("F1",CultureInfo.InvariantCulture));
                Console.WriteLine("You're Reproved.");

            }
        }

    }
}
