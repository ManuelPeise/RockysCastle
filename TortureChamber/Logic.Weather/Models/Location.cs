namespace Logic.Weather.Models
{
    public class Location
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Country { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;
        public string TimeZone { get; set; } = string.Empty;
    }
}
