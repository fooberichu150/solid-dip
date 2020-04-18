using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solid.DependencyInversion.Contracts.Models;
using Solid.DependencyInversion.Contracts.Services;

namespace Solid.DependencyInversion.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private readonly ILogger<WeatherForecastController> _logger;
		private readonly IWeatherForecastService _weatherForecastService;

		public WeatherForecastController(ILogger<WeatherForecastController> logger,
			IWeatherForecastService weatherForecastService)
		{
			_logger = logger;
			_weatherForecastService = weatherForecastService;
		}

		[HttpGet]
		public IEnumerable<IWeatherForecast> Get([FromQuery]int count = 5)
		{
			_logger.LogTrace($"Request for {count} forecasts.");
			var forecasts = _weatherForecastService.GetWeatherForecasts(count);

			return forecasts;
		}
	}
}