using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGA.Compliance.Interface;
using SGA.Compliance.Negocio;

namespace SGACompliance.Controllers
{
    //[Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class TesteController : ControllerBase, ICompliance
    {
        // GET: api/Teste
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //   return new ComplianceNegocio().ObterLista();
        //    //return new string[] { "Compliance1", "Compliance2", "Compliance3" };
        //}

        // GET: api/Teste/5
        [Route("api/Teste/Selecionar/{id}")]
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return $"Selecionado o registro (Compliance {id})";
        }

        // POST: api/Teste
        [Route("api/Teste/Inserir")]
        [HttpPost]
        public void Inserir([FromBody] string value)
        {
        }

        // PUT: api/Teste/5
        [Route("api/Teste/Atualizar/{id}")]
        [HttpPut("{id}")]
        public void Atualizar(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [Route("api/Teste/Excluir/{id}")]
        [HttpDelete("{id}")]
        public void Excluir(int id)
        {
        }

        [Route("api/Teste/ObterLista")]
        [HttpGet]
        public List<string> ObterLista()
        {
            return new ComplianceNegocio().ObterLista();
        }
    }
}
