using System;

public class Rect : Shape {
    private double _height;
    private double _width;
    public Rect(string color, double height, double width) : base(color) {
        _height = height;
        _width = width;
    }
    public double Height {
        get {return _height;}
        set {_height = value;}
    }
    public double Width {
        get {return _width;}
        set {_width = value;}
    }
    public override double getArea() {
        return _width*_height;
    }
}