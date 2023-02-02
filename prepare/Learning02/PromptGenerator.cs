using System;

public class PromptGenerator
{
    // Variables
    public List<string> _menu = new List<string>();
    public List<string> _randomQuestions = new List<string>();
    public string _question {get; set;}
    public int _toDo = -1;

    public void ToDo()
    {
        _toDo = int.Parse(Console.ReadLine());
    }

    // Method to display _menu.
    public void DisplayMenu()
    {
        int i = 1;
        foreach (string menu in _menu)
        {
            if (i != _menu.Count)
            {
                Console.WriteLine(menu);
                i++;
            }
            else
            {
                Console.Write(menu);
            }  
        }
        
    }
}