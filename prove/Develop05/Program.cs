using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        AllGoals allGoals = new AllGoals();
        int userMainMenuSelection = 0;

        while (userMainMenuSelection != 6)
        {
            Menu menu = new Menu();
            menu.DisplayPoints(allGoals.getTotalPoints());
            menu.DisplayMainMenu();
            userMainMenuSelection = menu.DisplayGetMainMenu();

            switch (userMainMenuSelection)
            {
                case 1:
                    int createNewGoalSelection = menu.DisplayGetCreateNewGoalMenu();
                    Goal goal = null;
                    switch (createNewGoalSelection)
                    {
                        case 1:
                            goal = new Simple();
                            //goal.DisplayGetGoalType();
                            goal.DisplayGetGoalName();
                            goal.DisplayGetGoalDescription();
                            goal.DisplayGetGoalPoints();
                            break;
                        case 2:
                            goal = new Eternal();
                            goal.DisplayGetGoalName();
                            goal.DisplayGetGoalDescription();
                            goal.DisplayGetGoalPoints();
                            break;
                        case 3:
                            goal = new Checklist();
                            goal.DisplayGetGoalName();
                            goal.DisplayGetGoalDescription();
                            goal.DisplayGetGoalPoints();
                            goal.DisplayGetAccomplishAmount();
                            goal.DisplayGetBonusPoints();
                            break;
                    }
                    if (goal != null)
                    {
                        allGoals.addGoal(goal);
                    }
                    break;
                case 2:
                    allGoals.DisplayGoals();
                    break;
                case 3:
                    allGoals.SaveGoals();
                    break;
                case 4:
                    allGoals.LoadGoals();
                    break;
                case 5:
                    allGoals.DisplayGoalsRecordEvent();
                    break;
            }
        }
    }
}

// I added a total completed count to my program