// Base class
public abstract class Goal
{
    public string Description { get; set; }
    public int Points { get; set; }
    protected bool isComplete;

    public Goal(string description, int points)
    {
        Description = description;
        Points = points;
        isComplete = false;
    }

    public abstract void RecordEvent();
    public abstract string GetDetailsString();
    public abstract void DisplayGoal();
}

// SimpleGoal class
public class SimpleGoal : Goal
{
    public SimpleGoal(string description, int points) : base(description, points) { }

    public override void RecordEvent()
    {
        isComplete = true;
        Console.WriteLine($"You completed the goal! {Points} points awarded.");
    }

    public override string GetDetailsString()
    {
        return isComplete ? $"[X] {Description}" : $"[ ] {Description}";
    }

    public override void DisplayGoal()
    {
        Console.WriteLine(GetDetailsString());
    }
}

// EternalGoal class
public class EternalGoal : Goal
{
    public int TimesCompleted { get; private set; }

    public EternalGoal(string description, int points) : base(description, points)
    {
        TimesCompleted = 0;
    }

    public override void RecordEvent()
    {
        TimesCompleted++;
        Console.WriteLine($"You completed the eternal goal! {Points} points awarded.");
    }

    public override string GetDetailsString()
    {
        return $"Eternal goal: {Description} [{TimesCompleted} times recorded]";
    }

    public override void DisplayGoal()
    {
        Console.WriteLine(GetDetailsString());
    }
}

// ChecklistGoal class
public class ChecklistGoal : Goal
{
    public int Target { get; set; }
    public int TimesCompleted { get; private set; }
    public int Bonus { get; set; }

    public ChecklistGoal(string description, int points, int target, int bonus) : base(description, points)
    {
        Target = target;
        Bonus = bonus;
        TimesCompleted = 0;
    }

    public override void RecordEvent()
    {
        TimesCompleted++;
        int currentPoints = Points;
        if (TimesCompleted == Target)
        {
            currentPoints += Bonus; // Award bonus points
        }
        Console.WriteLine($"You completed part of the checklist goal! {currentPoints} points awarded.");
    }

    public override string GetDetailsString()
    {
        return $"[ ] {Description} (Completed {TimesCompleted}/{Target} times)";
    }

    public override void DisplayGoal()
    {
        Console.WriteLine(GetDetailsString());
    }
}
