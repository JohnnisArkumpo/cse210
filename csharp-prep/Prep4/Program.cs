using System;
class Program{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Type a list of numbers, then type 0 when finished. This program will compute the average, the lowest number, and the highest number. ");
        List<int> numbers = new List<int>();
        List<int> pnum = new List<int>();
        int inp = 1;
        int sumn = 0;
        while(inp != 0) {
            Console.Write("Enter Number: ");
            string tempn = Console.ReadLine();
            inp = int.Parse(tempn);
            numbers.Add(inp);
        }
        foreach(int i in numbers) {
            sumn += i;
            if(i>0) {
                pnum.Add(i);
            }
        }
        numbers.Sort();
        Console.WriteLine($"The sum is {sumn}");
        Console.WriteLine($"The average is {sumn/(numbers.Count - 1)}");
        Console.WriteLine($"The largest number is {numbers.Max()}");
        Console.WriteLine($"The smallest positive number is {pnum.Min()}");
        Console.WriteLine("The sorted list is: ");
        foreach(int i in numbers) {
            Console.WriteLine(i);
        }
    }
}