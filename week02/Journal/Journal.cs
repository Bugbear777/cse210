using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        var lines = entries.Select(e => e.ToFileFormat());
        File.WriteAllLines(filename, lines);
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        var lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            JournalEntry entry = JournalEntry.FromFileFormat(line);
            entries.Add(entry);
        }
    }

}
