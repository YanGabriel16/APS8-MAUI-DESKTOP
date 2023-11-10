namespace APS8_MAUI_DESKTOP.Objects
{
    public class AirQualityResponse
    {
        public DateTime DateTime { get; set; }
        public string RegionCode { get; set; } = string.Empty;
        public List<Index> Indexes { get; set; } = new();
        public List<Pollutant> Pollutants { get; set; } = new();
        public HealthRecommendations HealthRecommendations { get; set; } = new();
    }
}