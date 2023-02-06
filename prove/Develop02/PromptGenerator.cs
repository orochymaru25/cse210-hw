using System;

public class PromptGenerator
{
    // Variables
    public List<string> _menu = new List<string>(); // String List variable for the following choices.
    public List<string> _randomQuestions = new List<string>(); // String List variable for the random questions
    public string _question {get; set;} // String variable to hold the random prompt
    public int _toDo {get; set;} // Int variable to hold what actions the user want to do.

    public void ToDo()
    {
        _toDo = int.Parse(Console.ReadLine()); // Convert the user input to interger.
    }

    // Method to display _menu.
    public void DisplayMenu()
    {
        int i = 1; // Int variable to be used to help the loop.
        foreach (string menu in _menu) // Loop through each elements of the list
        {
            // if else statement to know what elements is being used and what actions need to done.
            if (i != _menu.Count)
            {
                Console.WriteLine(menu); // Printing only the 1 to 5 choices
                i++;
            }
            else
            {
                Console.Write(menu); // Printing the question what to do.
            }  
        }
        
    }
}