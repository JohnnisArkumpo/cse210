using System;

class Program {
    static string chooseScripture() {
        Console.Write("We will be memorizing scriptures from 2 Nephi 2\nChoose a verse or a set of verses from this chapter: ");
        string userChoice = Console.ReadLine();
        Verse memorizationToday = new Verse();
        string versestring = memorizationToday.getPassage(userChoice);
        return versestring;
    }
    static void scriptureDisplay(string scrip) {
        Console.Clear();
        Console.WriteLine(scrip);
    }
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");
        /*create a display function
        create a getInput function
        utilize the other three classes*/
    }
}

/**
note responsabilites for different classes
class name
class behaviors (functions)
class attributes (parameters)

If I have a method longer than 10 lines, could it be a different class?
If not, could it be multiple functions?
**/