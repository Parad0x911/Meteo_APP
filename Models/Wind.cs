using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Meteo_APP.Models
{
    internal class Wind
    {
        [JsonPropertyName("coord")]
        public Coord Coordinates { get; set; }

        [JsonPropertyName("speed")]
        public float Vitesse { get; set; }

        [JsonPropertyName("deg")]
        public int Degrees { get; set; }

        [JsonPropertyName("gust")]
        public float Rafale { get; set; }

    }
}
