using System;
using System.Drawing;

public class Shape {
    private string _color;
    public Shape(string color) {
        _color = color;
    }
    public string Color {
        get {return _color;}
        set {_color = value;}
    }
    public string getColor() {
        return _color;
    }
    public virtual double getArea() {
        Console.WriteLine("getting area");
        return 5.563;
    }
}