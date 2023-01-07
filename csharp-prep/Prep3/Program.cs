using System;

class Program
{
    static void Main(string[] args)
    {
        // Start by asking the user for the magic number
        // Console.Write("What is the magic number? ");
        // string userOutput = Console.ReadLine();
        // int magicNumber = int.Parse(userOutput);

        // Generate Random number

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // Add a loop that keeps looping as long as the guess does not match the magic number
        while (guess != magicNumber)
        {
            // Ask user for guess
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            // Using an if statement, determine if the user needs to guess higher or lower next time, or tell them if they guessed it
            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");            
            }        
        }
    }
}