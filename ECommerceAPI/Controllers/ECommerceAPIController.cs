using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ECommerceAPIController : ControllerBase
    {
        // GET ECommerceAPI
        [HttpGet]
        public ActionResult<string> Get() => "Aplicação esta funcionando corretamente!";
    }
}