using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);

        char letterGrade;

        if (grade >= 90)
        {
            letterGrade = 'A';
        }
        else if (grade >= 80)
        {
            letterGrade = 'B';
        }
        else if (grade >= 70)
        {
            letterGrade = 'C';
        }
        else if (grade >= 60)
        {
            letterGrade = 'D';
        }
        else
        {
            letterGrade = 'F';
        }

        Console.WriteLine($"Your letter grade is {letterGrade}");

        if (letterGrade == 'A' || letterGrade == 'B' || letterGrade == 'C')
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}