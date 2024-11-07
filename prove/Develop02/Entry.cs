using System;

public class Entry
{
    // start
    public DateTime _date;
    public Prompts _prompt = new Prompts();
    public string _text;
    public void recordEntry() 
    {
        _date = DateTime.Now;
        Console.WriteLine($"{_prompt.getPrompt()}");
        Console.Write(" > ");
        _text = Console.ReadLine();
    }
}