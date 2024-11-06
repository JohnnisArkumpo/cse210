using System;

class Program
{
    static void displayWelcome() {
        Console.WriteLine("Welcome to the program! ");
    }
    static string promptUserName() {
        Console.Write("What's your name? ");
        return Console.ReadLine();
    }
    static int promptUserNumber() {
        Console.Write("What's your favorite number? ");
        string tempn = Console.ReadLine();
        return int.Parse(tempn);
    }
    static int squareNumber(int n) {
        return n*n;
    }
    static void displayResult(string nm, int nb) {
        Console.WriteLine($"{nm}, The square of your number is {nb}");
    }
    static void Main(string[] args)
    {
        displayWelcome();/**
        string un = promptUserName();
        int unum = promptUserNumber();
        int unumsq = squareNumber(unum);
        displayResult(un, unumsq);**/
        displayResult(promptUserName(), squareNumber(promptUserNumber()));
    }
}