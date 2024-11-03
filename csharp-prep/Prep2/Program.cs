using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your grade? ");
        string gnum = Console.ReadLine();
        int grade = int.Parse(gnum);        
        int remaind = grade%10;
        string letterg = "A";
        string letters = "";
        string word = "a";
        string message = "You passed the class! Congratulations!";
        string m2 = "Unfortunately you did not pass the class. Better luck next time!";
        if(grade >= 90) {
            letterg = "A";
            word = "an";
        }
        else if(grade >= 80) {
            letterg = "B";
        }
        else if(grade >= 70) {
            letterg = "C";
        }
        else if(grade >= 60) {
            letterg = "D";
            message = m2;
        }
        else {
            letterg = "F";
            word = "an";
            message = m2;
        }
        if(letterg != "F") {
            if(remaind >= 7) {
                if(letterg != "A") {
                    letters = "+";
                }
            }
            else if(remaind > 3) {
                letters = "";
            }
            else {
                letters = "-";
            }
        }
        Console.WriteLine("");
        Console.WriteLine($"Your grade is {word} {letterg}{letters}");
        Console.WriteLine(message);
    }
}