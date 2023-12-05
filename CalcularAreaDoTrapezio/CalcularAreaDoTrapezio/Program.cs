using System;
using System.Formats.Asn1;

class Program
{
    static void Main()
    {
        double a, b, B, h;

        b = 6.0;
        h = 5.0;
        B = 8.0;

        double area = ((b + B) / 2.0) * h; 

        Console.WriteLine("A area do trapézio é igual a: "+ area);
    }
}

