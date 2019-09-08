using System;
namespace ConsoleUI
{
    public class StandardMessage
    {
        public StandardMessage()
        {
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application!");
        }

        public static void EndMessage()
        {
            Console.WriteLine("Pess enter to close...");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid {fieldName}");

        }
    }
}
