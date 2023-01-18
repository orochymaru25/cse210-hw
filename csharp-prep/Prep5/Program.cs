using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");

        //Functions in C# are defined and work very similarly to those in Python. In both languages you define the function with a name and list of parameters. The function then has a body that performs tasks and it can potentially return a value.

        // One key difference in C# is that in the same way that each variable must define a type, each function must define its return type, for example, whether it will return an int, a string, or nothing (the return type for nothing is void). Also, each parameter must have a data type as well. This is very helpful because, unlike in Python, you will know exactly what kind of data you are receiving.

        // The style guidelines for C# say that a function name should use "Title Case" where the name begins with a capital letter and then each subsequent word is capitalized such as: ThisIsALongFunction.

        // The general structure of a function definition in C# is:
        // returnType FunctiName(dataType parameter1, dataType parameter2)
        // {
        //     //function_body
        // }


        // Here is an example of a function that does not have parameters or a return type (hence the use of void):
        // void DisplayMessage()
        // {
        //     Console.WriteLine("Hello world!");
        // }
        // in Python it is:
        // def display_message():
        //     print("Hello World")


        //The next example shows a function that accepts a single string parameter:
        // void DisplayPersonalMessage(string userName)
        // {
        //     Console.WriteLine($"Hello {userName}");
        // }
        // in Python it is:
        // def display_personal_message(user_name):
        //     print(f"Hello {user_name}")

        // The next example shows a function that accepts two integers as parameters. It adds them together and returns the result. Notice that the function specifies a return value of int at the beginning of the definition.
        // int AddNumbers(int first, int second)
        // {
        //     int sum = first + second;
        //     return sum;
        // }
        // in Python it is:
        // def add_numbers(first, second):
        //     sum = first + second
        //     return sum

        //Functions vs Methods
        // From previous courses, you may recall a distinction between standalone functions and member functions, which are called methods. Methods play a very important role in Programming with Classes and they will be discussed at length in the coming lessons.

        // In C#, because the language is so dedicated to the principles of Programming with Classes, the default case for all functions is to be methods, which must be called in the context of an object. (Again, more on this later!) But this has an important ramification for you now. If you want to define "regular" standalone function, you need to use the static keyword. This tells C# that you want your functions to be able to be called without any other context.

        // To define a standalone function in C#, use the static keyword before the return type:
        // static void DisplayMessage()
        // {
        //     Console.WriteLine("Hellow world!");
        // }

        // static void DisplayhPersonalMessage(string userName)
        // {
        //     Console.WriteLine($"Hello {userName}");
        // }

        // static int AddNumbers(int first, int seconde)
        // {
        //     int sum = first + seconde;
        //     return sum;
        // }

        // Until we start writing classes, you should put the static keyword in front of all your functions.

        // Use static for all of your functions until we start writing classes.

        //youtube video about Functions/Methods
        // <visibility> <return type> <name>(<parameters>)
        // {
        //     //code goes here
        // }
        //      Calling a Function
        //<name>();
        //<name>(<parameters>); if has parameters

        // youtube example1
        // double firstSum = AddNumbers(12.7, 16.35);
        // Console.WriteLine($"FirstSum = {firstSum}");

        // double secondSum = AddNumbers(12.7, 16.35);
        // Console.WriteLine($"FirstSum = {secondSum}");





        // Assignments

        // DisplayWelcome - Displays the message, "Welcome to the Program!"
        DisplayMessage();
        // PromptUserName - Asks for and returns the user's name (as a string)
        string name;
        name = PromptUserName();
        // Console.WriteLine(name);
        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        int number;
        number = PromptUserNumber();
        // Console.WriteLine(number);
        // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        int squared = SquareNumber(number);
        // Console.WriteLine($"Squared: {squared}");
        // Display it all three
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }

    // youtube example1
    // static double AddNumbers(double firstNumber, double secondNumber) => firstNumber + secondNumber;

    // Assignment
    static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
}