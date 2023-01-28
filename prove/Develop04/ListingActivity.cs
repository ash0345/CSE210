using System;

public class ListingActivity : Activity
{
    private List<string> listingPrompts = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> answerList  = new List<string>();
    static Random rnd = new Random();

    public ListingActivity():base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }

    public void RunActivity()
    {
        AskForDuration();

        showListingMessage(duration);

        ShowEndMessage();
    }
    
    private void showListingMessage(int _duration)
    {
        Thread.Sleep(500);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        
        DateTime currentTime = DateTime.Now;

        // get a random prompt from the list and display it
        int index = rnd.Next(listingPrompts.Count);
        Console.WriteLine("\nList as many responses you can to the following prompt:\n --- "+listingPrompts[index]+" ---");

        Console.Write("\nYou may begin in: ");
        for(int i=5;i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        while(currentTime < futureTime)
        {
            Console.Write("\n>");
            string answer = Console.ReadLine();
            answerList.Add(answer);

            currentTime = DateTime.Now;
        }
        int answerCount = answerList.Count;
        Console.WriteLine($"You listed {answerCount} items");
    }
}