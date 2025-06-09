public abstract class Goal
{
    protected string name;
    protected int points;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public abstract int RecordEvent();
    public abstract void Display();
    public abstract string SaveString();

    public static Goal LoadString(string line)
    {
        string[] parts = line.Split('|');
        string type = parts[0];

        if (type == "Simple")
            return new SimpleGoal(parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
        else if (type == "Eternal")
            return new EternalGoal(parts[1], int.Parse(parts[2]));
        else if (type == "Checklist")
            return new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
        else
            return null;
    }
}
