using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SCA.Apresentacao.Data;
using SCA.Apresentacao.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SCA.Apresentacao.Controllers
{
    public class AtivosController : Controller
    {

        //private readonly SCA.Apresentacao.Data.SCAApresentacaoContext _context;

        //private readonly IAtivoInterface _ativoNegocio;
        //public AtivosController(IAtivoInterface ativoNegocio)
        //{
        //    _ativoNegocio = ativoNegocio;
        //}
        //public AtivosController(SCA.Apresentacao.Data.SCAApresentacaoContext context)
        //{
        //    _context = context;
        //}

        public async Task<IActionResult> Index()
       {
            var accessToken = await HttpContext.GetTokenAsync("access_token");

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var content = await client.GetStringAsync("http://host.docker.internal:10000/Ativos/");
            
            var model = JsonConvert.DeserializeObject<List<Ativo>>(content);
          
            ViewBag.listaAtivosJson = JArray.Parse(content).ToString();
            
            return View(model);
        }

        public ActionResult Novo()
        {
            return View("AtivoNovo");
        }
        [HttpPost]
        public async Task<IActionResult> Novo(Ativo ativo)
        {

            var accessToken = await HttpContext.GetTokenAsync("access_token");
            
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var content = JsonConvert.SerializeObject(ativo);
            var httpContent = new StringContent(content, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("http://host.docker.internal:10000/Ativos/", httpContent);
           
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Excluir(int id)
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var content = await client.DeleteAsync("http://host.docker.internal:10000/Ativos/" + id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> AtivoAtualizar(Ativo ativo)
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var content = JsonConvert.SerializeObject(ativo);
            var httpContent = new StringContent(content, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("http://host.docker.internal:10000/Ativos/", httpContent);
            return RedirectToAction("Index");
        }
    }
}