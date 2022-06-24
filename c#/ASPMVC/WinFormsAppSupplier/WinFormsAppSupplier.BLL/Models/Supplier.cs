
namespace BLL
{
    public class Supplier : IModel<int>
    {
        public Supplier() { }

        public Supplier(int id, string companyName, string? contactName, string? contactTitle, string? address, string? city, string? region, string? postalCode, string? country, string? phone, string? fax, string? homePage, int? countriesID)
        {
            Id = id;
            CompanyName = companyName;
            ContactName = contactName;
            ContactTitle = contactTitle;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
            Phone = phone;
            Fax = fax;
            HomePage = homePage;
            CountriesID = countriesID;
        }

        public Supplier(DAL.Supplier supplier)
        {
            Id = supplier.Id;
            CompanyName = supplier.CompanyName;
            ContactName = supplier.ContactName;
            ContactTitle = supplier.ContactTitle;
            Address = supplier.Address;
            City = supplier.City;
            Region = supplier.Region;
            PostalCode = supplier.PostalCode;
            Country = supplier.Country;
            Phone = supplier.Phone;
            Fax = supplier.Fax;
            HomePage = supplier.HomePage;
            CountriesID = supplier.CountriesID;
        }
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? HomePage { get; set; }
        public int? CountriesID { get; set; }
    }
}