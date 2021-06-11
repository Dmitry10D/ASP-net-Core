using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private readonly WeatherForecast _holder;

        public WeatherForecastController(WeatherForecast holder)
        {
            _holder = holder;
        }

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }



        [HttpPost("create")]
        public IActionResult AddTemperature([FromQuery] DateTime date, [FromQuery] int Tc, [FromQuery] string sum)
        {
            _holder.Add(date, Tc, sum);
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult UpdateTemperature([FromQuery] DateTime date, [FromQuery] int Tc)
        {
            _holder.Update(date, Tc);
            return Ok();
        }

        [HttpPut("delete")]
        public IActionResult DeleteTemperature([FromQuery] DateTime date1, [FromQuery] DateTime date2)
        {
            _holder.Delete(date1, date2);
            return Ok();
        }

        [HttpGet("read")]
        public IActionResult ReadDates([FromQuery] DateTime date1, [FromQuery] DateTime date2)
        {
            _holder.database.FindAll(x => x.Date >= date1 && x.Date <= date2).ToString();
            return Ok();
        }
    }
}
