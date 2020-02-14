using Desafio_ILG.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Desafio_ILG.Services
{
    public class LocalService
    {
        public List<String> GetJsonCityes()
        {
            JsonRootObject jsonRootObject;
            string jsonFileName = "city.list.json";
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");


            using (var reader = new System.IO.StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();
                jsonRootObject = JsonConvert.DeserializeObject<JsonRootObject>(jsonString);

            }
            return jsonRootObject.data.ConvertAll(x=>x.name);
        }
    }
}
