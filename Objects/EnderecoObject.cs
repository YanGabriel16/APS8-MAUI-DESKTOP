using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APS8_MAUI_DESKTOP.Objects
{
    public class EnderecoObject
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Ibge { get; set; }
        public string Gia { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}