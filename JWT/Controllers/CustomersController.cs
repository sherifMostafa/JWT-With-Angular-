using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors("EnableCORS")]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public async Task<IEnumerable<string>> Get() => new string[] { "Jon Doe", "John Doe" };
    }
}
