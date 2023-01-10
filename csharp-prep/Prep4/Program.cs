using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        //Lists
        // As you know, a major difference between C# and Python is that you must declare your variable types in C#. While at first, this may seem like a burden in C#, you'll soon discover that it helps you avoid many runtime errors.

        // In a similar way, when you declare a new list variable in C#, you not only declare that it is a List, you must also declare the type of data that can be put in the list. That way, if you create a list of users, you will be prevented from accidentally adding an order or a product variable to this list.

        // To create a new list of integers, you specify int inside angle brackets <> directly following the name of the data structure: List<int> and if you want to have a list of strings, you would use: List<string> as shown below.
        // List<int> numbers;
        // List<string> words;

        // The code above declares a variable to hold the list, but before you can use one, you need to create a new one to use with the new keyword.
        // numbers = new List<int>();

        // This is typically done on the same line:

        // List<int> numbers = new List<int>();
        // List<string> words = new List<string>();
        //Notice the extra parentheses () at the end, that we use any time we create a new object.

        // One more important thing to be aware of: Any file that uses Lists (or any other standard collection), must refer to that library at the top of the file. (This is so common that sometimes your settings for C# can be specified so that you do not not have include this, but it is important to know about it, in case you run into problems.)
        // using System.Collections.Generic;

        //What is "new" and why do we need it?
        // It turns out that List is a class or custom data type and we are creating a new object or instance of that class. This is actually the complete focus of this course, and beginning next week you will learn how to create your very own custom classes.

        // With this in mind, you will learn much more about this in coming weeks, but for now, just remember to include new before you start using a list.

        //Adding Items to the List
        // To add items to the list, you use the .Add() method:

        List<int> numbers = new List<int>();
        List<string> words = new List<string>();

        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");

        // Getting the list size
        // You can get the size of the list with the Count property.
        Console.WriteLine(words.Count);
        int wordCount = words.Count;
        Console.WriteLine(wordCount);
        // Notice that you do not include parentheses () after Count because it is a property, not a function.

        //Iterating through a List
        //The easiest (and safest) way to iterate through a list in C# is to use the foreach loop:
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        Console.WriteLine();

        // You can also access the items by their index:
        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine(words[i]);
        }


        // Assignment

        // Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userInput = -1;

        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
            
        }
        
        // foreach (int number in numbers)
        // {
        //     Console.WriteLine(number);
        // }

        //Once you have a list, have your program do the following:
        // get the sum
        Console.WriteLine($"The sum is: {numbers.Sum()}");

        // get the average
        Console.WriteLine($"The average is: {(double)numbers.Sum() / numbers.Count}");

        // get the largest number
        int largestNumber = 0;
        
        // get the smallest positive number
        int smallPositive = 0;

        foreach (int i in numbers)
        {
            // largest
            if (i > largestNumber)
            {
               largestNumber = i;
            }
            
            // smallest positive
            if (i < largestNumber && i > 0)
            {
                smallPositive = i;
            }
        }
        //display the largest
        Console.WriteLine($"The largest number is: " + largestNumber);
        //display the smallest
        Console.WriteLine($"The smallest positive number is: " + smallPositive);

        // Sort the number
        numbers.Sort();
        Console.WriteLine("Sorted list is: ");
        foreach (int sortedNumber in numbers)
        {
            Console.WriteLine(sortedNumber);
        }

        Console.WriteLine();

        // Sort the number in reverse
        numbers.Reverse();
        foreach (int sortedNumber in numbers)
        {
            Console.WriteLine(sortedNumber);
        }

        Console.WriteLine();
        Console.WriteLine();

        // create a list of food to be sorted later
        List<string> food = new List<string>();
        food.Add("Salad");
        food.Add("Spaghetti");
        food.Add("Macaroni");
        food.Add("Pizza");
        food.Add("Apple");
        food.Add("Banana");

        // sort with alphabetical order
        food.Sort();
        foreach (string sorted in food)
        {
            Console.WriteLine(sorted);
        }

        Console.WriteLine();

        // sort the list and with its length - it uses the lambda function and with Linq libraries
        food.Sort((food1, food2) => food1.Length.CompareTo(food2.Length));
        foreach (string sorted in food)
        {
            Console.WriteLine(sorted);
        }
    }
}