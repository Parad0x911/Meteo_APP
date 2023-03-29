using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Meteo_APP.Models
{
    public class Meteo
    {
        [JsonPropertyName("coord")]
        public Coord Coordinates { get; set; }

        [JsonPropertyName("id")]
        public int Identification { get; set; }

        [JsonPropertyName("main")]
        public string Principale { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("icon")]
        public char Icon { get; set; }
    }
}
