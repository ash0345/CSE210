using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n««««««««««««««««««««««««««««««««««««\n");

        List<Activity> activitiesList = new List<Activity>();

        Running run = new Running(10, 40);
        activitiesList.Add(run);

        Cycling bike = new Cycling(9, 60);
        activitiesList.Add(bike);

        Swimming swim = new Swimming(30, 40);
        activitiesList.Add(swim);

        foreach (Activity activity in activitiesList)
        {
            activity.CalculateDistance();
            activity.CalculateSpeed();
            activity.CalculatePace();

            Console.WriteLine(activity.Summary());
            Console.WriteLine();
        }

        Console.WriteLine("««««««««««««««««««««««««««««««««««««\n");
    }
}