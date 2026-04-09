using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    //Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;

    }
    //This part adds the comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    
    //This returns the number of comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    //This part displays the video information and the comments in it
    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");

        foreach(Comment c in _comments)
        {
            c.Display();
        }

        Console.WriteLine();

    }
}