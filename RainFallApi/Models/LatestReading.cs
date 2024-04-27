﻿using Newtonsoft.Json;

namespace RainFallApi.Models
{
    public class LatestReading
    {
        [JsonProperty("@id")]
        public string? Id { get; set; }
        public string? Date { get; set; }
        public DateTime DateTime { get; set; }
        public string? Measure { get; set; }
        public double Value { get; set; }
    }
}
