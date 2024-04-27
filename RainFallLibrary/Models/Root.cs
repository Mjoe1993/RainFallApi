using Newtonsoft.Json;

namespace RainFallLibrary.Models
{
    public class Root
    {
        [JsonProperty("@context")]
        public string? Context { get; set; }
        public Meta? Meta { get; set; }
        public Items? Items { get; set; }
    }
}
