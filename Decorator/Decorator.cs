using Design_Patterns_Assignment;

using System;

namespace Design_Patterns_Assignment
{
    public class Decorator
    {
        HTMLGenerator htmlgenerator = new HTMLGenerator();

        public void Run()
        {
            // Refactor this code so that it uses the Decorator Pattern
            Console.WriteLine("Decorator");
            Console.WriteLine("Please enter the text.");
            string textInput = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Bold");
            Console.WriteLine("Deleted");
            Console.WriteLine("Emphasized");
            Console.WriteLine("Important");
            Console.WriteLine("Inserted");
            Console.WriteLine("Italic");
            Console.WriteLine("Marked");
            Console.WriteLine("Smaller");
            Console.WriteLine("SubScript");
            Console.WriteLine("SuperScript");
            Console.WriteLine();
            Console.WriteLine("Type the tags you want separated by space");

            string tagSelection = Console.ReadLine();
            string result = htmlgenerator.TagProcessor(tagSelection, textInput);
            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}