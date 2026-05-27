using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        string choice = "";

    while (choice != "6")
    {
        Console.Write("Welcome to the Journal Program.\nWould you like to:\n1. Write a new entry\n2. Display the journal\n3. Save the journal to a file\n4. Load the journal from a file\n5. Search entries by keyword\n6. Quit");
        choice = Console.ReadLine();
    
        if (choice == "1")
    {
        string randomPrompt = promptGen.GetRandomPrompt();
        Console.WriteLine($"\n{randomPrompt}");
        string response = Console.ReadLine();
        string dateText = DateTime.Now.ToShortDateString();
        Entry newEntry = new Entry(dateText, randomPrompt, response);
        myJournal.AddEntry(newEntry);
    }
    else if (choice == "2")
    {
        myJournal.DisplayAll();
    }
    else if (choice == "3")
        {
           Console.Write("Enter the filename to save to: ");
           string filename = Console.ReadLine();
           myJournal.SaveToFile(filename);
                
        }
    else if (choice == "4")
        {
            Console.Write("Enter the filename to load from: ");
            string filename = Console.ReadLine();
            myJournal.LoadFromFile(filename);
        }
    else if (choice == "5")
        {
            Console.Write("Enter a keyword to search for: ");
            string keyword = Console.ReadLine();
            myJournal.SearchEntries(keyword);                
        }
    }

    
}
}

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }
    public void Display()
    {
        Console.WriteLine($"\nDate: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("\nThe journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine("Journal saved.");
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry loadedEntry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(loadedEntry);
            }
        }
        Console.WriteLine("Journal loaded.");
    }

    public void SearchEntries(string keyword)
    {
        Console.WriteLine($"\nSearching for '{keyword}'...");
        bool found = false;
        foreach (Entry entry in _entries)
        {
            if (entry._entryText.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                entry._promptText.Contains(keyword,StringComparison.OrdinalIgnoreCase))
            {
                entry.Display();
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("No matching entries found.");
        }
    }
}

public class PromptGenerator
{
    public string[] _prompts =
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did you eat today?"
    };

    public string GetRandomPrompt()
    {
        return Random.Shared.GetItems(_prompts, 1)[0];
    }
}
