using System;

public class Journal
{
    // start
    public string _author;
    public string _name;
    public List<Entry> _entries = new List<Entry>();
    public void storeEntry(string promptt, DateTime datet, string entryt)
    {
        Console.WriteLine("Pulled from entry");
        // Save entry to _entries list

    }
    public void saveToFile()
    {
        Console.WriteLine("All entries saved to file");
        // Save all journal entries
    }
    public void loadFromFile()
    {
        Console.WriteLine("Journal loaded");
        // Load current state of journal from file
    }
    public void displayJournal()
    {
        Console.WriteLine("this is your entire journal");
    }
}