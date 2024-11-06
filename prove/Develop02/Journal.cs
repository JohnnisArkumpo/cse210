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
    }
    public void saveToFile()
    {
        Console.WriteLine("All entries saved to file");
    }
    public void loadFromFile()
    {
        Console.WriteLine("Journal loaded");
    }
}