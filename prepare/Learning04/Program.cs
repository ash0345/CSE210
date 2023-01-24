using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment first = new Assignment("Ashley Anglesey", "Code");
        
        Console.WriteLine(first.GetSummary()); 
        Console.WriteLine();

        MathAssignment math = new MathAssignment("Ashley Anglesey", "Multiplication", "7.3", "1-20");

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment english = new WritingAssignment("Ashley Anglesey", "Literature", "Huck Fin");
        
        Console.WriteLine(english.GetSummary());
        Console.WriteLine(english.GetWritingInfo());
    }
}