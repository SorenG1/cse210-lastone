using System;

public class Activity
{
    private string _activityName;
    private string _activityDescription;
    public int _duration;

    // Constructor contains only the strings for the name and description, the duration of the program will be asked for further down.
    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    public string GetActivityName()
    {
        return _activityName;
    }

    public string GetDescription()
    {
        return _activityDescription;
    }

    //This part of the code introduces you to the activity, asks for the duration of the activity.
    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine($"{_activityDescription}");
        Console.WriteLine();

        Console.WriteLine("How long would you like this activity to last? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Get ready, the activity is starting in:...");
        ShowSpinner(3);
        Console.WriteLine();
    }


    // This part of the code congratulates the user and gives you a summary.
    public void End()
    {
        Console.WriteLine();
        Console.WriteLine("Nice, good job. ");
        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"Excellent, you completed the {_activityName} in {_duration} seconds.");
    }

    public void ShowSpinner(int seconds)
    {
        List<string>animation = new List<string>() {"|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animation[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;
            if (i >= animation.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
  
    }

    public virtual void Run()
    {
    }


}