using System;
namespace ConsoleUI
{
    public class AccountGenerator
    {
        public AccountGenerator()
        {
        }

        public static void CreateUserAccount(Person user)
        {
            //Create a username for the person
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");
        }
    }
}
