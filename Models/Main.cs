using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Meteo_APP.Models
{
    public class Main
    {
        [JsonPropertyName("coord")]
        public Coord Coordinates { get; set; }

        [JsonPropertyName("temp")]
        public float Temp { get; set; }

        [JsonPropertyName("feels_like")]
        public float Feels_Like { get; set; }

        [JsonPropertyName("temp_min")]
        public float Temp_Min { get; set; }

        [JsonPropertyName("temp_max")]
        public float Temp_Max { get; set; }

        [JsonPropertyName("pressure")]
        public int Pressure { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

        [JsonPropertyName("sea_level")]
        public int Sea_Level { get; set; }

        [JsonPropertyName("grnd_level")]
        public int Grnd_Level { get; set; }
    }


}
