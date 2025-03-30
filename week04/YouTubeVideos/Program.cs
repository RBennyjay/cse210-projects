using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Creating Video 1
        Video video1 = new Video("Object-oriented Programming (OOP) [Pt 18] | C# for Beginners", "David and Scott", 300);
        video1.AddComment(new Comment("Benny", "Great explanation!"));
        video1.AddComment(new Comment("Larry", "Really helpful, thanks."));
        video1.AddComment(new Comment("Tommie", "Can you cover interfaces next?"));

        videos.Add(video1);

        // Creating Video 2
        Video video2 = new Video("Object-Oriented Programming, Simplified", "Mosh Hamedani", 420);
        video2.AddComment(new Comment("Dannah", "Very clear examples."));
        video2.AddComment(new Comment("Eve", "I finally understand this topic!"));
        video2.AddComment(new Comment("Raph", "Awesome content!"));

        videos.Add(video2);

        // Creating Video 3
        Video video3 = new Video("Design Patterns in C#", "Mark Johnson", 600);
        video3.AddComment(new Comment("Grace", "This was super useful."));
        video3.AddComment(new Comment("Hank", "Great video!"));
        video3.AddComment(new Comment("Ebenezer", "This is a helpful video, thank you!"));

        videos.Add(video3);

        // Creating Video 4
        Video video4 = new Video("Understanding Abstraction in C#", "Ebenezer John", 300);
        video4.AddComment(new Comment("Abby", "Great explanation!"));
        video4.AddComment(new Comment("Evans", "This is informative."));
        video4.AddComment(new Comment("Stephanie", "Thanks for sharing that!"));

        videos.Add(video4);

        // Display all videos
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}