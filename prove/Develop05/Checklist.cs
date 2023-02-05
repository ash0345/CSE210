using System;

public class Checklist : Goal
{
    private const int goalType = 3;
    private bool goalComplete;

    public Checklist():base()
    {  
    }
    public Checklist(string _goalName, string _description, int _points, bool _goalComplete) : base (goalType, _goalName, _description, _points)
    {
        goalComplete = _goalComplete;
    }

    public int getAccomplishAmount()
    {
        return accomplishAmount;
    }
    public void setAccomplishAmount(int _accomplishAmount)
    {
        accomplishAmount = _accomplishAmount;
    }
    public int getBonusPoints()
    {
        return bonusPoints;
    }
    public void setBonusPoints(int _bonusPoints)
    {
        bonusPoints = _bonusPoints;
    }

    public bool getGoalComplete()
    {
        return goalComplete;
    }  
    public override string ToCSVRecord()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}", goalType, getGoalName(), getGoalDescription(), getGoalPoints(), goalComplete);
    }

    public override string ToString()
    {
        int completedChecklistCount = 0;

        if(completedChecklistCount == accomplishAmount)
        {
            return string.Format("[{0}] {1} ({2})\t ---- Completed goals : {3}/{4}\n", ((goalComplete == false) ? " " : "X"), getGoalName(), getGoalDescription(), completedChecklistCount, accomplishAmount);
        }
        else
        {
            Console.WriteLine($"[ ] {getGoalName()} ({getGoalDescription()}) ---- Completed goals : {completedChecklistCount - 1}/{accomplishAmount}\n");
            completedChecklistCount++;
            return;
        }
    }

    public override void RecordEvent()
    {
        Console.WriteLine(string.Format("Congratulations! You have earned {0}", getGoalPoints()));
        goalComplete = true;
    }
}