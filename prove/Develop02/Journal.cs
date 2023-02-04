using System.IO;

public class Journal
{
    List<Entry> entries = new List<Entry>();

    public bool DisplayJournal()
    {
        //get the current date 
        DateTime currentTime = DateTime.Now;
        string dateText = currentTime.ToLongDateString();

//Provide a menu that allows the user choose these options
        int userSelection;
        Console.WriteLine("Welcome to my Journal");
        Console.WriteLine("Please select one of the following: ");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("Enter your selection:");
        userSelection = int.Parse(Console.ReadLine());

        Prompts promptsList = new Prompts();

        if (userSelection == 1)
        {
            // Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
            Random rdm = new Random();
            int rdmNumber = rdm.Next(promptsList.prompts.Count());

            // prints prompts
            System.Console.WriteLine(promptsList.prompts[rdmNumber]);
            System.Console.Write("> ");
            string textEntry = Console.ReadLine();

            Entry entry = new Entry(promptsList.prompts[rdmNumber], textEntry);
            entries.Add(entry);
        }

        else if (userSelection == 2)
        {
            foreach (var line in entries)
            {
                line.DisplayEntry();
            }
        }
            //Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.
        else if (userSelection == 3)
        {
            Console.WriteLine("Enter a filename?");
            var filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);
            
            foreach (var line in lines)
            {
                string[] format = line.Split("@");
                string date = format[0];
                string prompt = format[1];
                string text = format[2];

                System.Console.WriteLine($"Date: {date} - Prompt: {prompt}");
                System.Console.WriteLine(text);
                System.Console.WriteLine();
            }
        }

        //Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location
        else if (userSelection == 4)
        {
            System.Console.WriteLine("What is the filename? ");
            var filename = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    var format = $"{entry.date}@{entry.prompt}@{entry.response}";
                    outputFile.WriteLine(format);
                }
            }
        }

        return userSelection != 5;

    }
}