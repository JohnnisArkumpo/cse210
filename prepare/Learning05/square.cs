using System;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;

public class Square : Shape {
    private double _side;
    public Square(string color, double side) : base(color) {
        _side = side;
    }
    public double Side {
        get {return _side;}
        set {_side = value;}
    }
    public override double getArea() {
        return _side*_side;
    }
}