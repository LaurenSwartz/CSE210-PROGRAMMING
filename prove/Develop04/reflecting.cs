using System;
using System.Collections.Generic;


public class Reflection : Activity
{
    int randomNumber;
    private List<string> reflectionList = new List<string>();
    private List<string> reflectionQuestion = new List<string>();
    public Random random = new Random();

    public Reflection(string welcome, string description)
        : base(welcome, description)
    {
        reflectionList.Add("Think of a time you stood up for someone else.");
        reflectionList.Add("Think of a time when you did something really difficult.");
        reflectionList.Add("Think of a time when you helped someone in need.");
        reflectionList.Add("Think of a time when you did something truly selfless.");

        reflectionQuestion.Add("Why was this experience meaningful to you?");
        reflectionQuestion.Add("Have you ever done anything like this before?");
        reflectionQuestion.Add("How did you get started?");
        reflectionQuestion.Add("How did you feel when it was complete?");
        reflectionQuestion.Add("What made this time different than other times when you were not as successful?");
        reflectionQuestion.Add("What is your favorite thing about this experience?");
        reflectionQuestion.Add("What could you learn from this experience that applies to other situations?");
        reflectionQuestion.Add("What did you learn about yourself through this experience?");
        reflectionQuestion.Add("How can you keep this experience in mind in the future?");
    }

    public string GetReflectionList()
    {
        randomNumber = random.Next(0,4);
        return reflectionList[randomNumber];
    }
    public string GetReflectionQuestion()
    {
        randomNumber = random.Next(0,4);
        return reflectionQuestion[randomNumber];
    }
   
}