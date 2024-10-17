using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts.DTO
{
    public class countryResponse
    {
        public Guid CountryID { get; set; }
        public string? CountryName { get; set; }
    }

    public static class CountryExtensions
    {
        public static countryResponse ToCountryResponse(this country country)
        {
            return new countryResponse() { CountryID = country.CountryID, CountryName = country.CountryName };
        }
    }
}
