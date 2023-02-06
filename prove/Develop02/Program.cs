using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Welcome to the Journal Program!");
            
            // Object name on each class.
            PromptGenerator prompt = new PromptGenerator();
            Entry entry = new Entry();
            Journal journal = new Journal();

            // Code to get current date.
            DateTime theCurrentTime = DateTime.Now;


            // Adding property values in PromptGenerator class
            prompt._menu.Add("Please select one of the following choices");
            prompt._menu.Add("1. Write");
            prompt._menu.Add("2. Display");
            prompt._menu.Add("3. Load");
            prompt._menu.Add("4. Save");
            prompt._menu.Add("5. Quit");
            prompt._menu.Add("What would you like to do? ");  
            prompt._randomQuestions.Add("What was the most peaceful moment during the day?");
            prompt._randomQuestions.Add("Write a letter from someone else to you. What do you need to hear from them?");
            prompt._randomQuestions.Add("Craft a breakup letter to a bad habit.");
            prompt._randomQuestions.Add("Put yourself 20 years in the future. Write a letter to your future self with questions and predictions.");
            prompt._randomQuestions.Add("How did I see the hand of the Lord in my life today?");
            prompt._randomQuestions.Add("What would you do with a million dollars if you had to spend it in one hour?");
            prompt._randomQuestions.Add("What would you do if you were stranded on a desert island with someone you dislike?");
            prompt._randomQuestions.Add("If you could take any college course you wanted, what would you take?");
            prompt._randomQuestions.Add("Rewrite a conversation you have had in the way you wish it had gone.");
            prompt._randomQuestions.Add("What would you do if you found a puppy in the street?");


            

            while (prompt._toDo != 5)
            {
                prompt.DisplayMenu();
                prompt.ToDo();
                
                if (prompt._toDo == 1)
                {
                    Random random = new Random();
                    prompt._question = prompt._randomQuestions[random.Next(0, prompt._randomQuestions.Count)];
                    Console.WriteLine(prompt._question);
                    journal._journal.Add(new Entry
                    {
                        _currentDate = theCurrentTime.ToShortDateString(),
                        _randomPrompt = prompt._question,
                        _journalEntry = Console.ReadLine()
                    });
                }
                else if (prompt._toDo == 2)
                {
                    journal.DisplayJournal(); 
                }
                else if (prompt._toDo == 4)
                {
                    Console.WriteLine("What is the filename");
                    journal._fileName = Console.ReadLine();
                    journal.SaveToAFile();                         
                }
                else if (prompt._toDo == 3)
                {
                    Console.WriteLine("What is the filename");
                    journal._fileName = Console.ReadLine();
                    journal.SaveLoadedFile();
                }

                if (prompt._toDo > 5) 
                {
                    Console.WriteLine($"Sorry {prompt._toDo} is not on the choices.");
                    break;
                }
            }
        
        } // Error Handling
        catch (FileNotFoundException)   
        {
            Console.WriteLine($"File not found.");
        }
        catch (FormatException)
        {
            Console.WriteLine($"Wrong input. Use number 1 to 5 only.");
        }
    }
}