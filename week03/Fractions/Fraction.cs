using System;

public class Fraction
{
    private int numerator;
    private int denominator;

    // Constructor 1: Default (1/1)
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor 2: One parameter (numerator/1)
    public Fraction(int numerator)
    {
        this.numerator = numerator;
        this.denominator = 1;
    }

    // Constructor 3: Two parameters (numerator/denominator)
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        this.numerator = numerator;
        this.denominator = denominator;
    }

    // Getters
    public int GetNumerator() => numerator;
    public int GetDenominator() => denominator;

    // Setters
    public void SetNumerator(int numerator) => this.numerator = numerator;

    public void SetDenominator(int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        this.denominator = denominator;
    }

    // Method to return fraction as a string
    public string GetFractionString() => $"{numerator}/{denominator}";

    // Method to return decimal value
    public double GetDecimalValue() => (double)numerator / denominator;
}