namespace APS8_MAUI_DESKTOP.Objects
{
    public class GraficoItem
    {
        public string Nome { get; set; }
        public List<double> Valor { get; set; }
        public string Cor { get; set; }

        public GraficoItem(string nome, string cor)
        {
            Nome = nome;
            Valor = new List<double>();
            Cor = cor;
        }
    }
}
