using System;

public class Journal
{
    public string date = "";//string.Empty();

    GeneratePrompt prompts = new GeneratePrompt();
    
    public string Write(){
        Random rnd = new Random();
        int num = rnd.Next() % 5;

        string promptQuestion = prompts.Display(num);

        Console.Write("> ");
        string promptAnswer = Console.ReadLine();

        return  string.Format("{0:MM/dd/yyyy}", DateTime.Now) + " - " + promptQuestion + ":\n" + promptAnswer;
    }

    public static void Display(IList<string> lsResponses)
    {
        if(lsResponses.Count > 0)
        {
            Console.WriteLine("\nFollowing are the journal entries: ");
          foreach (string item in lsResponses)
            {
                Console.WriteLine("\n" + item);
            }
        }
    }

    public static void Save(IList<string> lsResponses)
    {
        Console.Write("Where would you like to save your journal?(please type file path) ");
        string fileSave = Console.ReadLine();

        using(StreamWriter writer = new StreamWriter(fileSave)) //"../../log.txt"
        {
            foreach (string item in lsResponses)
            {
                writer.WriteLine(item);
            }
        }
    }

    public static void Load(IList<string> lsResponses)
    {
        Console.Write("Enter file you would like to load your journal from(please type file path): ");
        string fileLoad = Console.ReadLine();

        using(StreamReader reader = new StreamReader(fileLoad))
        {
            foreach (string item in lsResponses)
            {
                Console.WriteLine("\n" + item);
            }
        }
    }
}