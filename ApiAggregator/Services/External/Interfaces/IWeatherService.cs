using ApiAggregatorService.Models;

namespace ApiAggregator.Services.External.Interfaces
{
	public interface IWeatherService
	{
		Task<WeatherResponse?> GetWeatherAsync(string city);
	}

}
