using System;

public class Prompts
{
    // start
    public List<string> _prompts = new List<string>();
    public string getPrompt() {
        return "prompt";
        // create list of prompts and return random prompt
    } 
    public void displayPrompt() {
        Console.WriteLine($"{getPrompt}");
    }
}