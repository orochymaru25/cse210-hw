using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

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