using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        List<Video> videos = new List<Video>();

        // First video
        Video v1 = new Video("How to Cook Pasta", "Chef Mario", 556);
        v1.AddComment(new Comment("Alice", "wowsss this helped a lot, thank youuu"));
        v1.AddComment(new Comment("Pedrito", "Yummy, pasta is my favvv, please do another video"));
        v1.AddComment(new Comment("Soren", "This video was so entertaining :3"));
        videos.Add(v1);

        // Second video
        Video v2 = new Video("UNUSUAL MEMES V2", "UNUSUAL VIDEOS", 458);
        v2.AddComment(new Comment("funkypizza23", "bro thought he was the main character"));
        v2.AddComment(new Comment("barbrastreisand", "bro not the orange juice :0"));
        v2.AddComment(new Comment("elleonsantillan", "there's no way he didn't notice the soda flying."));
        videos.Add(v2);

        //Third video
        Video v3 = new Video("I BEAT MINECRAFT IN 54 SECONDS", "Dream", 1412);
        v3.AddComment(new Comment("pigletoffspring", "there's no way he did it this quick, mods?"));
        v3.AddComment(new Comment("endermanwarrior", "he should show us his command tab next time"));
        v3.AddComment(new Comment("notslimsh4dy", "no way, I ran into this guy in a server the other day."));
        videos.Add(v3);

        //This displays all the videos
        foreach (Video v in videos)
        {
            v.Display();
        }

    }
}