using System;

public class Journal
{
    // start
    public string _author;
    public string _name;
    public List<Entry> _entries = new List<Entry>();
    public void storeEntry()
    {
        Console.WriteLine("Pulled from entry");
        // Save entry to _entries list
    }
    public void saveToFile()
    {
        Console.WriteLine("All entries saved to file");
        // Save current state of journal
    }
    public void loadFromFile()
    {
        Console.WriteLine("Journal loaded");
        // Load current state of journal from file
    }
}