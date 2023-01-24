using System;

public class Scripture
{
    private string scriptureText;
    private Reference scriptureReference;

    public Scripture(Reference _scriptureReference, string _striputureText)
    {
        scriptureReference = _scriptureReference;
        scriptureText = _striputureText;
    }

    public string toString()
    {
        return string.Format("{0}", scriptureText);
    }
}