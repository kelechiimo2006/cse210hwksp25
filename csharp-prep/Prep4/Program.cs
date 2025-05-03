using System;
using System.ComponentModel.Design.Serialization;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        
        }while (number != 0);
        Console.WriteLine($"The sum is {numbers.Sum()}");
        Console.WriteLine($"The average is {numbers.Average()}");
        Console.WriteLine($"The largest number is {numbers.Max()}");
        
    }
    
}