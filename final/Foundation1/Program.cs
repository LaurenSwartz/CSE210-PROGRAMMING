using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to make Fatima Sydow's Koesisters", "Fatima Sydow", 840);
        video1.AddComment(new Comment("Viewer 1", "Thank you for sharing this recipe, I tried my Moms recipe last week and came out so delicious"));
        video1.AddComment(new Comment("Viewer 2", "Made my first batch today and it came out brilliant! Thanks Fatima "));
        video1.AddComment(new Comment("Viewer 3", "Keep it up!"));

        Video video2 = new Video("Chicken and Mashroom pie", "Fatima Sydow", 660);
        video2.AddComment(new Comment("Viewer 4", "I made this yesterday, came out perfect and delicious"));
        video2.AddComment(new Comment("Viewer 5", "Love your videos"));
        video2.AddComment(new Comment("Viewer 6", "You're such an amazing cook"));

        Video video3 = new Video("3 egg milk tart", "Fatima Sydow", 780);
        video3.AddComment(new Comment("Viewer 7", "Your cooking makes me feel at home"));
        video3.AddComment(new Comment("Viewer 8", "Just made it now, Aunty Fatima"));
        video3.AddComment(new Comment("Viewer 9", "This channel is so inspiring"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            System.Console.WriteLine($"Title: {video._title}");
            System.Console.WriteLine($"Author: {video._author}");
            System.Console.WriteLine($"Length: {video._length} seconds");
            System.Console.WriteLine($"Number of comments: {video.GetNumberofComments()}");

            System.Console.WriteLine("Comments: ");
            foreach (Comment comment in video.GetComments())
            {
                System.Console.WriteLine($"- {comment._name}: {comment._text}");
            }
            System.Console.WriteLine();
        }
    }
}