using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity helps you focus by practicing breathing exercises.")
    {
    }

    // Override Run method
    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Let's begin the breathing exercise.");

        // Start the breathing exercise loop
        int duration = GetDuration();  // Get the duration of the activity from the user
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        // Run the breathing exercise while the time is still within the duration
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Inhale deeply through your nose...");
            ShowCountDown(5);  // Countdown for inhale timing
            Console.WriteLine("Now exhale slowly...");
            ShowCountDown(5);  // Countdown for exhale timing
        }

        Console.WriteLine("Breathing exercise complete!");
        DisplayEndingMessage();
    }
}
