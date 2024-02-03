using AdopcionesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AdopcionesAPI.Controllers
{
    public class TipoAnimalController : ApiController
    {

        static List<string> TiposAnimal = new List<string>()
        {
            "Perro", "Gato", "Conejo", "Hamster", "Perico"
        };

        public IEnumerable<string> Get()
        {
            return TiposAnimal;
        }

        public IEnumerable<string> Put([FromBody] TipoAnimal TipoAnimal)
        {
            TiposAnimal.Add(TipoAnimal.name);
            return TiposAnimal;
        }

        public IEnumerable<string> Delete(TipoAnimal TipoAnimal)
        {
            TiposAnimal.RemoveAll((string c) => c.Equals(TipoAnimal.name));
            return TiposAnimal;
        }
    }
}
