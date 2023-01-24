using System;

public class ScriptureMemorizer
{
    private Scripture scripture;
    private List<string> scriptureTextList;

    public ScriptureMemorizer(Scripture _scripture)
    {
        scripture = _scripture;
        scriptureTextList = new List<string>();
        convertTextToList();
    }

    private void convertTextToList()
    {
        scriptureTextList = scripture.toString().Split(' ').ToList();
    }

    public void removeWordsFromList()
    {
        int numWordsToRemove = new Random().Next(3, 3);
        int wordsRemoved = 0;

        do 
        {
            int rndindex = new Random().Next(0, scriptureTextList.Count());
            if (scriptureTextList[rndindex].Contains('_') == false)
            {
                scriptureTextList[rndindex] = new string('_', scriptureTextList[rndindex].Length);
                wordsRemoved++;
            }

        }while (wordsRemoved != numWordsToRemove);
    }

    public bool hasWordsLeft()
    {
        bool retvalue = false;

        foreach (string word in scriptureTextList)
        {
            if (word.Contains('_') == false)
            {
                retvalue = true;
                break;
            }
        }

        return retvalue;
    }

    public string toString()
    {
        return string.Join(' ', scriptureTextList);
    }
}   