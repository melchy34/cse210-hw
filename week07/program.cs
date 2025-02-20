using System;
using System.Collections.Generic;

public abstract class Activity
{
    protected DateTime date;
    protected int duration; // in minutes

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public DateTime Date => date;
    public int Duration => duration;

    public abstract double GetDistance(); // in miles or km
    public abstract double GetSpeed(); // in mph or kph
    public abstract double GetPace(); // in min per mile or min per km

    public string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        return $"{date:dd MMM yyyy} {this.GetType().Name} ({duration} min): " +
               $"Distance {distance:F1} {(this is Running ? "miles" : "km")}, " +
               $"Speed: {speed:F1} {(this is Running ? "mph" : "kph")}, " +
               $"Pace: {pace:F2} min per {(this is Running ? "mile" : "km")}";
    }
}

public class Running : Activity
{
    private double distance; // in miles

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;

    public override double GetSpeed() => (distance / duration) * 60; // speed in mph

    public override double GetPace() => duration / distance; // pace in min per mile
}

public class Cycling : Activity
{
    private double speed; // in miles per hour

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed * duration) / 60; // distance in miles

    public override double GetSpeed() => speed; // speed in mph

    public override double GetPace() => 60 / speed; // pace in min per mile
}

public class Swimming : Activity
{
    private int laps; // number of laps

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        // distance in miles (1 lap = 50 meters = 0.031 miles)
        return laps * 50 / 1000 * 0.62; 
    }

    public override double GetSpeed()
    {
        // speed in miles per hour
        return (GetDistance() / duration) * 60;
    }

    public override double GetPace()
    {
        // pace in min per mile
        return duration / GetDistance();
    }
}

public class Program
{
    public static void Main()
    {
        // Create some sample activities
        var activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2022, 11, 3), 45, 12.0),
            new Swimming(new DateTime(2022, 11, 3), 40, 20)
        };

        // Iterate through the activities and display their summary
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
