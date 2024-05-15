using System.ComponentModel.DataAnnotations;

public class Entry 
{
    public string _date {get; set;}
    public string _promptText {get; set;}
    public string _entry{get; set;}

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Date: {_promptText}");
        Console.WriteLine($"Date: {_entry}");
    }
}