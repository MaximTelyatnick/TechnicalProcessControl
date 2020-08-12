using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TerminalMKAspNetBot.Models
{
    public static class AppSettings
    {
        //public static string Url { get; set; }  = "https://telegrambotapp.azurewebsites.net:443/{0}";
        public static string Url { get; set; } = "https://localhost:8443";
        public static string Name { get; set; } = "extremecode_bot";

        public static string Key { get; set; }  = "810022910:AAGV0ExezK5z4Hn3C6Z6aE-cjn5g5FHwyBY";

    }
}