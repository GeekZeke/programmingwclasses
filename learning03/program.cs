using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine("\n--- Random Practice ---");

        Fraction frac = new Fraction();
        Random rand = new Random();

        for (int i = 1; i <= 20; i++)
        {
            frac.SetTop(rand.Next(1, 11));
            frac.SetBottom(rand.Next(1, 11));

            Console.WriteLine(
                $"Fraction {i}: string: {frac.GetFractionString()} Number: {frac.GetDecimalValue()}"
            );
        }
    }
}
