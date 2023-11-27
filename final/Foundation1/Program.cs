using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Taylor Swift - Love Story", "Taylor Swift", 237);
        Video video2 = new Video("Gwen Stefani - The Sweet Escape (Closed Captioned) ft. Akon", "Gwen Stefani", 247);
        Video video3 = new Video("Rick Astley - Never Gonna Give You Up (Official Music Video)", "Rick Astley", 213);

        Console.WriteLine();

        video1.AddComment(new Comment("@elizayunn", "I LOVE THIS SONG no matter how many years have pass, this song never gets old"));
        video1.AddComment(new Comment("@techkeal3494", "the fact that she wrote this masterpiece herself under 10 minutes  still amazes me"));
        video1.AddComment(new Comment("@R.u.d.i.e", "Still can't believe a song like this exists. Love you girl, U SLAYED THIS ONE."));
        video1.Display();

        video2.AddComment(new Comment("@DBONEZ", "Sometimes the boys need songs like this when we're alone"));
        video2.AddComment(new Comment("@aqua235", "This was my song in Middle School. I'm 30 now but it still hits the same."));
        video2.AddComment(new Comment("@LordOuro", "i miss the good old days, when i was a kid and nothing mattered and bangers like this were on the radio daily"));
        video2.Display();

        video3.AddComment(new Comment("@raga.8950", "We got rickrolled so many times that we don't even care anymore"));
        video3.AddComment(new Comment("@xMika_", "I’ve being rick rolled many times in my life that I don’t even trust links anymore."));
        video3.AddComment(new Comment("@comfyghost", "I looked up this video forgot that I did, clicked the tab and got rick rolled by my past self"));
        video3.Display();
    }
}