using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> entries;
    private List<string> prompts;
    private Random random;

    public Journal()
    {
        entries = new List<JournalEntry>();
        random = new Random();
        prompts = new List<string>
        {
            "What is something I accomplished today that I am proud of?",
            "How did I help someone today?",
            "What is one thing I am grateful for today?",
            "What is a goal I made progress on today?",
            "What is one thing I want to improve on tomorrow?",
            "What is a scripture, quote, or thought that inspired me today?",
            "How did I show kindness or compassion today?",
            "What is one thing I learned today?",
            "What made me smile or laugh today?"
        };
    }

    public void AddEntry()
    {
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");

        string response = GetUserInput("Your response: ");
        string mood = GetUserInput("How do you feel today? (e.g., Happy, Sad, Grateful): ");
        string tags = GetUserInput("Enter tags (comma-separated, e.g., Work, Family, Fitness): ");

        entries.Add(new JournalEntry(prompt, response, mood, tags));
        Console.WriteLine("Entry saved!\n");
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("\nNo journal entries found.\n");
            return;
        }

        Console.WriteLine("\nJournal Entries:");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter filename to save journal (e.g., journal.csv): ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("Date,Prompt,Response,Mood,Tags"); // CSV Header
                foreach (var entry in entries)
                {
                    writer.WriteLine(entry.ToCsv());
                }
            }
            Console.WriteLine("Journal saved successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}\n");
        }
    }

    public void LoadFromFile()
    {
        Console.Write("Enter filename to load journal (e.g., journal.csv): ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. Please check the filename and try again.\n");
            return;
        }

        try
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                reader.ReadLine(); // Skip header
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    JournalEntry entry = JournalEntry.FromCsv(line);
                    if (entry != null)
                    {
                        entries.Add(entry);
                    }
                }
            }
            Console.WriteLine("Journal loaded successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}\n");
        }
    }

    private string GetUserInput(string prompt)
    {
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine()?.Trim();
        } while (string.IsNullOrEmpty(input));

        return input;
    }
}
