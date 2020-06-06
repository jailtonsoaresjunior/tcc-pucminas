using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SCA.Seguranca.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class SegurancaController : ControllerBase
    {
        // GET: api/Seguranca
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Api Segurança" };
        }

        // GET: api/Seguranca/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return $"Api Segurança recebendo parâmetro: {id}";
        }

        // POST: api/Seguranca
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Seguranca/5
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
