using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SCA.Ativos.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class AtivosController : ControllerBase
    {
        // GET: api/Ativos
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Ativo 1", "Ativo 2", "Ativo 3", "Ativo 4" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "WebApi (Controle Ativos) com valor " + id;
        }

        // POST: api/Ativos
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Ativos/5
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
