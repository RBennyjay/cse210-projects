// Base.cs
using System;
using System.Collections.Generic;

public abstract class BaseGoalManager
{
    protected List<Goal> Goals { get; set; } = new List<Goal>();

    // Add a goal to the list
    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    // Show all goals
    public void ListGoals()
    {
        if (Goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        foreach (var goal in Goals)
        {
            Console.WriteLine($"{goal.Name}: {goal.Description} - {goal.Points} points");
        }
    }

    // Calculate total points for completed goals
    public int GetTotalPoints()
    {
        int totalPoints = 0;
        foreach (var goal in Goals)
        {
            if (goal.IsComplete())
                totalPoints += goal.Points;
        }
        return totalPoints;
    }

    // Save all goal data (this could be abstract or concrete depending on your needs)
    public virtual void SaveGoals()
    {
        // For demonstration, we could just print a message or implement actual save logic
        Console.WriteLine("Goals have been saved.");
    }

    // Abstract method that must be implemented for custom goal-related logic
    public abstract void RecordGoalCompletion(Goal goal);
}
