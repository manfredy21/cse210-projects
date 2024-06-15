using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        string response = "yes";
        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);
            int guessedNumber = -1;
            while (number != guessedNumber)
            {
                Console.Write("What is your guess?");
                guessedNumber = int.Parse(Console.ReadLine());
                if (guessedNumber < number)
                {
                    Console.WriteLine("Higher");
                }
                else if(guessedNumber > number)
                {
                    Console.WriteLine("Lower");
                }else
                {
                    Console.WriteLine("You guessed it! ");
                }
                
            }
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }
    }
}