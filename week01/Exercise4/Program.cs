using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Collect numbers from the user
        do
        {
            Console.Write("Enter number: ");
            bool isValid = int.TryParse(Console.ReadLine(), out number);

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                continue;
            }

            if (number != 0) 
            {
                numbers.Add(number);
            }

        } while (number != 0);

        // Ensure there are numbers in the list before calculations
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
        }
        else
        {
            int sum = numbers.Sum();
            double average = numbers.Average();
            int maxNumber = numbers.Max();


            // Stretch Challenge

            // Find the smallest positive number
            int? smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty().Min();

            // Sort the list in ascending order
            numbers.Sort();


            Console.WriteLine($"\nThe sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {maxNumber}");


            if (smallestPositive > 0)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }
            else
            {
                Console.WriteLine("No positive numbers were entered.");
            }

            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

    }
}