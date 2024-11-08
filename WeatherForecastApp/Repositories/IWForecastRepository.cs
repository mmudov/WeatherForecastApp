using WeatherForecastApp.OpenWeatherMapModel;

namespace WeatherForecastApp.Repositories
{
	public interface IWForecastRepository
	{
		WeatherResponse GetForecast(string city);
	}
}
