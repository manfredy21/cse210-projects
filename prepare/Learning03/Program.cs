using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction myFraction1 = new Fraction();
        Fraction myFraction2 = new Fraction(5);
        Fraction myFraction3 = new Fraction(3,4);
        Fraction myFraction4 = new Fraction(1,3);

        Console.WriteLine(myFraction1.GetFractionString());
        Console.WriteLine(myFraction1.GetDecimalValue());
        Console.WriteLine(myFraction2.GetFractionString());
        Console.WriteLine(myFraction2.GetDecimalValue());
        Console.WriteLine(myFraction3.GetFractionString());
        Console.WriteLine(myFraction3.GetDecimalValue());
        Console.WriteLine(myFraction4.GetFractionString());
        Console.WriteLine(myFraction4.GetDecimalValue());
        
    }
}