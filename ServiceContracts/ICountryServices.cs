using ServiceContracts.DTO;

namespace ServiceContracts
{
    public interface ICountryServices
    {
        countryResponse AddCountry(coutryAddRequest? countryAddRequest);

    }
}
