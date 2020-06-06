using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SCA.Monitoramento.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class MonitoramentoController : ControllerBase
    {
        // GET: api/Monitoramento
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Monitoramento 1", "Monitoramento 2", "Monitoramento 3", "Monitoramento 4", "Monitoramento 5", "Monitoramento 6" };
        }

        // GET: api/Monitoramento/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return $"Monitoramento com parâmetro: {id}";
        }

        // POST: api/Monitoramento
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Monitoramento/5
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
