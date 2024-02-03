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

        static List<string> Countries = new List<string>()
        {
            "Costa Rica", "España", "Chile", "México", "Panamá"
        };

        public IEnumerable<string> Get()
        {
            return Countries;
        }

        public IEnumerable<string> Put([FromBody] Country Country)
        {
            Countries.Add(Country.name);
            return Countries;
        }

        public IEnumerable<string> Delete(Country Country)
        {
            Countries.RemoveAll((string c) => c.Equals(Country.name));
            return Countries;
        }
    }
}
