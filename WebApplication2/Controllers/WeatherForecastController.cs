using Microsoft.AspNetCore.Mvc;
using WebApplication1;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRepository<User> _userRepository;

        public WeatherForecastController(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("User")]
        public async Task<IActionResult> Get22()
        {

            return Ok(await _userRepository.GetUserAsync());
        }
    }
}