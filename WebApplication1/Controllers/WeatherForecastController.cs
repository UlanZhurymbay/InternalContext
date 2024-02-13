using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using tesdb.allaccess;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly BaseAccess repository;
        public WeatherForecastController(BaseAccess repository)
        {
            this.repository = repository;
        }

        [HttpGet(Name = "User")]
        public async Task<IActionResult> Get()
        {
            var result = repository.GetUserAccess();
            return Ok (await result.UpdateAsync());
        }

        [HttpGet("Other")]
        public async Task<IActionResult> GetAa()
        {
            var result = repository.GetOtherAccess();

            return Ok (await result.FirstAsync());
        }
    }
}