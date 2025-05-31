public class PromptGenerator
{
    public List<string> _prompts = new List<string> //List of prompts
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    public string GenerateRandomPrompt()
    {
        Random rand = new Random(); //new instance of the random prompt generator
        int randomNumber = rand.Next(_prompts.Count); // variable that stores a number which is the index range of the list
        return _prompts[randomNumber];

    }
}