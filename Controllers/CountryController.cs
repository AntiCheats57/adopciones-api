using AdopcionesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AdopcionesAPI.Controllers
{
    public class CountryController : ApiController
    {
        /*static List<Country> countries = new List<Country> {
            new Country("Costa Rica"),
            new Country("España"),
            new Country("México"),
            new Country("Panamá"),
        };

        public IEnumerable<Country> Get()
        {
            return countries;
        }

        public IEnumerable<Country> Put([From] Country country)
        {
            countries.Add(new Country(country.name));
            return countries;
        }

        public IEnumerable<Country> Delete([FromBody] Country country)
        {
            countries.RemoveAll((Country c) => c.name.Equals(country.name));
            return countries;
        }*/

        static List<string> countries = new List<string>()
        {
            "Costa Rica", "España", "Chile", "México", "Panamá"
        };

        public IEnumerable<string> Get()
        {
            return countries;
        }

        public IEnumerable<string> Put([FromBody] Country country)
        {
            countries.Add(country.name);
            return countries;
        }

        public IEnumerable<string> Delete(Country country)
        {
            countries.RemoveAll((string c) => c.Equals(country.name));
            return countries;
        }
    }
}
