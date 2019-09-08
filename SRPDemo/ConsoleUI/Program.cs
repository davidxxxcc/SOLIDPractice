using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessage.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if (isUserValid == false)
            {
                StandardMessage.EndMessage();
                return;
            }
            AccountGenerator.CreateUserAccount(user);
            StandardMessage.EndMessage();
        }
    }
}