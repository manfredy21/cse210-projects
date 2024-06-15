using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name,square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program! ");
    }

    static string PromptUserName ()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        
        return name;
    }

    static int PromptUserNumber ()
    {
        Console.Write("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());

        return favNumber;
    }

    static int SquareNumber (int number)
    {
        int square = number * number;
        
        return square;
    }

    static void DisplayResult (string name, int square)
    {
        Console.WriteLine($"Hey! {name}, the square of your # is: {square}");
    }
}