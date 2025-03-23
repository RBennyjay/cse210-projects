// Author: Ebenezer John
// W03 Project: Scripture Memorizer Program

// Program.cs
// Showing Creativity and Exceeding Requirements:

// Welcome Message – Greets the user when they start the app.

// Multiple Scriptures Library – Picks a random scripture from a list for memorization.

// Adaptive Hiding – The user chooses how many words to hide, and more words are hidden progressively as they practice.

// Hint System – Users can request a hint to reveal a word if they get stuck.

// Replay Option – The user has the option to replay the game.

// Quit Message – Displays a farewell message when the user exits the app.



using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
          // cSpell:disable
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("Alma", 37, 6), "By small and simple things are great things brought to pass."),
            new Scripture(new Reference("Ether", 12, 27), "If men come unto me I will show unto them their weakness."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("2 Nephi", 31, 20), "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men..."),
            new Scripture(new Reference("Ether", 12, 4), "Wherefore, whoso believeth in God might with surety hope for a better world, yea, even a place at the right hand of God..."),
            new Scripture(new Reference("Alma", 37, 6), "Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass..."),
            new Scripture(new Reference("Mosiah", 2, 41), "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things,...")
        };
        // cSpell:enable

        Random random = new Random();

        while (true)
        {
            Scripture scripture = scriptures[random.Next(scriptures.Count)];
            scripture.Reset();

            Console.Clear();
            Console.WriteLine("Welcome to the Scripture Memorizing App!");
            Console.WriteLine();
            Console.WriteLine($"Memorize this scripture: {scripture.GetReference()}");
            Console.WriteLine(scripture.GetVisibleText());

            int wordsToHide;
            while (true) // Input Validation loop
            {
                Console.Write("\nHow many words to hide at a time? ");
                if (int.TryParse(Console.ReadLine(), out wordsToHide) && wordsToHide > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            }

            while (!scripture.IsFullyHidden())
            {
                Console.Clear();
                Console.WriteLine($"Memorize this scripture: {scripture.GetReference()}");
                Console.WriteLine(scripture.GetVisibleText());

                Console.WriteLine("\nPress ENTER to hide more words, type 'hint' to reveal one word, or type 'quit' to exit.");
                string input = Console.ReadLine().ToLower();

                if (input == "hint")
                {
                    scripture.RevealOneWord();
                }
                else if (input == "quit")
                {
                    return;
                }
                else
                {
                    scripture.HideWords(wordsToHide);
                }
            }

            Console.Clear();
            Console.WriteLine($"Scripture fully hidden! ({scripture.GetReference()})");
            Console.WriteLine(scripture.GetVisibleText());

            string replay;
            while (true)
            {
                Console.WriteLine("\nDo you want to play again? (yes/no)");
                replay = Console.ReadLine().ToLower();
                if (replay == "yes" || replay == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
            }

            if (replay != "yes")
            {
                Console.WriteLine("Thank you for playing! Goodbye.");
                break;
            }
        }
    }
}

