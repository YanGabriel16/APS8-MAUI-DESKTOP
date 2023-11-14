namespace APS8_MAUI_DESKTOP.Utils
{
    using System;
    using System.Collections.Generic;

    public class DataUtils
    {
        public static List<string> ObterUltimos15DiasString()
        {
            List<string> ultimos15Dias = new();

            for (int i = 14; i >= 0; i--)
            {
                DateTime data = DateTime.Now.AddDays(-i);
                string dia = data.Day.ToString().PadLeft(2, '0');
                string mes = data.Month.ToString().PadLeft(2, '0');
                string dataFormatada = $"{dia}/{mes}";
                ultimos15Dias.Add(dataFormatada);
            }

            return ultimos15Dias;
        }

        public static List<DateTime> ObterUltimos15Dias()
        {
            List<DateTime> ultimos15Dias = new();

            for (int i = 14; i >= 0; i--)
            {
                DateTime data = DateTime.Now.AddDays(-i);
                ultimos15Dias.Add(data);
            }

            return ultimos15Dias;
        }

        public static string FormatarData(DateTime data)
        {
            return data.ToString("dd/MM/yyyy");
        }

        public static string FormatFrase(DateTime data) => data.ToString("d 'de' MMMM 'de' yyyy 'às' HH:mm");
        public static string FormatDiaMes(object value) => value != null ? Convert.ToDateTime(value).ToString("dd/MM") : string.Empty;
    }
}
