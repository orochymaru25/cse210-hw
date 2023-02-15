using System;

public class Scripture
{
    private string _scriptureVerses = "";

    public Scripture(string scriptureVerses)
    {
        _scriptureVerses = scriptureVerses;
    }

    public void DisplayScriptureVerse()
    {
        Console.WriteLine(_scriptureVerses);

        string[] parts = _scriptureVerses.Split(" ");
        // foreach (string index in parts)
        // {
        //     Console.WriteLine(index);
        // }
        Console.WriteLine(parts[4]);
    }
}