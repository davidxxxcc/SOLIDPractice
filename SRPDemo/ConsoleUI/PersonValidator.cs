using System;
namespace ConsoleUI
{
    public class PersonValidator
    {
        public PersonValidator()
        {
        }

         public static bool Validate(Person person)
        {
            //Check to be sure the first and last name are valid
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessage.DisplayValidationError("first name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessage.DisplayValidationError("last name");

                return false;
            }

            return true;
        }
    }
}
