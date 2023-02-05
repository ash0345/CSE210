using System;

public class Goal
{
    private int goalType=1;
    private string description;
    private string goalName;
    private int points;
    protected int accomplishAmount;
    protected int bonusPoints;

    public Goal()
    {

    }
    public Goal(int _goalType, string _description, string _goalName, int _points)
    {
        goalType = _goalType;
        description = _description;
        goalName = _goalName;
        points = _points;
    }

    public virtual string ToCSVRecord()
    {
        return string.Empty;
    }

    public virtual void RecordEvent()
    {

    }

    public string getGoalName()
    {
        return goalName;
    }
    public void setGoalName(string _goalName)
    {
        goalName = _goalName;
    }
    public string getGoalDescription()
    {
        return description;
    }
    public void setGoalDescription(string _description)
    {
        description = _description;
    }
    public int getGoalPoints()
    {
        return points;
    }
    public void setGoalPoints(int _points)
    {
        points = _points;
    }

    public int getGoalType()
    {
        return goalType;
    }
    
    public void DisplayGetGoalType()
    {
        Console.Write("What type of goal would you like to create? ");
        goalType = int.Parse(Console.ReadLine());
    }
    public void DisplayGetGoalName()
    {
        Console.Write("What is the name of your goal? ");
        goalName = Console.ReadLine();
    }
    public void DisplayGetGoalDescription()
    {
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
    }
    public void DisplayGetGoalPoints()
    {
        Console.Write("What is the amount of point associated with it? ");
        points = int.Parse(Console.ReadLine());
    }

    public void DisplayGetAccomplishAmount()
    {
        Console.Write("How many times does this goal need to be accomplished to get a bonus? ");
        accomplishAmount = int.Parse(Console.ReadLine());
    }
    public void DisplayGetBonusPoints()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        bonusPoints = int.Parse(Console.ReadLine());
    }
}