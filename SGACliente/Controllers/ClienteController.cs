using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using IdentityModel.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SGACliente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[ApiController]
    //[Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public async Task<string> Get()
        {
            var client = new HttpClient();
            
            var disco = await client.GetDiscoveryDocumentAsync("http://localhost:9000");
            if (disco.IsError)
            {

                return disco.Error;
            }

            //Obter token
            var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = disco.TokenEndpoint,

                ClientId = "client",
                ClientSecret = "secret",
                Scope = "api1"
            });

            if (tokenResponse.IsError)
            {
                return tokenResponse.Error;
            }
            return "Teste";
            //return tokenResponse.Json.ToString();
        }
        // GET: api/Cliente
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Cliente/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Cliente
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Cliente/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
