using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Fraction object
        // Fraction fraction = new Fraction(3, 4);

        // Use getter methods to retrieve values
        // Console.WriteLine("Numerator: " + fraction.GetNumerator());
        // Console.WriteLine("Denominator: " + fraction.GetDenominator());

        // Use setter methods to modify values
        // fraction.SetNumerator(5);
        // fraction.SetDenominator(8);

        // Console.WriteLine("Updated Numerator: " + fraction.GetNumerator());
        // Console.WriteLine("Updated Denominator: " + fraction.GetDenominator());

        // Using the first constructor (1/1)
        // Fraction fraction1 = new Fraction();
        // Console.WriteLine("Fraction 1: " + fraction1.AsFraction());  // Output: 1/1

        // Using the second constructor (6/1)
        // Fraction fraction2 = new Fraction(6);
        // Console.WriteLine("Fraction 2: " + fraction2.AsFraction());  // Output: 6/1

        // Using the third constructor (6/7)
        // Fraction fraction3 = new Fraction(6, 7);
        // Console.WriteLine("Fraction 3: " + fraction3.AsFraction());  // Output: 6/7



        // Console.WriteLine("Testing constructor with no parameters:");
        // Fraction fraction1 = new Fraction();
        // Console.WriteLine("Fraction 1: " + fraction1.AsFraction());  // Output: 1/1
        // Console.WriteLine();

        // Console.WriteLine("Press Enter to test the second constructor...");
        // Console.ReadLine();

        // Console.WriteLine("Testing constructor with one parameter:");
        // Fraction fraction2 = new Fraction(6);
        // Console.WriteLine("Fraction 2: " + fraction2.AsFraction());  // Output: 6/1
        // Console.WriteLine();

        // Console.WriteLine("Press Enter to test the third constructor...");
        // Console.ReadLine();

        // Console.WriteLine("Testing constructor with two parameters:");
        // Fraction fraction3 = new Fraction(6, 7);
        // Console.WriteLine("Fraction 3: " + fraction3.AsFraction());  // Output: 6/7


        // Console.WriteLine("Testing Fraction Getters and Setters:");

        // Create a new fraction object (3/4)
        // Fraction fraction = new Fraction(3, 4);
        // Console.WriteLine("Initial Fraction: " + fraction.AsFraction());

        // Get and display numerator and denominator
        // Console.WriteLine("Numerator: " + fraction.GetNumerator());
        // Console.WriteLine("Denominator: " + fraction.GetDenominator());

        // Console.WriteLine("\nUpdating values...");

        // Change numerator and denominator using setters
        // fraction.SetNumerator(5);
        // fraction.SetDenominator(8);

        // Display updated values
        // Console.WriteLine("Updated Fraction: " + fraction.AsFraction());
        // Console.WriteLine("Updated Numerator: " + fraction.GetNumerator());
        // Console.WriteLine("Updated Denominator: " + fraction.GetDenominator());


        Console.WriteLine("Testing Fraction Representations:");

        // Test 1: Default constructor (1/1)
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // Test 2: Constructor with one parameter (5/1)
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // Test 3: Constructor with two parameters (3/4)
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // Test 4: Constructor with two parameters (1/3)
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

    }
}