using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_ILG.Model
{

    public class JsonCity
    {
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
    }
}
