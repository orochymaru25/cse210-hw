using System;
// using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        // While Loops
        // While loops in C# work exactly the same way as in Python or other languages. The only difference is that C# uses curly braces {} to define the body of the loop, and the condition, must be surrounded by parentheses ().
        // string input = "yes";
        // while (input == "yes")
        // {
        //     Console.Write("Do you want to continue? ");
        //     input = Console.ReadLine();
        // }

        // Do-While Loops
        // Many languages have a construct called a do-while loop (Python does not). This loop works the same as a while loop, with the exception that the body of the loop runs once first, before the check is made for the first time. This means that the body of the loop is guaranteed to run at least once.
        // string input;
        // do{
        //     Console.Write("Do you want to continue? ");
        //     input = Console.ReadLine();
        // } while (input == "yes");

        // For Loops
        //The standard for loop in C# is more like a "for x in range" loop in Python. The condition has three parts, separated by semi-colons. The first initializes the value, the second is the condition to check, and the third is an increment step that is run at the end of each loop.

        //The following code shows the syntax of a for loop that counts from 0 to 9.
        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        //In that code, you will see the use of the ++ operator which increments the value in the variable by one.

        // The code above is the most common way to see one of these loops, but you could put other values or statements in these spots, such as counting from 2 to 20 by two's:
        // for (int i = 2; i <= 20; i = i + 2)
        // {
        //     Console.WriteLine(i);
        // }

        //Foreach Loops
        //C# contains a foreach loop that is similar to a standard for loop in Python. It is important to remember that the iterator variable must have its type defined, just like when declaring any other variable:

        List<String> colors = new List<String>();
        colors.Add("red");
        colors.Add("blue");
        colors.Add("green");
        colors.Add("yellow");
    
        Console.WriteLine("asdfasdfasdfasdfsdfasdf");

        Random randomm = new Random();
        Console.WriteLine(colors[randomm.Next(0, colors.Count)]);

        // foreach (String item in colors)
        // {
        //     Console.WriteLine(item);
        // }
        //The foreach loop will be used extensively in the next preparation material that discusses lists.

        //Random Numbers
        //In addition, for this assignment you'll need to get a random number from the computer. In C#, this is done by creating an instance of the Random class, and then using it to get the next integer in a particular range.
        
        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1, 11);
        // Console.WriteLine(number);

        // Assignments
        // Guess My Number

        // core requirement
        // Console.Write("What is the magic number? ");
        // string number = Console.ReadLine();
        // int magicNumber = int.Parse(number);

        // #3 core
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        Console.WriteLine(magicNumber);

        int guess = -1;
        int numberOfGuesses = 0; // record the number of try

        while (guess != magicNumber) // while loop will run until user guess the magicNumber
        {
            Console.Write("What is your guess? ");
            int userInput = int.Parse(Console.ReadLine());
            guess = userInput;

            if (guess == magicNumber)
            {
                Console.WriteLine();
                Console.WriteLine("You guessed it!");
                numberOfGuesses++;
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
                numberOfGuesses++;
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
                numberOfGuesses++;
            }

            
            if (guess == magicNumber)
            {
                Console.WriteLine($"Number of Guesses: " + numberOfGuesses);
                Console.Write("Play again (Yes/No)? ");
                string playAgain = Console.ReadLine();

                if (playAgain == "yes")
                {
                    magicNumber = randomGenerator.Next(1,100);
                    Console.WriteLine(magicNumber);
                    guess = -1;
                    numberOfGuesses = 0;
                }
                else if (playAgain == "no")
                {
                    Console.WriteLine("Thank you.");
                }
            }
        }
        


    }
}