using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Meteo_APP.Models
{
    internal class Clouds
    {
        [JsonPropertyName("coord")]
        public Coord Coordinates { get; set; }

        [JsonPropertyName("All")]
        public int ALL { get; set; }
    }
}
