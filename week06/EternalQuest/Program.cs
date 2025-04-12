using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        string input = "";

        while (input != "6")
        {   // Creativity and Exceeding Requirements:
            //Welcome Message and introduction to the game.

            Console.WriteLine("Welcome to Eternal Quest!\n");
            Console.WriteLine("Your adventure awaits...\n");
            Console.WriteLine("You are a brave adventurer on a quest to achieve your goals.");
            Console.WriteLine("As you complete your goals, you will earn points and level up.");
            Console.WriteLine("Your current level is 0. Complete goals to reach level 2 and beyond!\n");
            Console.WriteLine("You can create different types of goals: Simple, Eternal, and Checklist.");
            Console.WriteLine("Each goal has a point value, and some have bonuses for completing them multiple times.");
            Console.WriteLine("You can also save your progress and load it later.\n");
            Console.WriteLine("Your current score is 0 points. Complete goals to earn points and level up!");
            Console.WriteLine($"\n--- Eternal Quest ---\nYou currently have {manager.GetScore()} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. View Your Goals");
            Console.WriteLine("3. Save Your Progress");
            Console.WriteLine("4. Load Saved Progress");
            Console.WriteLine("5. Record Progress on a Goal");
            Console.WriteLine("6. Exit");
            Console.Write("Select an option from the menu: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1": manager.CreateGoal(); break;
                case "2": manager.ListGoals(); break;
                case "3": manager.SaveGoals(); break;
                case "4": manager.LoadGoals(); break;
                case "5": manager.RecordEvent(); break;
                case "6": Console.WriteLine("Thank you for playing Eternal Quest. Bye for Now!"); break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }
}