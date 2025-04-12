public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Great job! You've earned {Points} points for completing this eternal goal.");
        return Points;
    }

    public override bool IsComplete() => false;

    public override string GetDetails() =>
        $"[∞] {Name} ({Description})";

    public override string GetStringRepresentation() =>
        $"EternalGoal|{Name}|{Description}|{Points}";
}
