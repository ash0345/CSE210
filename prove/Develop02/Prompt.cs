using System;

public class GeneratePrompt
{
    public List<string> _prompts = new List<string>() 
    {
        "How did I see the hand of the Lord in my life today?",
        "What was the best part of your day?",
        "If I had one thing I could do over today, what would it be?",
        "What are three things you are grateful for from today?",
        "What was the most exciting part of your day?"
    };

    public string Display(int i)
    {
       Console.WriteLine(_prompts[i]);

        return _prompts[i];
    }
}