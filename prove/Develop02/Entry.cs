using System;

public class Entry 
{
    public string prompt;
    public string response;
    public string date;

    public Entry(string prom, string rsp)
    {
        DateTime currentTime = DateTime.Now;
        string dateResponse = currentTime.ToLongDateString();
        date = dateResponse;

        prompt = prom;
        response = rsp;

    }
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {date} Prompt:{prompt}"); 
        Console.WriteLine(response); 
    }
}
    

