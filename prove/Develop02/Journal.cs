using System.CodeDom.Compiler;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();//List to store Entry objects.


    public void AddNewEntry()
    {
        
        PromptGenerator randomPrompt = new PromptGenerator(); //creates new instance of the prompt generator class
        Entry newEntry = new Entry();//creates new instance of the entry class

        newEntry._entryNumber = Entry._nextEntryNumber++;
        Console.WriteLine($"Entry Number: {newEntry._entryNumber}");

        string prompt = randomPrompt.GenerateRandomPrompt(); //creates a variable named prompt and stores the returned string from the random generator
        newEntry._prompt = prompt; //sets the  prompt member variable of the newEntry equal to the returned prompt from the prompt generator
        Console.WriteLine(prompt);

        Console.WriteLine("");

        Console.Write("> ");
        string response = Console.ReadLine();
        newEntry._response = response;

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        newEntry._date = dateText;

        _entries.Add(newEntry);
    }
    
    public void Display()
    {
        Console.WriteLine("Entries: ");
        Console.WriteLine("=====================");

        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry(); //iterates through the List of prompts and calls the entry display method on each element in the list
            Console.WriteLine("");
        }
        
        Console.WriteLine("=====================");
    }
    
    public void Save()
    {
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileName)) // creates new instance of the StreamWriter class and takes in the filename.
        {
            foreach (Entry entry in _entries)
            {
                string storedEntry = $"Entry Number: {entry._entryNumber} \nDate: {entry._date} - Prompt: {entry._prompt} \n{entry._response}";
                outputFile.WriteLine(storedEntry);// writes the string to the outputFile.
                outputFile.WriteLine("");        
            }
        }
    }

    public void Load()
    {
        Console.Write("What is the file name? \n");
        string fileName = Console.ReadLine();
        string[] lines =  System.IO.File.ReadAllLines(fileName); //creates an array called lines that can hold strings that it reads from the files
        
        foreach (string line in lines)
        {
            string[] parts = line.Split(','); //creates an array called parts that stores the elements in the array after it has been split 
            
            foreach (string part in parts)
            {
            Console.WriteLine(part); //displays each element in the array
            }
        }
    }
}

