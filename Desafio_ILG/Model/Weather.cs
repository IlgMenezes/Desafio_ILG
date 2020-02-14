using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_ILG.Model
{
    /// <summary>
    /// Information of Weather condition codes.
    /// </summary>
    public class Weather
    {

        /// <summary>
        /// Description of weather condition on the city
        /// </summary>
        [JsonProperty("description")]
        public String Description { get; set; }

        /// <summary>
        /// Icon to ilustrate de description
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

    }
}
