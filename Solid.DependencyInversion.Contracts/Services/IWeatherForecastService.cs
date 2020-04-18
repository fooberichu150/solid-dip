using System;
using System.Collections.Generic;
using Solid.DependencyInversion.Contracts.Models;

namespace Solid.DependencyInversion.Contracts.Services
{
	public interface IWeatherForecastService
	{
		IEnumerable<IWeatherForecast> GetWeatherForecasts(int count = 5);
	}
}
