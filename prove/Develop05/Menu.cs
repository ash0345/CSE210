using System;

public class Menu
{
    private List<string> mainMenu, createGoalMenu;
    private int mainMenuSelection;

    public Menu()
    {
        mainMenu = new List<string>
        {
            "Menu Options:",
            "   1. Create new goal",
            "   2. List Goals",
            "   3. Save Goals",
            "   4. Load Goals",
            "   5. Record Event",
            "   6. Quit"
        };

        createGoalMenu = new List<string>
        {
            "The types of goals are:",
            "   1. Simple Goal",
            "   2. Eternal Goal",
            "   3. Checklist Goal"
        };
    }

    public void DisplayMainMenu()
    {
        foreach (string menuItem in mainMenu)
        {
            Console.WriteLine(menuItem);
        }
    }
    public void DisplayPoints(int _totalPoints)
    {
        Console.WriteLine(string.Format("You have {0} points.\n", _totalPoints));
    }
    public int DisplayGetMainMenu()
    {
        Console.Write("Select a choice from the menu: ");
        return int.Parse(Console.ReadLine());
    }
    public int GetMainMenuSelection()
    {
        return mainMenuSelection;
    }
    public int DisplayGetCreateNewGoalMenu()
    {
        foreach (string menuItem in createGoalMenu)
        {
            Console.WriteLine(menuItem);
        }

        Console.Write("What type of goal would you like to create? ");
        return int.Parse(Console.ReadLine());
    }
}