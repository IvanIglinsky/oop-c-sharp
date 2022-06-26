using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace ClassLibraryWinFormLab7
{
    public class Weather
    {
  
        public string Temperature {private set; get; }
        public string Wind { private set; get; }
        public string WhatsWind { private set; get; }
        public string Humidity { private set; get; }
        public string WatherTemperature { private set; get; }
        public string AllWather { private set; get; }
        public string Image { private set; get; }

        private static string HTML()
        {
            WebClient web = new WebClient();
            web.Encoding = Encoding.UTF8;
            string html = web.DownloadString("https://www.gismeteo.ua/ua/weather-zhytomyr-4943/now/");
            return html;
        }
        public string Temperatures()
        {
            string html = HTML();
            Regex reg = new Regex("<span class=\"unit unit_temperature_c\"><span class=\"sign\">(\\S)<\\/span>(\\d+)<span class=\"lower\">(\\S\\d+)<\\/span> <\\/span>", RegexOptions.Compiled);
            Match m = reg.Match(html);
            if (m.Success)
            {
                Temperature = m.Groups[1].Value+ m.Groups[2].Value+ m.Groups[3].Value;
            }
            return Temperature;
        }
        public string Winds()
        {
            string html = HTML();
            Regex reg = new Regex("<div class=\"unit unit_wind_m_s\">(\\d+)<", RegexOptions.Compiled);
            Match m = reg.Match(html);
            if (m.Success)
            {
                Wind = m.Groups[1].Value;
            }
            return Wind;
        }
        public string WhatWinds()
        {
             string html = HTML();
             Regex reg = new Regex("<div class=\"unit unit_wind_m_s\">\\d+<div class=\"item-measure\"><div>м/c</div><div>(\\S+)</div></div></div><div", RegexOptions.Compiled);
             Match m = reg.Match(html);
            if (m.Success)
            {
                WhatsWind = m.Groups[1].Value;
            }
            return WhatsWind;
        }
        public string Humiditys()
        {
            string html = HTML();
            Regex reg = new Regex("<div class=\"now-info-item humidity\"><div class=\"item-title\">Вологість<\\/div><div class=\"item-value\">(\\d+)<\\/div><div class=\"item-measure\">(\\S)<\\/div><\\/div>", RegexOptions.Compiled);
            Match m = reg.Match(html);
            if (m.Success)
            {
                Humidity = m.Groups[1].Value + m.Groups[2].Value;
            }
            return Humidity;
        }
        public string WatherTemperatures()
        {
            string html = HTML();
            Regex reg = new Regex("<div class=\"now-info-item water\"><div class=\"item-title\">Вода<\\/div><div class=\"item-value\"><div class=\"unit unit_temperature_c\">(\\S\\d+\\S\\d+)", RegexOptions.Compiled);
            Match m = reg.Match(html);
            if (m.Success)
            {
                WatherTemperature = m.Groups[1].Value ;
            }
            return WatherTemperature;
        }
        public string AllWathers()
        {
            string html = HTML();
            Regex reg = new Regex("<div class=\"now-desc\">([А-Яа-яёЁЇїІіЄєҐґ]+\\s[А-Яа-яёЁЇїІіЄєҐґ]+)|<div class=\"now-desc\">([А-Яа-яёЁЇїІіЄєҐґ]+)", RegexOptions.Compiled);
            Match m = reg.Match(html);
            if (m.Success)
            {   AllWather=m.Groups[1].Value ;
                AllWather+= m.Groups[2].Value;
            }
            return AllWather;
        }
       public string Imgs()
        {
            string html = HTML();
            Regex regImage = new Regex("div class=\"now\" style=\"background-image: url\\('https://(\\S{37})");
            Match mImage = regImage.Match(html);
            if (mImage.Success)
                Image= "http://" + mImage.Groups[1].Value;
          return Image;
        }
    }
}
