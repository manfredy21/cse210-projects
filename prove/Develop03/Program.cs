using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Reference reference= new Reference("2 Nefi", 9, 28,29);
        Scripture scripture= new Scripture(reference, "28 ¡Oh ese sutil plan del maligno! ¡Oh las vanidades, y las flaquezas, y las necedades de los hombres! Cuando son instruidos se creen sabios, y no escuchan el consejo de Dios, porque lo menosprecian, suponiendo que saben por sí mismos; por tanto, su sabiduría es locura, y de nada les sirve; y perecerán. 29 Pero bueno es ser instruido, si hacen caso de los consejos de Dios.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(4); 

            if (scripture.IsCompleteHidden())
            {
                Console.Clear();
                break;
            }
        }
    }
}