using System;

public class BreathingActivity : Activity
{
    public BreathingActivity():base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing")
    {
        
    }

    public void RunActivity()
    {
        AskForDuration();

        showActivityMessage(duration);

        ShowEndMessage();
    }

    private void showActivityMessage(int _duration)
    {
        Thread.Sleep(500);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            Console.Write("\n\nBreathe in... ");
            for(int i=4;i>0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.Write("\nNow breathe out... ");
            for(int i=6;i>0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            currentTime = DateTime.Now;
        }
    }
}