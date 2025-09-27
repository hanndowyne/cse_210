using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();


        Video video1 = new Video("Learn C#", "Alice", 300);
        video1.AddComment(new Comment("Bob", "This was super helpful!"));
        video1.AddComment(new Comment("Charlie", "Great explanation."));
        video1.AddComment(new Comment("Diana", "Thanks for sharing!"));
        videos.Add(video1);


        Video video2 = new Video("Intro to OOP", "Mike", 450);
        video2.AddComment(new Comment("Sarah", "I finally get encapsulation!"));
        video2.AddComment(new Comment("John", "This makes sense now."));
        video2.AddComment(new Comment("Emma", "Loved the examples."));
        videos.Add(video2);


        Video video3 = new Video("Abstraction Explained", "Sophia", 600);
        video3.AddComment(new Comment("Liam", "Nice breakdown."));
        video3.AddComment(new Comment("Noah", "Clear and concise."));
        video3.AddComment(new Comment("Olivia", "Perfect for beginners!"));
        videos.Add(video3);

        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.GetTitle()}");
            Console.WriteLine($"Author: {v.GetAuthor()}");
            Console.WriteLine($"Length: {v.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {v.GetComments().Count}");

            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine($" - {c.GetName()}: {c.GetText()}");
            }
            Console.WriteLine();

        }
        
        



    }
}