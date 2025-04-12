public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {Points} points.");
            return Points;
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
            return 0;
        }
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetails() =>
        $"[{(_isComplete ? "X" : " ")}] {Name} ({Description})";

    public override string GetStringRepresentation() =>
        $"SimpleGoal|{Name}|{Description}|{Points}|{_isComplete}";
}
