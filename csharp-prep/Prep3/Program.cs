using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guess = -1;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
        }
        Console.WriteLine("Congrats You Guessed It");
    }
}