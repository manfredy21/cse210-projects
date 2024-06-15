using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        do
        {
            Console.Write("Add a Number! ");
            number =int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);
        int sumLis = numbers.Sum();
        double aveLis = numbers.Average();
        int larNumber = numbers.Max();
         Console.WriteLine($"The sum is {sumLis}! ");
         Console.WriteLine($"The average is {aveLis}! ");
         Console.WriteLine($"The largest number is {larNumber}! ");
        numbers.Sort();
         foreach (int numb in numbers)
        {
            Console.WriteLine(numb);
        }
    }
    
}