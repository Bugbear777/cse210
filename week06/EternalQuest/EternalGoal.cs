public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points)
    {
    }

    public override int RecordEvent()
    {
        return points;
    }

    public override void Display()
    {
        Console.WriteLine($"[∞] {name}");
    }

    public override string SaveString()
    {
        return $"Eternal|{name}|{points}";
    }
}
