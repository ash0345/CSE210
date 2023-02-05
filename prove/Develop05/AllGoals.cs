using System;

public class AllGoals
{
    private List<Goal> allGoals = new List<Goal>();
    private int totalPoints;

    public int getTotalPoints()
    {
        return totalPoints;
    }
    public void addGoal(Goal _goal)
    {
        allGoals.Add(_goal);
    }
    public void DisplayGoals()
    {
        if (allGoals.Count() == 0)
        {
            Console.WriteLine("No goals have been created or loaded.");
        }
        foreach (Goal goal in allGoals)
        {
            Console.Write("\n"+goal.ToString());
        }

        int completedGoalCount = 0;

        if(allGoals.Count() > 0)
        {
            foreach(Goal goal in allGoals)
            {
                if(goal.getGoalType() == 1)
                {
                    if(((Simple)goal).getGoalComplete())
                    {
                        completedGoalCount++;
                    }
                }
                else
                if(goal.getGoalType() == 2)
                {
                    if(((Eternal)goal).getGoalComplete())
                    {
                        completedGoalCount++;
                    }
                }                
                else
                if(goal.getGoalType() == 3)
                {
                    if(((Checklist)goal).getGoalComplete())
                    {
                        completedGoalCount++;
                    }
                }
            }

            Console.WriteLine("\n\n ≈≈ You've completed goals ≈≈ "+completedGoalCount + "/"+ allGoals.Count+"\n");
        }
    }
    public void SaveGoals()
    {
        if (allGoals.Count() == 0)
        {
            Console.WriteLine("There are no goals to save.");
            return;
        }

        string fileToSave = DisplayGetGoalFile();

        List<string> saveGoals = new List<string>();
        saveGoals.Add(totalPoints.ToString());

        foreach (Goal goal in allGoals)
        {
            saveGoals.Add(goal.ToCSVRecord());
        }

        SaveLoadCSV.SaveToCSV(saveGoals, fileToSave);

        Console.WriteLine("Goals saved.");
    }
    public void LoadGoals()
    {
        List<string> fileGoals;
        fileGoals = SaveLoadCSV.LoadFromCSV(DisplayGetGoalFile());
        Goal goal = null;
        foreach (string goalInFile in fileGoals)
        {
            string[] goalParts = goalInFile.Split('|');
            int goalType = int.Parse(goalParts[0]);
            switch (goalType)
            {
                case 1:
                    goal = new Simple(goalParts[1], goalParts[2], int.Parse(goalParts[3]), bool.Parse(goalParts[4]));
                    break;
                case 2:
                    goal = new Eternal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), bool.Parse(goalParts[4]));
                    break;
                 case 3:
                    goal = new Checklist(goalParts[1], goalParts[2], int.Parse(goalParts[3]), bool.Parse(goalParts[4]));
                    break;
            }
            if (goal != null && allGoals.Contains(goal) == false)
            {
                allGoals.Add(goal);
            }
        }
        Console.WriteLine("\nGoals loaded.\n");
    }
    public string DisplayGetGoalFile()
    {
        Console.Write("What is the filename for the foal file? ");
        return Directory.GetCurrentDirectory() + "\\Files\\" + Console.ReadLine();
    }
    public void DisplayGoalsRecordEvent()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal goal in allGoals)
        {
            Console.WriteLine(string.Format("{0} {1}", allGoals.IndexOf(goal) + 1, goal.getGoalName()));
        }
        Console.Write("Which goal did you accomplish? ");
        int recordEvent = int.Parse(Console.ReadLine()) - 1;
        allGoals[recordEvent].RecordEvent();
        totalPoints += allGoals[recordEvent].getGoalPoints();

        Console.WriteLine(string.Format("You now have {0} points.", totalPoints.ToString()));
    }
}