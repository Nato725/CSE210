using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("a youtube video", "jackson", 300);
        videos.Add(video1);
        video1.AddComment(new Comment("jimmy", "lol"));
        video1.AddComment(new Comment("james", "cool"));
        video1.AddComment(new Comment("jake", "nice"));

        Video video2 = new Video("a cooler youtube video", "matt", 300);
        videos.Add(video2);
        video2.AddComment(new Comment("mark", "haha"));
        video2.AddComment(new Comment("mitch", "epic"));
        video2.AddComment(new Comment("mabel", "sick"));

        Video video3 = new Video("coolest youtube video", "steve", 300);
        videos.Add(video3);
        video3.AddComment(new Comment("sam", "wow"));
        video3.AddComment(new Comment("shay", "awesome"));
        video3.AddComment(new Comment("scott", "dope"));

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
