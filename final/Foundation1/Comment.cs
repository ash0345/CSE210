using System;

public class Comments
{
    public string name;
    public string commentText;

    public Comments(string _name, string _commentText)
    {
        name = _name;
        commentText = _commentText;
    }

    public string toString()
    {
        return string.Format("\t• {0} - '{1}'", name, commentText);
    }
}