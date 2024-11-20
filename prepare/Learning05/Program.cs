using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {
        // Frick code convention, I make my own convention
        List<Shape> shapelist = new List<Shape>();
        shapelist.Add(new Square("blue",5));
        shapelist.Add(new Circle("yellow",5));
        shapelist.Add(new Rect("red",5,6)); 
        foreach(Shape i in shapelist) {
            Console.Write(i.getColor() + " ");
            Console.Write(i.getArea());
            Console.WriteLine();
        }
    }
}