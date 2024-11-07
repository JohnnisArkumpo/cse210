using System;

class Program
{
    // start
    static Journal journal1 = new Journal();
    static void displayOptions()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n");
        Console.Write("What would you like to do? ");
        string tempopt = Console.ReadLine();
        int opt = int.Parse(tempopt);
        Entry myEntry = new Entry();
        
        switch(opt) {
            case 1:
                myEntry.recordEntry();
            break;
            case 2:
                journal1.displayJournal();
            break;
            case 3:
                journal1.loadFromFile();
            break;
            case 4:
                journal1.saveToFile();
            break;
            case 5:
                Console.WriteLine("quitting journal");
            break;
        }
    }
    static void Main(string[] args)
    {
        /*
        fix entry workings
        create loop that ends with case 5
        ?
        */
        Console.WriteLine("Welcome to your journal!");
        displayOptions();
    }
}