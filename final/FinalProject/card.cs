using System;

public class Card {
    private string _name;
    public Card(string name) {
        _name = name;
    }
    public string Name {
        get {return _name;}
        set {_name = value;}
    }
    public virtual void createEffect() {
        Console.WriteLine("null effect");
    }
}