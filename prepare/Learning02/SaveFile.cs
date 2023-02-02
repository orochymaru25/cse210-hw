// using System;
// using System.IO;

// public class SaveFile
// {
//     public string _fileName = "";
//     // public string _outputDate = "";
//     // public string _outputPrompt = "";
//     // public string _outputEntry = "";

//     public void SaveToAFile()
//     {
//         using (StreamWriter outputFile = new StreamWriter(_fileName, true))
//         {
//             Journal journal = new Journal();
//             // foreach (Entry saveToFile in journal._journal)
//             // {
//             //     outputFile.WriteLine($"Date: {saveToFile._currentDate} - Prompt: {saveToFile._randomPrompt}");
//             //     // outputFile.WriteLine(saveToFile._journalEntry);
//             //     // outputFile.WriteLine();
                
//             // }
//             // outputFile.WriteLine($"Date: {_outputDate} - Prompt: {_outputPrompt}");
//             // outputFile.WriteLine(_outputEntry);
//             // outputFile.WriteLine();
//             // outputFile.Close();
//             outputFile.DisplayJournal();
//         }
        
//     }
    
// }