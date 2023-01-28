using System;

public class Activity
{
    protected string activityName;
    protected int duration;

    private string description;
     

    public Activity(string _actvityName,  string _description)
    {
        this.activityName = _actvityName;
        this.description = _description;    
    }
    public void AskForDuration()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the "+activityName+"\n\n"+description);
        Console.Write("\nHow long, in seconds, would you like your session?: ");
        string _duration = Console.ReadLine();
        duration = int.Parse(_duration);

        Console.Clear();
        Console.WriteLine("Get ready ...");
        ShowSpinnerAnimation();
    }
    public void ShowEndMessage()
    {
        Console.WriteLine("\n\nWell done!!");
        ShowSpinnerAnimation();
        Console.WriteLine("\nYou have completed another "+duration+" seconds of the "+activityName);
        ShowSpinnerAnimation();
    }

    public void ShowSpinnerAnimation()
    {
        for(int i=0; i<4;i++)
        {
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
        }  
    }
}