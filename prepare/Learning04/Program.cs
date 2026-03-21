using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Soren Gomez", "Weird things");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();


        MathAssignment m1 = new MathAssignment("Anna Ross", "Division", "15.5", "10-11");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment w1 = new WritingAssignment("Logan Cowley", "Multiplication", "THE MATH WORLD");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
        Console.WriteLine();

    }
}