using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            // Ask user for number
            Console.Write("Enter number: ");
            string userGuess = Console.ReadLine();
            userNumber = int.Parse(userGuess);

            // add to list
            numbers.Add(userNumber); 
        }

        // Calculate sum
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"The sum is: {total}");

        // Calculate average
        int length = numbers.Count - 1;
        float average = total / length;
        Console.WriteLine($"The average is: {average}");

        // Find the largest number in the list
        int maxNumber = 0;
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}