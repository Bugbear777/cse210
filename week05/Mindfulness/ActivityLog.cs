class ActivityLog
{
    private Dictionary<string, int> activityCounts = new Dictionary<string, int>();

    public void Increment(string activityName)
    {
        if (activityCounts.ContainsKey(activityName))
        {
            activityCounts[activityName]++;
        }
        else
        {
            activityCounts[activityName] = 1;
        }
    }

    public void Display()
    {
        Console.WriteLine("\nActivity Log:");
        foreach (var entry in activityCounts)
        {
            Console.WriteLine($"{entry.Key} Activity performed {entry.Value} time(s).");
        }
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }
}