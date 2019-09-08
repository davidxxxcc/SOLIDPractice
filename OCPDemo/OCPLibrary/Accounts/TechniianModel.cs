using System;
namespace OCPLibrary.Accounts
{
    public class TechniianModel: IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new Accounts();
    }
}
