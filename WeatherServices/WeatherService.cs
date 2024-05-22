using WeatherAppDIP.Models;
using ServiceContract;
namespace WeatherServices
{
    public class WeatherService : IWeatherService
    {
        private List<CityWeather> _cityWeather;

        public WeatherService()
        {
            _cityWeather = new List<CityWeather>()
            {
                new CityWeather()
                {
                    CityUniqueCode = "LDN", 
                    CityName = "London",
                    DateAndTime = Convert.ToDateTime("2030-01-01 8:00"),  
                    TemperatureFahrenheit = 33
                },
                new CityWeather()
                {
                    CityUniqueCode = "NYC", 
                    CityName = "New York",
                    DateAndTime = Convert.ToDateTime("2030-01-01 3:00"),  
                    TemperatureFahrenheit = 60
                },
                new CityWeather()
                {
                    CityUniqueCode = "PAR", 
                    CityName = "Paris", 
                    DateAndTime = Convert.ToDateTime("2030-01-01 9:00"),  
                    TemperatureFahrenheit = 82
                }
            };
        }


        public List<CityWeather> GetCityWeather()
        {
            return _cityWeather;
        }

        // add method for cityCode
        public CityWeather? GetCityCode(string CityCode)
        {
            CityWeather? city = _cityWeather.FirstOrDefault(temp => temp.CityUniqueCode == CityCode);
            return city;
        }
    }
}
