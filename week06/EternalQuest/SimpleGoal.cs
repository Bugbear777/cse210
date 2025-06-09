public class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string name, int points, bool isComplete = false) : base(name, points)
    {
        this.isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!isComplete)
        {
            isComplete = true;
            return points;
        }
        else
        {
            Console.WriteLine("Goal already completed.");
            return 0;
        }
    }

    public override void Display()
    {
        Console.WriteLine($"[{(isComplete ? "X" : " ")}] {name}");
    }

    public override string SaveString()
    {
        return $"Simple|{name}|{points}|{isComplete}";
    }
}
