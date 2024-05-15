using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.Display();

        // The menu for the journal
        bool quit = false;
        
        while (!quit)
        {
        Console.WriteLine("Please select one of the following choices ");
        Console.WriteLine("1. Write ");
        Console.WriteLine("2. Display ");
        Console.WriteLine("3. Load ");
        Console.WriteLine("4. Save ");
        Console.WriteLine("5. Quit ");
        Console.Write("What would you like to do? ");

        string answer = Console.ReadLine();
        }
    }
}