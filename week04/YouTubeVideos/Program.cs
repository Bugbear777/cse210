using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        var video1 = new Video { Title = "Intro to C#", Author = "Alice", LengthInSeconds = 300 };
        video1.AddComment(new Comment("John", "Great intro!"));
        video1.AddComment(new Comment("Emma", "Really helpful."));
        video1.AddComment(new Comment("Lucas", "Thanks for this."));
        videos.Add(video1);

        var video2 = new Video { Title = "OOP Basics", Author = "Bob", LengthInSeconds = 450 };
        video2.AddComment(new Comment("Sophia", "Clear explanation."));
        video2.AddComment(new Comment("Mike", "Can you cover interfaces next?"));
        video2.AddComment(new Comment("Liam", "Loved the examples."));
        videos.Add(video2);

        var video3 = new Video { Title = "LINQ in Depth", Author = "Charlie", LengthInSeconds = 600 };
        video3.AddComment(new Comment("Ella", "Very advanced topic!"));
        video3.AddComment(new Comment("Noah", "Struggled a bit, but useful."));
        video3.AddComment(new Comment("Grace", "Excellent content."));
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}