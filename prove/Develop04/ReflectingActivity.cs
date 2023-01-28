using System;

public class ReflectingActivity : Activity
{
    private List<string> PromptList = new List<string>() {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> PonderingList = new List<string>() {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    static Random rnd = new Random();

    public ReflectingActivity():base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        
    }

    public void RunActivity()
    {
        AskForDuration();

        showReflectingMessage(duration);

        ShowEndMessage();
    }
    
    private void showReflectingMessage(int _duration)
    {
        Thread.Sleep(500);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        
        DateTime currentTime = DateTime.Now;

        Console.WriteLine("\nConsider the following prompt:\n");

        // get a random prompt from the list and display it
        int index = rnd.Next(PromptList.Count);
        Console.WriteLine(PromptList[index]);

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        if (Console.ReadKey().Key == ConsoleKey.Enter) 
        {
            Console.WriteLine("\nNow ponder on each of the following questions as they are related to this experience.");
            Console.Write("\nYou may begin in: ");
            for(int i=5;i>0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Clear();

            while(currentTime < futureTime)
            {
                // get random prompts for ponder until time runs out
                int rndindex = rnd.Next(PonderingList.Count);
                Console.Write(PonderingList[rndindex]);
                // needs to pause and spin for a few seconds
                Thread.Sleep(5000);
                ShowSpinnerAnimation();

                currentTime = DateTime.Now;
            }

        }
    }
}