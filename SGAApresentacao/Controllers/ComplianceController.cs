using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SCA.Apresentacao.Controllers
{
    public class ComplianceController : Controller
    {
        // GET: Compliance
        public async Task<ActionResult> Index()
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var content = await client.GetStringAsync("http://192.168.1.127:10000/Conformidade/");

            ViewBag.listaConformidadeJson = JArray.Parse(content).ToString();

            return View();
        }

        // GET: Compliance/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Compliance/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Compliance/Create
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

        // GET: Compliance/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Compliance/Edit/5
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

        // GET: Compliance/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Compliance/Delete/5
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