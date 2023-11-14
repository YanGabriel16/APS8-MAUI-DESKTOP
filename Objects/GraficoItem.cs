namespace APS8_MAUI_DESKTOP.Objects
{
    public class GraficoItem
    {
        public string Nome { get; set; }
        public List<DataItem> Valor { get; set; }
        public string Cor { get; set; }

        public GraficoItem(string nome, string cor)
        {
            Nome = nome;
            Valor = new List<DataItem>();
            Cor = cor;
        }
    }

    public class DataItem
    {
        public string Date { get; set; }
        public double Value { get; set; }
        public DataItem(string date, double value)
        {
            Date = date;
            Value = value;
        }
    }
}
