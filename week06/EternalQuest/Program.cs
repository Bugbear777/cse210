// Eternal Quest Program
// Creativity: added Leveling System, Titles based on Level, Bonus Points for Reaching Level Milestones

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;
    static int level = 1;

    static void Main(string[] args)
    {
        LoadData();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Eternal Quest ===");
            Console.WriteLine($"Score: {score}  Level: {level}  Title: {GetTitle(level)}");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Record event");
            Console.WriteLine("4. Save and Exit");

            Console.Write("Select an option: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                CreateGoal();
            }
            else if (input == "2")
            {
                ListGoals();
            }
            else if (input == "3")
            {
                RecordEvent();
            }
            else if (input == "4")
            {
                SaveData();
                break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter points awarded: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            goals.Add(new SimpleGoal(name, points));
        }
        else if (choice == "2")
        {
            goals.Add(new EternalGoal(name, points));
        }
        else if (choice == "3")
        {
            Console.Write("Enter number of completions required: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter bonus points for completing the checklist: ");
            int bonus = int.Parse(Console.ReadLine());

            goals.Add(new ChecklistGoal(name, points, target, bonus));
        }
    }

    static void ListGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].Display();
        }
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    static void RecordEvent()
    {
        ListGoals();
        Console.Write("Select goal number to record progress: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count)
        {
            int pointsEarned = goals[index].RecordEvent();
            Console.WriteLine($"You earned {pointsEarned} points!");

            score += pointsEarned;
            UpdateLevel();
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    static void UpdateLevel()
    {
        int newLevel = score / 1000 + 1;
        if (newLevel > level)
        {
            level = newLevel;
            int bonusPoints = level * 100; // Level milestone bonus
            score += bonusPoints;
            Console.WriteLine($"Congratulations! You reached Level {level} and earned {bonusPoints} bonus points!");
        }
    }

    static string GetTitle(int level)
    {
        if (level < 3) return "Novice Adventurer";
        if (level < 5) return "Seasoned Seeker";
        if (level < 8) return "Quest Master";
        return "Legendary Hero";
    }

    static void SaveData()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(score);
            writer.WriteLine(level);

            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.SaveString());
            }
        }
    }

    static void LoadData()
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            score = int.Parse(lines[0]);
            level = int.Parse(lines[1]);

            goals.Clear();

            for (int i = 2; i < lines.Length; i++)
            {
                Goal goal = Goal.LoadString(lines[i]);
                if (goal != null)
                {
                    goals.Add(goal);
                }
            }
        }
    }
}