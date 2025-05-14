using System;
public class JournalEntry
{
    public string Date { get; private set; }
    public string Prompt { get; }
    public string Response { get; }

    public JournalEntry(string prompt, string response)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd");
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n-----------------------------";
    }

    public string ToFileFormat()
    {
        return $"{Date}|{Prompt}|{Response}";
    }

    public static JournalEntry FromFileFormat(string line)
    {
        var parts = line.Split('|');
        return new JournalEntry(parts[1], parts[2]) { Date = parts[0] };
    }
}
