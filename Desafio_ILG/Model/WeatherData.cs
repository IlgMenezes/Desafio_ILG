using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_ILG.Model
{
    /// <summary>
    /// Class equipped with Json properties 
    /// </summary>
    public class WeatherData
    {
        WeatherData()
        {
            this.Main = new MainWeatherData();
            this.Weather = new List<Weather>();
        }

        /// <summary>
        /// Id of City
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Name of City of Weather
        /// </summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        /// <summary>
        /// More info Weather condition codes.(API Doc)
        /// Basic Informations of Weather
        /// </summary>
        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }

        [JsonProperty("main")]
        public MainWeatherData Main { get; set; }
    }
}
