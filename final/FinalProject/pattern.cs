using System;

public class Pattern {
    private Effect effect1 = new Effect(); 
    public void checkForPattern() {
        Console.WriteLine("is this a pattern?");
    }
    public void createEffect() {
        Console.WriteLine($"the effect {effect1.createEffect()} was created");
    }
}