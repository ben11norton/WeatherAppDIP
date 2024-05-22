using WeatherAppDIP.Models;
namespace ServiceContract
{
    public interface IWeatherService
    {
        List<CityWeather> GetCityWeather();
    }
}
