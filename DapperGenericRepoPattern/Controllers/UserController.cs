using Microsoft.AspNetCore.Mvc;

namespace DapperGenericRepoPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<WeatherForecast>> Get()
        {
            
        }
    }
}
