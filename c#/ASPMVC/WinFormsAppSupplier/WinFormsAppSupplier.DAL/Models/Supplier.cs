using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL
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