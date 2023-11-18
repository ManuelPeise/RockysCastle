using Newtonsoft.Json;

namespace Logic.Weather.Models
{
    public class GeoLocations
    {
        public List<GeoLocationData> Results { get; set; } = new List<GeoLocationData>();
    }

    public class GeoLocationData
    {
        public string Name { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Country { get; set; } = string.Empty;
        [JsonProperty("country_code")]
        public string CountryCode { get; set; } = string.Empty;
        public string TimeZone { get; set; } = string.Empty;
    }
}
