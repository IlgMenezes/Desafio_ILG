using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using SQLite;

namespace Desafio_ILG.Model
{
    /// <summary>
    /// Class of the City and Weather properties 
    /// </summary>
    public class City
    {
        /// <summary>
        /// Iternal id database
        /// </summary>
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        /// <summary>
        /// Id of City from Openweathermap json
        /// </summary>
        public int CityCode { get; set; }

        /// <summary>
        /// Name of City
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Description of weather condition on the city
        /// </summary>
        public String Condition { get; set; }

        /// <summary>
        /// City temperature
        /// </summary>
        public String Temperature { get; set; }

        /// <summary>
        /// Minimum temperature in the city
        /// </summary>
        public String MinTemperature { get; set; }

        /// <summary>
        /// Maximum temperature in the city
        /// </summary>
        public String MaxTemperature { get; set; }

        /// <summary>
        /// URI of icon from Openweathermap page 
        /// </summary>
        public String IconURI { get; set; }

        /// <summary>
        /// Time of the request moment of weather data
        /// Use to refresh by Contants parameter
        /// </summary>
        public DateTime TimeWeather { get; set; }
    }
}
