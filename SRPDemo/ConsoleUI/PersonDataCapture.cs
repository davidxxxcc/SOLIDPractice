using System;
namespace ConsoleUI
{
    public class PersonDataCapture
    {
        public PersonDataCapture()
        {

        }

        public static Person Capture()
        {
            //Add for user information
            Person user = new Person();

            Console.Write("What is your first name: ");
            user.FirstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            user.LastName = Console.ReadLine();

            return user;
        }
    }
}
