using System;

class Program
{
    static void Main(string[] args)
    {
        // Test Assignment
        Assignment assignment = new Assignment("Ebenezer John", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine();

        // Test MathAssignment
        MathAssignment mathAssignment = new MathAssignment("Dannie Botha", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine();

        // Test WritingAssignment
        WritingAssignment writingAssignment = new WritingAssignment("Sylvia Jacobs", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}

