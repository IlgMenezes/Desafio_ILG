using Desafio_ILG.Model;
using Desafio_ILG.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_ILG.Controller
{
    public class WeatherController
    {
        /// <summary>
        /// class responsible for handling weather or Cities requests
        /// </summary>
        RestService _restService;
        LocalService _localService;

        internal async Task<City> Search(string cityName)
        {
            _restService = new RestService();
            City city = await _restService.GetCityDataAsync(GenerateRequestUri(Constants.OpenWeatherURI, cityName));
            return city;

        }

        internal async Task<bool> SaveCity(City city)
        {
            try
            {
                await App.Database.SaveCityAsync(city);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal async Task<List<City>> ListSavedCities()
        {
            List<City> cities = null;
            try
            {
                cities = await App.Database.GetCitiesAsync();
                cities = await RefreshWeatherData(cities);
                return cities;
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal List<String> LoadJsonCities()
        {
            _localService = new LocalService();
            List<String> cities = _localService.GetJsonCityes();
            return cities;
        }

        /// <summary>
        /// Refresh City wheather data when datetime request was exceeded Constants.LimitMinutesToRefresh.
        /// If 0 do not refresh.
        /// </summary>
        /// <param name="cities"></param>
        private async Task<List<City>> RefreshWeatherData(List<City> cities)
        {
            if (Constants.LimitMinutesToRefresh > 0)
            {
                foreach (City cityItem in cities)
                {
                    TimeSpan dif = DateTime.Now.Subtract(cityItem.TimeWeather);
                    if (dif.TotalMinutes > Constants.LimitMinutesToRefresh)
                    {
                        City tempCity = await this.Search(cityItem.Name);
                        cityItem.Temperature = tempCity.Temperature;
                        cityItem.Condition = tempCity.Condition;
                        cityItem.IconURI = tempCity.IconURI;
                        cityItem.MaxTemperature = tempCity.MaxTemperature;
                        cityItem.MinTemperature = tempCity.MinTemperature;
                    }
                }
            }
            return cities;
        }

        private string GenerateRequestUri(string endpoint, string cityName)
        {
            string requestUri = endpoint;
            requestUri += $"?q={cityName}";
            requestUri += "&units=metric";
            requestUri += "&lang=pt_br";
            requestUri += $"&APPID={Constants.OpenWeatherAPIKey}";
            return requestUri;
        }


    }
}
