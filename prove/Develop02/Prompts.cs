using System;

public class Prompts
{
    // start
    public List<string> _prompts = new List<string>();
    public string getPrompt() {
        // create list of prompts and return random prompt
        _prompts.AddRange(new List<string> {"What was the greatest battle you won today?","How has God shown you His mercy today?","What is a memory from today you'd like to remember?","If you could start today over again, what would you do differently?","If you knew today had been your last day what would you like to have done?"});
        Random promptChooser = new Random();
        int pn = promptChooser.Next(0, _prompts.Count()-1);
        return _prompts[pn];
    } 
    public void displayPrompt() {
        Console.WriteLine($"{getPrompt}");
    }
}