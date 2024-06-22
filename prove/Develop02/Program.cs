using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        ///in this part Im adding prompts in the list in the function PromptGenerator///
        PromptGenerator AddingPrompt = new PromptGenerator();
        AddingPrompt._prompts.Add("What scripture did you red today?");
        AddingPrompt._prompts.Add("What knowledge did you gat today?");
        AddingPrompt._prompts.Add("What is the name of the person did you meet today?");
        AddingPrompt._prompts.Add("What is the better think did you do today?");
        AddingPrompt._prompts.Add("What is the new song´s name did you hear today?");
        AddingPrompt._prompts.Add("Did you pray today?");
        AddingPrompt._prompts.Add("What is the most dificult thing did you do today?");
        AddingPrompt._prompts.Add("Did you see TV today?");
        AddingPrompt._prompts.Add("What is you plan for tomorrow? ");
        AddingPrompt._prompts.Add("Did you talk with you famili today?");
        ///in this part I assign a ramdom prompt into a variable///
        string randomPrompt = AddingPrompt.GetRamdomPrompt();
        
        ///In this part I work in Entry class///
        Entry AddingEntry = new Entry
        {
            _date = DateTime.Now.ToShortDateString().ToString(),
            _promptText = randomPrompt
        };

        ///here I can use Journal or a can hace access ///
        Journal myJournal = new Journal();

        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choiceOption = Console.ReadLine();
            switch (choiceOption)
            {
                case "1":
                Console.WriteLine(AddingEntry._date);
                Console.WriteLine(AddingEntry._promptText);
                AddingEntry._entryText = Console.ReadLine();
                myJournal.AddEntry(AddingEntry);
                break;

                case "2":
                myJournal.DisplayAll();
                break;

                case "3":
                Console.WriteLine("Please enter the name of the file would you like to save");
                string fileName = Console.ReadLine();
                myJournal.SaveToFile(fileName);
                break;

                case "4":
                Console.WriteLine("Please enter the file # would you like to load");
                string loadFile = Console.ReadLine();
                myJournal.LoadFromFile(loadFile);
                break; 

                case "5":
                quit = true;
                break;

                default:
                Console.WriteLine("Pkease enter a valid option!");
                break;
            }
        }

    }
}