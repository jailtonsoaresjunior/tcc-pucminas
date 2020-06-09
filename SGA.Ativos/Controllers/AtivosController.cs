using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SCA.Ativos.Modelo;
using SCA.Ativos.Modelo.Interface;
using SCA.Ativos.Negocio;
using System.Collections.Generic;
using System.Linq;

namespace SCA.Ativos.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class AtivosController : ControllerBase
    {
        private IAtivoInterface _ativoRegraNegocio = new AtivoRegraNegocio();
        // GET: api/Ativos
        [HttpGet]
        public ActionResult<List<Ativo>> Get()
        {
            //return new string[] { "Ativo 1", "Ativo 2", "Ativo 3", "Ativo 4" };
            return _ativoRegraNegocio.ObterLista();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "WebApi (Controle Ativos) com valor " + id;
        }

        // POST: api/Ativos
        [HttpPost]
        public void Post([FromBody] Ativo value)
        {
             _ativoRegraNegocio.Inserir(value);
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
            _ativoRegraNegocio.Excluir(id);
        }
    }
}
