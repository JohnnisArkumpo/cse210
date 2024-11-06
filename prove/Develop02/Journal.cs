using System;

class Journal
{
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
    static void Main(string[] args) 
    {
        // 
    }
}