using System;

public class Player {
    private int health = 20;
    public void loseHealth(int damage) {
        health = health - damage;
    }
    public void displayHealth() {
        // return health; // should be public int in final iteration
        Console.WriteLine(health);
    }
}