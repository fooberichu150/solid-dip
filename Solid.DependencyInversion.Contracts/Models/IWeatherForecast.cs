using System;
using System.Collections.Generic;

namespace Solid.DependencyInversion.Contracts.Models
{
	public interface IWeatherForecast
	{
		DateTime Date { get; set; }

		int TemperatureC { get; set; }

		int TemperatureF { get; }

		string Summary { get; set; }
	}
}
