namespace FurnitureManufacturer.Engine.Factories
{
    using Interfaces;
    using Interfaces.Engine;
    using Models;

    public class CompanyFactory : ICompanyFactory
    {
        public ICompany CreateCompany(string name, string registrationNumber)
        {
            // TODO: Implement this method
            Company company = new Company();
            company.Name = name;
            company.RegistrationNumber = registrationNumber;
            
            return company;
            
        }
    }
}
