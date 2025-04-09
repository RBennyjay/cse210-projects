using System;

public abstract class Shape
{
    private string color;

    // Constructor
    public Shape(string color)
    {
        this.color = color;
    }

    // Getter for color
    public string GetColor()
    {
        return color;
    }

    // Setter for color
    public void SetColor(string color)
    {
        this.color = color;
    }

    // Virtual method for GetArea (abstract since base class should not implement it)
    public abstract double GetArea();
}
