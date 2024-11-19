using System;

class Program {
    static void Main(string[] args) {
        // Frick code convention, I make my own convention
        Shape cubie = new Square("blue", 5.56);
        Console.WriteLine(cubie.getColor());
        Console.WriteLine(cubie.getArea());
    }
}