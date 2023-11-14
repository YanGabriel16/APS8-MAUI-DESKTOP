namespace APS8_MAUI_DESKTOP.Objects.Request
{
    public class AdicionarLocalRequest
    {
        public string Nome { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }
}
