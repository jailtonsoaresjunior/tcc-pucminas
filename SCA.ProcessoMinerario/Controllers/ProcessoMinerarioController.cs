using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SCA.ProcessoMinerario.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ProcessoMinerarioController : ControllerBase
    {
        // GET: api/ProcessoMinerario
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Processo 1", "Processo 2", "Processo 3", "Processo 4", "Processo 5", "Processo 6" };
        }

        // GET: api/ProcessoMinerario/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return $"Processo com parâmetro: {id}";
        }

        // POST: api/ProcessoMinerario
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ProcessoMinerario/5
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
