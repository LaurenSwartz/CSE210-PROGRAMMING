using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        int time;

        while (choice != "4")
        {
            Console.Clear();
            DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.WriteLine($"{choice}");

            if (choice == "1")
            {
                Breathing newBreathing = new Breathing("Welcome to the Breathing Activity\n", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n", "Breathe In", "Breathe Out");
                Console.Clear();
                Console.WriteLine(newBreathing.GetWelcome());
                Console.WriteLine(newBreathing.GetDescription());
                Console.Write("How long, in 10 second increments, would you like for your session? ");
                time = int.Parse(Console.ReadLine());
                int originalTime = time;
                Console.Clear();
                Console.WriteLine("Get Ready...");
                List<string> animationStrings = new List<string>();
                animationStrings.Add("|");
                animationStrings.Add("/");
                animationStrings.Add("-");
                animationStrings.Add("\\");
                animationStrings.Add("|");
                animationStrings.Add("/");
                animationStrings.Add("-");
                animationStrings.Add("\\");

                int intro = 0;
                while (intro <= 7)
                {
                foreach (string s in animationStrings)
                {
                    Console.Write(s);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    intro++;
                }
                }

                while (time > 0)
                {
                Console.Write("\n");
                Console.Write(newBreathing.GetBreatheIn());
                for (int i = 4; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    time--;
                }
                Console.Write("\n");
                Console.Write(newBreathing.GetBreatheOut());
                for (int i = 6; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    time--;
                }
                Console.Write("\n");
                }

                int well = 0;
                Console.WriteLine("\nWell done!!");
                while (well <= 7)
                {
                foreach (string s in animationStrings)
                {
                    Console.Write(s);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    well++;
                }

                int last = 0;
                Console.WriteLine($"\nYou have completed another {originalTime} seconds of the Breathing Activity.");
                while (last <= 7)
                {
                foreach (string s in animationStrings)
                {
                    Console.Write(s);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    last++;
                }
                }
                }
            } 
            else if (choice == "2")
            {
                Reflection newReflection = new Reflection("Welcome to the Reflection Activity\n", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
                Console.Clear();
                Console.WriteLine(newReflection.GetWelcome());
                Console.WriteLine(newReflection.GetDescription());
                Console.Write("How long, in 10 second increments, would you like for your session? ");
                time = int.Parse(Console.ReadLine());
                int originalTime = time;
                Console.Clear();
                Console.WriteLine("Get Ready...");
                List<string> animationStrings = new List<string>();
                animationStrings.Add("|");
                animationStrings.Add("/");
                animationStrings.Add("-");
                animationStrings.Add("\\");
                animationStrings.Add("|");
                animationStrings.Add("/");
                animationStrings.Add("-");
                animationStrings.Add("\\");

                int intro = 0;
                while (intro <= 7)
                {
                foreach (string s in animationStrings)
                {
                    Console.Write(s);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    intro++;
                }
                }
                Console.WriteLine("Consider the following prompt: ");
                Console.Write("\n--- ");
                Console.Write(newReflection.GetReflectionList());
                Console.WriteLine(" ---\n");
                string cont = "";
                Console.WriteLine("When you have something in mind, press enter to continue.");
                cont = Console.ReadLine();
                if (cont != "This")
                {
                    Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
                    Console.Write("You may begin in: ");
                        for (int i = 5; i > 0; i--)
                        {
                            Console.Write(i);
                            Thread.Sleep(1000);
                            Console.Write("\b \b");
                        }
                        DateTime startTime = DateTime.Now;
                        DateTime endTime = startTime.AddSeconds(time);
                        Console.Clear();
                        Console.Write(newReflection.GetReflectionQuestion());
                        while (DateTime.Now < endTime)
                        {
                            foreach (string s in animationStrings)
                            {
                                Console.Write(s);
                                Thread.Sleep(1000);
                                Console.Write("\b \b");
                            }
                        }
                        int well = 0; 
                        Console.WriteLine("\n\nWell done!!");
                        while (well <= 7)
                        {
                            foreach (string s in animationStrings)
                            {
                                Console.Write(s);
                                Thread.Sleep(1000);
                                Console.Write("\b \b");
                                well++;
                            }
                        }
                        int last = 0;
                        Console.WriteLine($"\nYou have completed another {originalTime} seconds of the Breathing Activity.");
                        while (last <= 7)
                        {
                            foreach (string s in animationStrings)
                            {
                                Console.Write(s);
                                Thread.Sleep(1000);
                                Console.Write("\b \b");
                                last++;
                            }
                        }
                }
            }
            else if (choice == "3")
            {
                Listing newListing = new Listing("Welcome to the Listing Activity\n", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
                Console.Clear();
                Console.WriteLine(newListing.GetWelcome());
                Console.WriteLine(newListing.GetDescription());
                Console.Write("How long, in 10 second increments, would you like for your session? ");
                time = int.Parse(Console.ReadLine());
                int originalTime = time;
                Console.Clear();
                Console.WriteLine("Get Ready...");
                List<string> animationStrings = new List<string>();
                animationStrings.Add("|");
                animationStrings.Add("/");
                animationStrings.Add("-");
                animationStrings.Add("\\");
                animationStrings.Add("|");
                animationStrings.Add("/");
                animationStrings.Add("-");
                animationStrings.Add("\\");

                int intro = 0;
                while (intro <= 7)
                {
                    foreach (string s in animationStrings)
                    {
                        Console.Write(s);
                        Thread.Sleep(1000);
                        Console.Write("\b \b");
                        intro++;
                    }
                }
                Console.WriteLine("\nList as many responses as you can to the following prompt: ");
                Console.Write("\n--- ");
                Console.Write(newListing.GetListingList());
                Console.WriteLine(" ---\n");
                Console.Write("You may begin in: ");
                for (int i = 5; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(originalTime);
                while (DateTime.Now < endTime)
                {
                Console.Write("\n> ");
                string answer = Console.ReadLine();
                newListing._listingAnswers = new List<string>();
                newListing._listingAnswers.Add(answer);
                }
                int list_count = newListing._listingAnswers.Count;
                Console.WriteLine("You listed " + list_count.ToString() + "items!");

            }

            static void DisplayMenu()
            {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            }
        }
    }
}
    
