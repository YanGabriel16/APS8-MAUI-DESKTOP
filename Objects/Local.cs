namespace APS8_MAUI_DESKTOP.Objects
{
    public class Local : BaseEntity
    {
       
        public string Nome { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public List<LocalDadosObject> Dados { get; set; } = new();
    }
}