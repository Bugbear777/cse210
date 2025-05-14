using System;
using System.IO;

public class PromptGenerator
{
    private string[] prompts;
    private Random rand;

    public PromptGenerator()
    {
        string filePath = "journalPrompts.txt";
        rand = new Random();

        if (File.Exists(filePath))
        {
            prompts = File.ReadAllLines(filePath);
        }
        else
        {
            prompts = new string[]
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };

            Console.WriteLine("Warning: 'journalPrompts.txt' not found. Using default prompts.");
        }
    }

    public string GetRandomPrompt()
    {
        if (prompts.Length == 0)
        {
            return "No prompts available.";
        }

        int index = rand.Next(prompts.Length);
        return prompts[index];
    }
}
