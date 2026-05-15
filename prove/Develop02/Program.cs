using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<string> journalEntries = new List<string>();

        string[] prompts = { "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did you eat today?" 
    };
        
    string choice = "";

    while (choice != "5")
    {
        Console.Write("Welcome to the Journal Program.\nWould you like to:\n1. Write a new entry\n2. Display the journal\n3. Save the journal to a file\n4. Load the journal from a file\n");
        choice = Console.ReadLine();
    
        if (choice == "1")
    {
        string randomPrompt = Random.Shared.GetItems(prompts, 1)[0];
        Console.WriteLine($"\n{randomPrompt}");
        string response = Console.ReadLine();
        DateTime currentDate = DateTime.Now;
        string date = currentDate.ToShortDateString();
        string entry = $@"{randomPrompt}
{response}
{date}";
        journalEntries.Add(entry);
    }
    else if (choice == "2")
    {
        Console.WriteLine("Here are your journal entries:");
        foreach (string entry in journalEntries)
        {
            Console.WriteLine(entry);        
        }        
    }
    else if (choice == "3")
        {
           Console.Write("Enter the filename to save to: ");
           string filename = Console.ReadLine();
           File.WriteAllLines(filename, journalEntries);
                
        }
    else if (choice == "4")
            {
                Console.Write("Enter the filename to load from: ");
                string filename = Console.ReadLine();
                if (File.Exists(filename))
                {
                    string[] lines = File.ReadAllLines(filename);
                    journalEntries = new List<string>(lines);
                }
                else
                {
                    Console.WriteLine("file not found");
                }
            }
    }

    
}
}
