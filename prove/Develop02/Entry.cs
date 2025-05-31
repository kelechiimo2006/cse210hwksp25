using System.Net;

public class Entry
{
    public int _entryNumber;
    public static int _nextEntryNumber = 1;
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayEntry()
    {
        Console.WriteLine($"Entry Number: {_entryNumber} \nDate: {_date} - Prompt: {_prompt} \n{_response}"); // displays the date, prompt and response of given entry
    }
}