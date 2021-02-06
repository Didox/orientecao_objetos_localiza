using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreApi.Business.Interfaces;
using NetCoreApi.Database.Models;

namespace NetCoreApi.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IBaseService<WeatherForecast> _weatherForecastService;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IBaseService<WeatherForecast> weatherForecastService
        )
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> List()
        {
            return _weatherForecastService.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<WeatherForecast> Find(int id)
        {
            var weatherForecasts = _weatherForecastService
                .Filter(weatherForecast => weatherForecast.Id == id);

            if (!weatherForecasts.Any()) return NotFound();

            return weatherForecasts.First();
        }

        [HttpPost]
        public ActionResult<WeatherForecast> Save(WeatherForecast weatherForecast)
        {
            _weatherForecastService.Create(weatherForecast);
            return CreatedAtAction(nameof(Find), new { id = weatherForecast.Id }, weatherForecast);
        }

        [HttpPut("{id}")]
        public ActionResult<WeatherForecast> Update(int id, WeatherForecast weatherForecast)
        {
            if (id != weatherForecast.Id) return BadRequest("Path id and model id are different");

            _weatherForecastService.Update(weatherForecast);
            return _weatherForecastService
                .Filter(weatherForecast => weatherForecast.Id == id)
                .First();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var weatherForecast = _weatherForecastService
                .Filter(weatherForecast => weatherForecast.Id == id)
                .First();
            _weatherForecastService.Delete(weatherForecast);
            return NoContent();
        }
    }
}
