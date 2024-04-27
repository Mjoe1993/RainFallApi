using Newtonsoft.Json;

namespace RainFallLibrary.Models
{
    public class Items
    {
        [JsonProperty("@id")]
        public string? Id { get; set; }
        public string? EaRegionName { get; set; }
        public int? Easting { get; set; }
        public string? GridReference { get; set; }
        public string? Label { get; set; }
        public double? Lat { get; set; }
        public double? @Long { get; set; }
        public List<Measure>? Measures { get; set; }
        public int Northing { get; set; }
        public string Notation { get; set; }
        public string? StationReference { get; set; }
        public string? Type { get; set; }
    }
}
