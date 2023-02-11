using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");
        // Console.WriteLine();

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());   

        Console.WriteLine();

        Fraction2 fraction2 = new Fraction2();
        Console.WriteLine(fraction2.GetFractionString2());
        Console.WriteLine(fraction2.GetDecimalValue2());
        Fraction2 fraction21 = new Fraction2(5);
        Console.WriteLine(fraction21.GetFractionString2());
        Console.WriteLine(fraction21.GetDecimalValue2());
        Fraction2 fraction22 = new Fraction2(3, 4);
        Console.WriteLine(fraction22.GetFractionString2());
        Console.WriteLine(fraction22.GetDecimalValue2());
        Fraction2 fraction23 = new Fraction2(1, 3);
        Console.WriteLine(fraction23.GetFractionString2());
        Console.WriteLine(fraction23.GetDecimalValue2());

    }
}