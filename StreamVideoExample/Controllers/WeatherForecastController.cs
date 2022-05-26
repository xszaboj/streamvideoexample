using Microsoft.AspNetCore.Mvc;

namespace StreamVideoExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        

        [HttpGet(Name = "Download")]
        public async Task<FileStreamResult> Download()
        {
            var stream = System.IO.File.OpenRead(@"c:\Users\Me\Downloads\Videa\Videa\validation.mp4");
            return new FileStreamResult(stream, "application/octet-stream");
        }
    }
}