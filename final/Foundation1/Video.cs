using System;

public class Video
{
    private string title;
    private string author;
    private int videoLength;
    public List<Comments> commentsList = new List<Comments>();

    public Video(string _title, string _author, int _videoLength)
    {
        title = _title;
        author = _author;
        videoLength = _videoLength;
    }
    public int countComments()
    {
        return commentsList.Count();
    }

    public string toString()
    {
        // display the title, author, length, number of comments (from the method)
        return string.Format("Title: {0}\nAuthor: {1}\nVideo Length: {2} minutes\nNumber of Comments: {3}\nComments:", title, author, videoLength, countComments());
    }
}