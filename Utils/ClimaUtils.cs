using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS8_MAUI_DESKTOP.Utils
{
    public static class ClimaUtils
    {
        public static int? GetClimaGravidade(decimal status)
        {
            switch (status)
            {
                case 800:
                case 801:
                case 802:
                case 804:
                    return 1;

                case 200:
                case 230:
                case 231:
                case 300:
                case 301:
                case 302:
                case 310:
                case 311:
                case 312:
                case 313:
                case 314:
                case 321:
                case 500:
                case 501:
                case 803:
                    return 2;

                case 201:
                case 211:
                case 502:
                case 511:
                case 520:
                case 521:
                case 522:
                case 600:
                case 601:
                case 602:
                case 611:
                case 612:
                case 613:
                case 615:
                case 616:
                case 620:
                case 621:
                case 622:
                case 701:
                case 711:
                case 721:
                case 731:
                case 741:
                case 751:
                case 761:
                case 762:
                case 771:
                    return 3;

                case 202:
                case 212:
                case 221:
                case 232:
                case 503:
                case 504:
                case 531:
                case 781:
                    return 4;

                default:
                    return null;
            }
        }

        public static BadgeStyle GetClimaBadge(decimal status)
        {
            var tipo = GetClimaGravidade(status);
            switch (tipo)
            {
                case 1:
                    return BadgeStyle.Success;

                case 2:
                    return BadgeStyle.Info;

                case 3:
                    return BadgeStyle.Warning;

                case 4:
                    return BadgeStyle.Danger;

                default:
                    return BadgeStyle.Info;
            }
        }

        public static AlertStyle GetClimaAlert(decimal status)
        {
            var tipo = GetClimaGravidade(status);
            switch (tipo)
            {
                case 1:
                    return AlertStyle.Success;

                case 2:
                    return AlertStyle.Info;

                case 3:
                    return AlertStyle.Warning;

                case 4:
                    return AlertStyle.Danger;

                default:
                    return AlertStyle.Info;
            }
        }

        public static string GetUrlClimaIcone(string icone)
            => $"https://openweathermap.org/img/wn/{icone}@2x.png";
    }
}
