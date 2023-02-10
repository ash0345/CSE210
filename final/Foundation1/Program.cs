using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("YouTube Video Tracker:\n");

        // create 3-4 videos with 3-4 comments
        // add comments to a list
        Video video1 = new Video("How To Sew a Wedding Dress", "Mia Maples", 13);
        Comments comment1 = new Comments("UserOne", "Amazing dress!");
        Comments comment2 = new Comments("UserTwo", "Awesome Job!");
        Comments comment3 = new Comments("UserThree", "I want to learn that!");

        video1.commentsList.Add(comment1);
        video1.commentsList.Add(comment2);
        video1.commentsList.Add(comment3);

        Video video2 = new Video("How To Organize For School", "Happy Homeschooler", 30);
        Comments secondComment1 = new Comments("UserFour", "I need an iPad now!");
        Comments secondComment2 = new Comments("UserFive", "Wish this would help!");
        Comments secondComment3 = new Comments("UserSix", "I can't wait to try this!");

        video2.commentsList.Add(secondComment1);
        video2.commentsList.Add(secondComment2);
        video2.commentsList.Add(secondComment3);

        Video video3 = new Video("New Apartment Tour", "Brooklyn & Bailey", 24);
        Comments thirdComment1 = new Comments("UserSeven", "Wish this was my house!");
        Comments thirdComment2 = new Comments("UserEight", "Love the decorating!");
        Comments thirdComment3 = new Comments("UserNine", "Where'd you get that chair??!");
    
        video3.commentsList.Add(thirdComment1);
        video3.commentsList.Add(thirdComment2);
        video3.commentsList.Add(thirdComment3);
        
        // put each video in a list
        List<Video> videoList = new List<Video>();

        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);

        // iterate through the list of videos 
        foreach (Video video in videoList)
        {
            // display the title, author, length, number of comments (from the method)
            Console.WriteLine(video.toString());
            foreach (Comments comment in video.commentsList)
            {
                // list out all of the comments for that video.
                Console.WriteLine(comment.toString());
            }
            Console.WriteLine();
        }
    }
}