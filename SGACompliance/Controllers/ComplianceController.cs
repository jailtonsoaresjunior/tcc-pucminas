using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SCA.Compliance.Negocio;
using System.Collections.Generic;

namespace SCA.Compliance.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ComplianceController : ControllerBase
    {
        // GET: api/Compliance
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new ComplianceNegocio().ObterLista();
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Compliance/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return $"Selecionado o registro (Compliance {id})";
        }

        // POST: api/Compliance
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Compliance/5
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
