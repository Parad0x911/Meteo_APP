using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Meteo_APP.Models
{
    public class ListView
    {
        internal static object SelectedItem;

        public string Name { get; set; }

        [JsonPropertyName("country")]
        public string CountryCode { get; set; }

        [JsonPropertyName("lat")]
        public float Lattitude { get; set; }

        [JsonPropertyName("lon")]
        public float Longitude { get; set; }

        [JsonPropertyName("time")]
        public float Timezone { get; set; }

        [JsonPropertyName("temp")]
        public float Temperature { get; set; }
    }


}
