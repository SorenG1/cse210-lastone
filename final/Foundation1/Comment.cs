using System;

public class Comment
{
    private string _name;
    private string _text;

    //Constructor
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    //This part displays the comment
    public void Display()
    {
        Console.WriteLine($" - {_name}; {_text}");
    }
}
