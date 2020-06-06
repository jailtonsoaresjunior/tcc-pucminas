using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SCA.InteligenciaNegocio.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class InteligenciaNegocioController : ControllerBase
    {
        // GET: api/InteligenciaNegocio
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Inteligência de Negócio 1", "Inteligência de Negócio 2", "Inteligência de Negócio 3", "Inteligência de Negócio 4", "Inteligência de Negócio 5", "Inteligência de Negócio 6" };
        }

        // GET: api/InteligenciaNegocio/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return $"Inteligência de Negócio com parâmetro {id}";
        }

        // POST: api/InteligenciaNegocio
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/InteligenciaNegocio/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
