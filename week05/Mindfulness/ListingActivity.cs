using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private static readonly Random rand = new Random();  // Random instance moved to class level

    public ListingActivity() : base("Listing", "This activity helps you focus on the positive by listing things that matter to you.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "What are you grateful for?",
            "List as many things as you can that you are grateful for."
        };
    }

    // Now override the Run method
    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");

        Console.WriteLine("You may begin in:");
        ShowCountDown(5); // Short countdown before the user starts

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        List<string> responses = GetListFromUser(endTime);

        Console.WriteLine($"\nYou listed {responses.Count} items.");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser(DateTime endTime)
    {
        List<string> items = new List<string>();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Please enter a valid response.");
            }
            else
            {
                items.Add(input);
            }
        }
        return items;
    }
}
