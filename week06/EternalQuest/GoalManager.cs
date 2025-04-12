using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1; // Initialize level

    public void CreateGoal()
    {
        Console.WriteLine("Available Goal Types:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your new goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a brief description of this goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
        }
    }

    //Showing Creativity and Exceeding Requirements:
    //Leveling Up:
    public void ListGoals()
    {
        Console.WriteLine("\n--- Your Current Goals ---");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }
        Console.WriteLine($"--- Your current score: {_score} points | Level: {_level} ---\n");
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save to: ");
        string file = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load from: ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(file);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            switch (parts[0])
            {
                case "SimpleGoal":
                    var simple = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    if (bool.Parse(parts[4])) simple.RecordEvent(); // Mark as complete
                    _goals.Add(simple);
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;

                case "ChecklistGoal":
                    var checklist = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                                                      int.Parse(parts[5]), int.Parse(parts[4]));
                    while (int.Parse(parts[6]) > 0) { checklist.RecordEvent(); parts[6] = (int.Parse(parts[6]) - 1).ToString(); }
                    _goals.Add(checklist);
                    break;
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int earned = _goals[index].RecordEvent();
            _score += earned;
            Console.WriteLine($"You earned {earned} points!");

            // Check if the user leveled up
            CheckLevelUp();
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    //Showing Creativity and Exceeding Requirements:
    //Leveling Up:
    //Introduce a leveling system where the user can "level up" after reaching certain milestone points.
    //Each level unlocks a new feature or bonus(such as bonus points for completing certain types of goals).
    //Track the current level based on total points and display the level in the menu.

    private void CheckLevelUp()
    {
        int newLevel = _score / 1000 + 1;  // Level up every 1000 points

        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine($"Congratulations! You've leveled up to Level {_level}!");
        }
    }

    public int GetScore() => _score;
    public int GetLevel() => _level;
}
