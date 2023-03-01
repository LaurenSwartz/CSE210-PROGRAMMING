

using System;
using System.Collections.Generic;


public class Listing : Activity
{
    int randomNumber;
    private List<string> listingList = new List<string>();
    public List<string> _listingAnswers;
    public Random random = new Random();

    public Listing(string activity, string description)
        : base(activity, description)
    {
        listingList.Add("Who are people that you appreciate?");
        listingList.Add("What are personal strengths of yours?");
        listingList.Add("Who are people that you have helped this week?");
        listingList.Add("When have you felt the Holy Ghost this month?");
        listingList.Add("Who are some of your personal heroes?");
    }

    public string GetListingList()
    {
        randomNumber = random.Next(0,4);
        return listingList[randomNumber];
    }   
}
