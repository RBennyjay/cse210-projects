public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        if (_currentCount == _targetCount)
        {
            Console.WriteLine($"Awesome! You've completed the checklist and earned {_bonusPoints} bonus points!");
            return Points + _bonusPoints;
        }

        Console.WriteLine($"Progress made! You've earned {Points} points.");
        return Points;
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override string GetDetails() =>
        $"[{(IsComplete() ? "X" : " ")}] {Name} ({Description}) -- Currently completed: {_currentCount}/{_targetCount}";

    public override string GetStringRepresentation() =>
        $"ChecklistGoal|{Name}|{Description}|{Points}|{_bonusPoints}|{_targetCount}|{_currentCount}";
}
