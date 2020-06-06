using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SCA.Apresentacao.Controllers
{
    public class InteligenciaNegocioController : Controller
    {
        // GET: InteligenciaNegocio
        public async  Task<ActionResult> Index()
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var content = await client.GetStringAsync("http://192.168.1.102:10000/InteligenciaNegocio/");

            ViewBag.listaInteligenciaNegocioJson = JArray.Parse(content).ToString();

            return View();
        }

        // GET: InteligenciaNegocio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InteligenciaNegocio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InteligenciaNegocio/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InteligenciaNegocio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InteligenciaNegocio/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InteligenciaNegocio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InteligenciaNegocio/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}