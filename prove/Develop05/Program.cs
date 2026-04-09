using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    private static List<Goal> _goals = new List<Goal>();
    private static int _totalScore = 0;

    public static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_totalScore} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoals();
            else if (choice == "3") SaveGoals();
            else if (choice == "4") LoadGoals();
            else if (choice == "5") RecordEvent();
            else if (choice == "6") running = false;
            else Console.WriteLine("Please enter a valid option.");
        }
    }

    private static void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    private static void ListGoals()
    {
        Console.WriteLine("The goals are:");

        if (_goals.Count == 0)
        {
            Console.WriteLine("  (No goals created yet.)");
        }

        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"  {index}. {goal.GetStatus()}");
            Console.WriteLine();
            index++;
        }
    }

    private static void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_totalScore);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    private static void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();

        _totalScore = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "SimpleGoal")
            {
                bool complete = bool.Parse(parts[4]);
                _goals.Add(new SimpleGoal(name, description, points, complete));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (type == "ChecklistGoal")
            {
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int current = int.Parse(parts[6]);
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus, current));
            }
        }

        Console.WriteLine("Goals loaded.");
    }

    private static void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }

        Console.WriteLine("The goals are:");
        int index = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"  {index}. {goal.GetName()}");
            index++;
        }

        Console.Write("Which goal did you accomplish? ");
        string input = Console.ReadLine();

        int choice;
        if (int.TryParse(input, out choice))
        {
            int goalIndex = choice - 1;

            if (goalIndex >= 0 && goalIndex < _goals.Count)
            {
                _goals[goalIndex].RecordEvent(ref _totalScore);
                Console.WriteLine($"Your total score is now {_totalScore}.");
            }
            else
            {
                Console.WriteLine("Invalid goal number.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a number.");
        }
    }
}