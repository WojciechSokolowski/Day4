using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace D03WeatherAppUI
{
    internal class WeatherManager
    {
        public int GetTemperature(string city)
        {

            WebClient webClient = new WebClient();

            string url = "https://www.google.com/search?q=weather+";
            string text = webClient.DownloadString(url + city);


            string pattern = "<div class=\"BNeawe iBp4i AP7Wnd\">(-{0,1}\\d{1,2}.{0,1}\\d{0,2}).C<\\/div>";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(text);

            string resoult = match.Groups[1].Value;


            //return int.Parse(resoult);

            return Convert.ToInt32(resoult);
        }
    }
}
