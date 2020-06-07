using IdentityModel.Client;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace SCA.ControleAtivos.Controllers
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
                Address = "http://192.168.1.127:9000/connect/token",
                ClientId = "client",
                ClientSecret = "secret",
                Scope = "apiAtivos"
            });
            return Ok(tokenResponse.Json);

        }
    }
}