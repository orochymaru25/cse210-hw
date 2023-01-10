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
        void DisplayMessage()
        {
            Console.WriteLine("Hello world!");
        }

    }
}