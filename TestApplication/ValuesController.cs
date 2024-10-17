using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using ServiceContracts.DTO;

namespace TestApplication
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ICountryServices CountryServices;

        public ValuesController(ICountryServices countryServices)
        {
            CountryServices = countryServices;
        }

        [HttpPost("add-country")]
        public IActionResult AddStudent(coutryAddRequest countryAddRequest)
        {
            var country = CountryServices.AddCountry(countryAddRequest);
            return Ok(country);
        }
    }
}
