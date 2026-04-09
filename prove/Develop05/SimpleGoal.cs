using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent(ref int totalScore)
    {
        if (!_isComplete)
        {
            _isComplete = true;
            totalScore += GetPoints();
            Console.WriteLine($"Congratulations! You earned {GetPoints()} points!");
        }
        else
        {
            Console.WriteLine("This goal is already complete.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStatus()
    {
        string check = _isComplete ? "X" : " ";
        return $"[{check}] {GetName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }
}