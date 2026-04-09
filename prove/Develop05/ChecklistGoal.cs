using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, int currentCount = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = currentCount;
    }

    public override void RecordEvent(ref int totalScore)
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            totalScore += GetPoints();
            Console.WriteLine($"Progress made! You earned {GetPoints()} points!");

            if (_currentCount == _targetCount)
            {
                totalScore += _bonusPoints;
                Console.WriteLine($"Bonus! You completed this goal and earned {_bonusPoints} bonus points!");
            }
        }
        else
        {
            Console.WriteLine("This checklist goal is already complete.");
        }
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetStatus()
    {
        string check = IsComplete() ? "X" : " ";
        return $"[{check}] {GetName()} ({GetDescription()}) -- Completed {_currentCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_bonusPoints}|{_targetCount}|{_currentCount}";
    }
}