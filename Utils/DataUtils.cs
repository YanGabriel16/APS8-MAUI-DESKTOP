using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS8_MAUI_DESKTOP.Utils
{
    public static class DataUtils
    {
        public static string FormatFrase(DateTime data) => data.ToString("d 'de' MMMM 'de' yyyy 'às' HH:mm");
    }
}
