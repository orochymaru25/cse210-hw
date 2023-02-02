using System;
using System.IO;


public class Journal
{
    // Variables
    public List<Entry> _journal = new List<Entry>();
    public string _fileName = "";

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
        _journal.Clear();
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        string date = "";
        string prompt = "";
        int stringCount = 0;
        foreach (string line in lines)
        {
            if (stringCount == 0)
            {
                string[] parts = line.Split(" ", 5);

                int indexCount = 0;
                foreach (string indexFinder in parts)
                {
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
