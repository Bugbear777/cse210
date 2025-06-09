public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints, int currentCount = 0) : base(name, points)
    {
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
        this.currentCount = currentCount;
    }

    public override int RecordEvent()
    {
        if (currentCount < targetCount)
        {
            currentCount++;
            if (currentCount == targetCount)
            {
                Console.WriteLine($"Checklist complete! Bonus {bonusPoints} points awarded!");
                return points + bonusPoints;
            }
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
        Console.WriteLine($"[{(currentCount == targetCount ? "X" : " ")}] {name} -- Completed {currentCount}/{targetCount} times");
    }

    public override string SaveString()
    {
        return $"Checklist|{name}|{points}|{targetCount}|{bonusPoints}|{currentCount}";
    }
}
