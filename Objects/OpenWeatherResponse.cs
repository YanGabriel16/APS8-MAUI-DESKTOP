namespace APS8_MAUI_DESKTOP.Objects
{
    public class OpenWeatherResponse
    {
        public string Cod { get; set; } = string.Empty;
        public int Message { get; set; }
        public int Cnt { get; set; }
        public List<List>? List { get; set; }
        public City? City { get; set; }
    }
}