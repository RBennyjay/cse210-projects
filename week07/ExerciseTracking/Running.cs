using System;

public class Running : Activity
{
    private double distance; // in kilometers

    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;

    public override double GetSpeed() => (distance / GetMinutes()) * 60;

    public override double GetPace() => GetMinutes() / distance;
}
