using System;
using System.Runtime.CompilerServices;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu(); //new instance of the Menu class
        Journal journal = new Journal(); //new instance of the journal class
        int choice = -1; //variable called choice initualized to value that won't cause conflicts
        //menu.DisplayMenu();
        

         
        while (choice != 5)
        {
            menu.DisplayMenu(); //call to the display method of the menu class
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine()); //reads the user's input and converts it into an int and stores it.
            switch (choice) //switch to allow for operations based on the users input
            {
                case 1:
                    {
                        journal.AddNewEntry();//call to the AddNewEntry method of the journal class
                        break;
                    }
                case 2:
                    {
                        journal.Display();//call to the Display method of the journal class
                        break;
                    }
                case 4:
                    {
                        journal.Save();//call to the Save method of the journal class
                        break;
                    }
                case 3:
                    {
                        journal.Load();//call to the Load method of the journal class
                        break;
                    }

            }

        }
        

    
    }
}