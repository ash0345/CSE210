using System;

public class Simple : Goal
{
    private const int goalType = 1;
    private bool goalComplete;

    public Simple():base()
    {  
    }
    public Simple(string _goalName, string _description, int _points, bool _goalComplete) : base (goalType, _goalName, _description, _points)
    {
        goalComplete = _goalComplete;
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
        return string.Format("[{0}] {1} ({2})", ((goalComplete == false) ? " " : "X"), getGoalName(), getGoalDescription());
    }

    public override void RecordEvent()
    {
        Console.WriteLine(string.Format("Congratulations! You have earned {0}", getGoalPoints()));
        goalComplete = true;
    }
}