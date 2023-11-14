using APS8_MAUI_DESKTOP.Enums;

namespace APS8_MAUI_DESKTOP.Objects
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public Status Status { get; set; } = Status.Ativo;
        public DateTime DataCriado { get; set; } = DateTime.Now;
        public DateTime DataAtualizado { get; set; } = DateTime.Now;
    }
}
