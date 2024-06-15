using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade?");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        string letter = "";
        if (percent >= 97 && percent <= 100)
        {
            letter = "+A";
        }
        else if (percent >= 90 && percent <= 96)
        {
            letter = "-A";
        }
        else if (percent >= 87 && percent <= 89)
        {
            letter = "+B";
        }
        else if(percent >= 80 && percent <= 86)
        {
            letter = "-B";
        }
        else if(percent >= 77 && percent <= 79)
        {
            letter = "+C";
        }
        else if(percent >= 70 && percent <= 76)
        {
            letter = "-C";
        }
        else if(percent >= 67 && percent <= 69)
        {
            letter = "+D";
        }
        else if(percent >= 60 && percent <= 66)
        {
            letter = "-D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");
        if (percent >= 70)
        {
            Console.WriteLine("Great job, you paased!");
        }
        else
        {
            Console.WriteLine("Need to study more!");
        }

    }
}