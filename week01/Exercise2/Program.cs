using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for user input
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";
        string sign = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        // Stretch Challenge
        // Determine the sign (+, -, or none)
        int lastDigit = percent % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Handle exceptions: No A+ and No F+ or F-
        if (letter == "A" && sign == "+")
        {
            sign = ""; // No A+
        }
        if (letter == "F")
        {
            sign = ""; // No F+ or F-
        }

        Console.WriteLine($"\nYour grade letter is: {letter}{sign}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! Great job!");
        }
        else
        {
            Console.WriteLine("Keep working hard! You’ll get it next time.");
        }

    }
}