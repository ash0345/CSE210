using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int userChoice = 0;
        int sessionsTotal = 0;
        while (userChoice != 4)
        {
            // menu options
            Console.WriteLine("Menu Options:\n   1. Start breathing activity\n   2. Start reflecting activity\n   3. Start listing activity\n   4. Quit");
            // user input option
            Console.Write("Select a choice from the menu: ");
            userChoice = int.Parse(Console.ReadLine());

            // if option __ then start activity __
            if (userChoice == 1)
            {
                BreathingActivity breathingActivityObj = new BreathingActivity();
                breathingActivityObj.RunActivity();

                sessionsTotal++;
            } else if (userChoice == 2)
            {
                ReflectingActivity reflectingActivityObj = new ReflectingActivity();
                reflectingActivityObj.RunActivity();

                sessionsTotal++;
            } else if (userChoice == 3)
            {
                ListingActivity listingActivityObj = new ListingActivity();
                listingActivityObj.RunActivity();

                sessionsTotal++;
            } 
            Console.Clear();
            Console.WriteLine($"You have gone through {sessionsTotal} sessions today!\n");

        }
    }
}

// Created a int containing session totals that adds one everytime they go through a session