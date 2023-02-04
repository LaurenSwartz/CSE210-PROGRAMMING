using System;

class Program
{
    static void Main(string[] args)
    {   
        Journal journal = new Journal();

        Console.WriteLine("Welcome to my Journal");
        while(journal.DisplayJournal());
    }
}