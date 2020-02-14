using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_ILG.Model
{

    public class MainWeatherData
    {

        /// <summary>
        /// City temperature
        /// </summary>
        [JsonProperty("temp")]
        public Decimal Temperature { get; set; }

        /// <summary>
        /// Minimum temperature in the city
        /// </summary>
        [JsonProperty("temp_min")]
        public Decimal MinTemperature { get; set; }

        /// <summary>
        /// Maximum temperature in the city
        /// </summary>
        [JsonProperty("temp_max")]
        public Decimal MaxTemperature { get; set; }
    }
}
