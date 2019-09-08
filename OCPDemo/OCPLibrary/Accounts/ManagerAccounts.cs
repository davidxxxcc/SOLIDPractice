using System;
namespace OCPLibrary
{
    public class ManagerAccounts : IAccounts
    {
        EmployeeModel IAccounts.Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1)}{ person.LastName}@acme.com";
            output.IsManager = true; 


            return output;
        }
    }
}
 