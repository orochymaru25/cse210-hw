using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep1 World!");

        // Console.WriteLine("Hello World!");
        // Console.WriteLine("This is in C#.");

        // int number = 5;
        // number = 8;
        // number = number + 3;

        // string color = "blue";

        // if (number > 3)
        // {
        //     Console.WriteLine("");
        //     Console.WriteLine("");
        // }

        // Console.Write("What is your favorite color? ");
        // string color = Console.ReadLine();
        // Console.WriteLine($"Your color is {color}");

        // Console.Write("What is your First Name? ");
        // string firstName = Console.ReadLine();
        // Console.Write("What is your Last Name? ");
        // string lastName = Console.ReadLine();
        // Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

        // C# supports else and else if, similar to else and elif in Python.
        // The else if condition also defines its body in the same fashion. Please note that in C#, the keywords are else if not elif:

        // int x = 5;
        // int y = 4;
        // int z = 3;
        // if (x > y)
        // {
        //     Console.WriteLine("greater than");
        //     if (x > z)
        //     {
        //         Console.WriteLine("greater than both");
        //     }
        // }
        // else if (x > z)
        // {
        //     Console.WriteLine("greater than z")
        // }
        // else
        // {
        //     Console.WriteLine("less than");
        // }

        // string name = "John";
        // string favoriteColor = "red";

        // Operators
        // C# uses the == operator to check if two variables are equal, just like in Python. It also supports other operators you are familiar with, such as !=, >=, <=, and so forth:

        // if (name == "John")
        // {
        //     Console.WriteLine("The name is John");
        // }

        // if (color != favoriteColor)
        // {
        //     Console.WriteLine("That color is not my favorite");
        // }

        //And, Or, and Not Operators
        //In C#, the and operator is && the or operator is || and the not operator is ! which can be combined together with other expressions and parentheses.
        // if (name == "Peter" || name == "James" || name == "John")
        // {
        //     Console.WriteLine("This is a biblical name.");
        // }

        // if (firstName == "Brigham" && lastName == "Young")
        // {
        //     Console.WriteLine("Welcome Brother Brigham!");
        // }

        // if (!(name == "Peter" || name == "James" || name == "John"))
        // {
        //     Console.WriteLine("This is a not one of those three");
        // }

        //Variables and Types
        // In C#, the naming convention for variables is to use "camel case." This means that the variable starts with a lower case letter and then additional words in the variable start with an upper case letter like humps on a camel:
    // Example
        // string color1 = "red";
        // string firstName1 = "Aby";
        // string lastName1 = "Brian";
        // int velocityBeforeImpactWasMade = 2;

        //Converting Types
        // As mentioned before, in C#, all variables must have their data type defined when the variable is first declared. Once defined, variables cannot change type, so you cannot set a variable to an integer first and later reassign it to a string.

        // You can, however convert a the value of a variable to a different type. For example, you can create an integer from the digits stored in a string using the int.Parse() function.
        // string valueInText = "42";
        // int number1 = int.Parse(valueInText);
        //This is especially important if the value comes from the user via a Console.ReadLine() statement, which always returns a string:
        // Console.Write("What is your favorite number? ");
        // string userInput = Console.ReadLine();
        // int number2 = int.Parse(userInput);
        //If the user typed in something other than a number, this would result in type of error called a Runtime Exception.

        //Numbers to Strings
        // Similarly, an integer can be converted to a string using the .ToString() function of the variable.


        // int number3 = 42;
        // string textVersion = number3.ToString();

        Console.Write("Grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());
        string letter = "";
        string symbol = "";
        
        if (gradePercentage >= 90)
        {
            // Console.WriteLine("A");
            int remainder = gradePercentage % 10;
            if (remainder >= 3)
            {
                letter = "A";
            }
            else
            {
                letter = "A";
                symbol = "-";
            }
                
        }
        else if (gradePercentage >= 80)
        {
            // Console.WriteLine("B");
            int remainder = gradePercentage % 10;
            if (remainder >= 7)
            {
                letter = "B";
                symbol = "+";
            }
            else if (remainder >= 3)
            {
                letter = "B";
            }
            else
            {
                letter = "B";
                symbol = "-";
            }
            
        }
        else if (gradePercentage >= 70)
        {
            // Console.WriteLine("C");
            int remainder = gradePercentage % 10;
            if (remainder >= 7)
            {
                letter = "C";
                symbol = "+";
            }
            else if (remainder >= 3)
            {
                letter = "C";
            }
            else
            {
                letter = "C";
                symbol = "-";
            }
        }
        else if (gradePercentage >= 60)
        {
            // Console.WriteLine("D");
            int remainder = gradePercentage % 10;
            if (remainder >= 7)
            {
                letter = "D";
                symbol = "+";
            }
            else if (remainder >= 3)
            {
                letter = "D";
            }
            else
            {
                letter = "D";
                symbol = "-";
            }
        }
        else if (gradePercentage < 60)
        {
            // Console.WriteLine("F");
            letter = "F";
        }
        Console.WriteLine($"{letter}{symbol}");
        // Console.Read();

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Passed");
        }
        else
        {
            Console.WriteLine("Do your best next time.");
        }



    }
}