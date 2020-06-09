using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace SCA.Apresentacao.Controllers
{
    public class SegurancaController : Controller
    {
        // GET: Seguranca
        public async Task<ActionResult> Index()
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var content = await client.GetStringAsync("http://host.docker.internal:10000/Seguranca/");

            ViewBag.listaSegurancaJson = JArray.Parse(content).ToString();

            return View();
        }

        // GET: Seguranca/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Seguranca/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Seguranca/Create
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

        // GET: Seguranca/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Seguranca/Edit/5
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

        // GET: Seguranca/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Seguranca/Delete/5
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