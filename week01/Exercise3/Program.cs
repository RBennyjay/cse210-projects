using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for the magic number
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // int guess = -1;

        // while (guess != magicNumber)
        // {
        //     // Ask the user for a guess
        //     Console.Write("What is your guess? ");
        //     guess = int.Parse(Console.ReadLine());

        //     // Provide feedback
        //     if (guess < magicNumber)
        //     {
        //         Console.WriteLine("Higher");
        //     }
        //     else if (guess > magicNumber)
        //     {
        //         Console.WriteLine("Lower");
        //     }
        //     else
        //     {
        //         Console.WriteLine("You guessed it!");
        //     }
        // }



        string playAgain = "yes"; 

        while (playAgain.ToLower() == "yes") 

        {
            
            Random random = new Random();

            int magicNumber = random.Next(1, 101);

            int guess = -1;
            int attempts = 0;

            Console.WriteLine("The magic number is between 1 and 100. Guess it!");

            while (guess != magicNumber)
            {
                // Ask the user for a guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                attempts++;

                // Provide feedback
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed it in {attempts} attempt!");
                }
            }
            // Ask if user wants to play again
            Console.Write("\nDo you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower(); 
        }

        Console.WriteLine("Thank you for playing! Bye for now!");
    }
}
