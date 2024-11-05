using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do {
            int gcount = 0;
            int mgs = 1;
            int mnum = 2;
            Console.WriteLine("Welcome to the guessing game!");
            Console.WriteLine("Try to guess what I am thinking");
            while(mgs != mnum) {
                if(gcount == 0) {
                    Random randomGenerator = new Random();
                    mnum = randomGenerator.Next(1,52);
                }
                Console.Write("Guess a number: ");
                string messagetotakeintoconsideration = Console.ReadLine();
                mgs = int.Parse(messagetotakeintoconsideration);
                gcount ++;
                if(mgs > mnum) {
                    Console.WriteLine("Lower");
                }
                else if(mgs < mnum) {
                    Console.WriteLine("Higher");
                }
                else {
                    Console.WriteLine("Correct!");
                    Console.WriteLine($"It took you {gcount} guesses to guess correctly");
                }
            }
            Console.Write("Would you like to play again?(y/n) ");
            response = Console.ReadLine();
        }while(response == "y");
        Console.WriteLine("Thanks for playing!");
    }
}