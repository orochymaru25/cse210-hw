using System;
using System.IO;


public class Journal
{
    // Variables
    public List<Entry> _journal = new List<Entry>(); // List to hold all the journal entries (Write, Load, and Save).
    public string _fileName = ""; // Variable to hold the filename in saving and loading a file.

    // Method to display the _journal
    public void DisplayJournal()
    {
        foreach (Entry journalEntry in _journal)
        {
            Console.WriteLine($"Date: {journalEntry._currentDate} - Prompt: {journalEntry._randomPrompt}");
            Console.WriteLine(journalEntry._journalEntry);
            Console.WriteLine();
        }
    }

    // Method to Save the _journal to a Text File.
    public void SaveToAFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName, true))
        {
            foreach (Entry saveToFile in _journal)
            {
                outputFile.WriteLine($"Date: {saveToFile._currentDate} - Prompt: {saveToFile._randomPrompt}");
                outputFile.WriteLine(saveToFile._journalEntry);
                outputFile.WriteLine();
            }
        }
    }

    // Method to Load a Text File and save to _journal list.
    public void SaveLoadedFile()
    {
        _journal.Clear(); // Clear the _journal list
  
        string[] lines = System.IO.File.ReadAllLines(_fileName); // Read all line in the text file

        // String variables to prepare the date and time before attempting to add list to _journal.
        string date = "";    
        string prompt = "";

        int stringCount = 0; // Code to know what string is being used.
        foreach (string line in lines) // To loop through each line of text in a text file.
        {
            // if else statement to help handling the split method correctly.
            if (stringCount == 0)
            {
                string[] parts = line.Split(" ", 5); // Splitting the string line to an array of strings.

                int indexCount = 0; // Code to help what index is being used.
                foreach (string indexFinder in parts) // Loop through an array of strings.
                {
                    // Using the if state to catch the data and prompt, then add the value later _journal.
                    if (indexCount == 1)
                    {
                        date = indexFinder; 
                    }
                    if (indexCount == 4)
                    {
                        prompt = indexFinder;
                    }
                    indexCount++;
                    
                }
            }
            if (stringCount == 1)
            {
                // code to add new list to _journal the values of date, prompt and entry is complete.
                _journal.Add(new Entry 
                {
                    _currentDate = date,
                    _randomPrompt = prompt,
                    _journalEntry = line
                });
            }
            if (stringCount == 0)
            {
                stringCount++;
            }
            else if (stringCount == 2)
            {
                stringCount = 0;
            }
            else
            {
                stringCount ++;
            }
        }

    }
}   
