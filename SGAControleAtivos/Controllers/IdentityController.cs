using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using IdentityModel.Client;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SGAControleAtivos.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    [Route("identity")]
    //[Authorize]
    public class IdentityController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
            HttpClient httpClient = new HttpClient();
            var tokenResponse = await httpClient.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = "http://host.docker.internal:9000/connect/token",
                ClientId = "client",
                ClientSecret = "secret",
                Scope = "api1"
            });
            return Ok(tokenResponse.Json);

        }
    }
}