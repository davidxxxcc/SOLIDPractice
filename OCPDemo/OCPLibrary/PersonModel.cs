using System;
namespace OCPLibrary
{
    public class PersonModel
    {
        public PersonModel()
        {
        }
        public string FirstName {get; set;}

        public string LastName {get; set;}

        public EmployeeType TypeOfEmployee { get; set; } = EmployeeType.Staff;

    }
}
