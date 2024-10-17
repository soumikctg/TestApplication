using Entities;

namespace ServiceContracts.DTO
{
    public class coutryAddRequest
    {
        public string? CountryName { get; set; }

        public country ToCountry()
        {
            /*return new country()
            {
                CountryID = new Guid(),
                CountryName = CountryName
            };*/

            return new country() { CountryName = CountryName };
        }
    }
}
