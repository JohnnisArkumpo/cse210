using System;

public class Circle : Shape {
    private double _radius;
    public Circle(string color, double radius) : base(color) {
        _radius = radius;
    }
    public double Radius {
        get {return _radius;}
        set {_radius = value;}
    }
    public override double getArea() {
        return _radius*_radius*Math.PI;
    }
}