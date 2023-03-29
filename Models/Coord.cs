using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Meteo_APP.Models
{
    public class Coord
    {
        [JsonPropertyName("lat")]
        public float Latitude { get; set; }
        [JsonPropertyName("lon")]
        public float Longitude { get; set; }
    }
}
