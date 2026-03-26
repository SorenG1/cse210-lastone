using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
        Console.Clear();
        Console.WriteLine("Hello user! Welcome to the Mindfulness Program.");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("     1. Breathing Activity");
        Console.WriteLine("     2. Reflection Activity");
        Console.WriteLine("     3. Listing Activity");
        Console.WriteLine("     4. Exit the Program");

        choice = Console.ReadLine();

        if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
            }
        else if (choice == "2")
            {
                ReflectingActivity a = new ReflectingActivity();
                a.Start();
                a.Run();
                a.End();
            }
        else if (choice == "3")
            {
                ListingActivity a = new ListingActivity();
                a.Start();
                a.Run();
                a.End();
            }

        }

    }
}