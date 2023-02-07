using System;

public class Checklist : Goal
{
    private const int goalType = 3;
    private bool goalComplete;
    private int completedChecklistCount = 0;

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
        if(completedChecklistCount == accomplishAmount)
        {
            return string.Format("[{0}] {1} ({2})\t ---- Completed goals : {3}/{4}\n", ((goalComplete == false) ? " " : "X"), getGoalName(), getGoalDescription(), completedChecklistCount, accomplishAmount);
        }
        else
        {
            return string.Format("[ ] {0} ({1})\t ---- Completed goals : {2}/{3}\n\n", getGoalName(), getGoalDescription(), completedChecklistCount, accomplishAmount);
        }
    }

    public override void RecordEvent()
    {
        completedChecklistCount++;
        if (completedChecklistCount == accomplishAmount)
        {
            int bonusTotal = bonusPoints + getGoalPoints();
            Console.WriteLine(string.Format("Congratulations! You have earned {0}", bonusTotal));
            goalComplete = true;
        } else {
            Console.WriteLine(string.Format("Congratulations! You have earned {0}", getGoalPoints()));
        }
    }
}