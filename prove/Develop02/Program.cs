using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        Console.WriteLine("Welcome to the Journal Program!");        

        List<string> lsResponses = new List<string>();
        // while loop for writing and saving etc.
        while (userChoice != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                // entry class

                Journal entry = new Journal();

                lsResponses.Add(entry.Write());
            }
            else
            if(userChoice == 2)
            {
                Journal.Display(lsResponses);
            }
            else
            if(userChoice == 3)
            {
                Journal.Load(lsResponses);
            }
            else
            if(userChoice == 4)
            {
                Journal.Save(lsResponses);
            }
        }
    }
}

// put code into a txt file