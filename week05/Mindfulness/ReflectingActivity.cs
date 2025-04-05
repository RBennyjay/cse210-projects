using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you stood up for someone else.",
        "Think of a time you did something really difficult.",
        "Think of a time you helped someone in need."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself?",
        "How did you feel afterwards?",
        "What did you learn from this experience?",
        "What would you do differently next time?"
    };

    private Queue<string> _shuffledQuestions;
    private Random _random = new Random();

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times when you have shown strength and resilience.")
    {
        ShuffleQuestions(); // Initialize shuffled queue
    }

    // Override the Run() method from Activity class
    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();

        Console.WriteLine("Now ponder each of the following questions as they relate to this experience:");
        ShowSpinner(3);

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            DisplayQuestion();
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    private void ShuffleQuestions()
    {
        List<string> shuffled = new List<string>(_questions);
        int n = shuffled.Count;
        for (int i = 0; i < n; i++)
        {
            int j = _random.Next(i, n);
            string temp = shuffled[i];
            shuffled[i] = shuffled[j];
            shuffled[j] = temp;
        }
        _shuffledQuestions = new Queue<string>(shuffled);
    }

    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
    }

    private void DisplayQuestion()
    {
        if (_shuffledQuestions.Count == 0)
        {
            ShuffleQuestions(); // Re-shuffle if exhausted
        }

        string question = _shuffledQuestions.Dequeue();
        Console.Write($"> {question} ");
    }

    private string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }
}
