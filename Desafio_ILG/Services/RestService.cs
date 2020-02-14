using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Diagnostics;
using Desafio_ILG.Model;

namespace Desafio_ILG.Services
{
    public class RestService
    {
        HttpClient _client;

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<City> GetCityDataAsync(string uri)
        {
            WeatherData weatherData = null;
            City city = null;
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    weatherData = JsonConvert.DeserializeObject<WeatherData>(content);

                    city = new City();
                    city.Name = weatherData.Name;
                    city.CityCode = weatherData.Id;
                    city.Condition = weatherData.Weather[0].Description;
                    city.Temperature = weatherData.Main.Temperature.ToString() + 'c';
                    city.MaxTemperature = weatherData.Main.MaxTemperature.ToString() + 'c';
                    city.MinTemperature = weatherData.Main.MinTemperature.ToString() + 'c';
                    city.IconURI = Constants.OpenWeatherIconURI + weatherData.Weather[0].Icon + "@2x.png";
                    city.TimeWeather = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }

            return city;
        }
    }
}
