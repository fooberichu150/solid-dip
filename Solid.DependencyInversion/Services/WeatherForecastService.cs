using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Solid.DependencyInversion.DTO;

namespace Solid.DependencyInversion.Services
{
	public class WeatherForecastService
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		private readonly List<WeatherForecast> _weatherForecasts;

		public WeatherForecastService()
		{
			var rng = new Random();

			_weatherForecasts = Enumerable.Range(1, 5)
				.Select(index => new WeatherForecast
				{
					Date = DateTime.Today.AddDays(index),
					TemperatureC = rng.Next(-20, 55),
					Summary = Summaries[rng.Next(Summaries.Length)]
				})
				.ToList();
		}

		public IEnumerable<WeatherForecast> GetWeatherForecasts(int count = 5)
		{
			return _weatherForecasts
				.Take(count)
				.ToArray();
		}
	}
}