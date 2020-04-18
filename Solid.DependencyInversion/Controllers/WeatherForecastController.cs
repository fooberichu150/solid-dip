using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solid.DependencyInversion.DTO;
using Solid.DependencyInversion.Services;

namespace Solid.DependencyInversion.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private readonly ILogger<WeatherForecastController> _logger;
		private readonly WeatherForecastService _weatherForecastService;

		public WeatherForecastController(ILogger<WeatherForecastController> logger,
			WeatherForecastService weatherForecastService)
		{
			_logger = logger;
			_weatherForecastService = weatherForecastService;
		}

		[HttpGet]
		public IEnumerable<WeatherForecast> Get([FromQuery]int count = 5)
		{
			_logger.LogTrace($"Request for {count} forecasts.");
			var forecasts = _weatherForecastService.GetWeatherForecasts(count);

			return forecasts;
		}
	}
}
