using System.Collections.Generic;
using System;

namespace SunCloud.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Biomet
    {
        public int Index;
        public string Condition;
    }

    public class Country
    {
        public int Id;
        public string Name;
    }

    public class Day
    {
        public string Source;
        public int TempMin;
        public int TempAvg;
        public int TempMax;
        public double WindSpeed;
        public double WindGust;
        public string WindDir;
        public int PressureMm;
        public int PressurePa;
        public int Humidity;
        public int SoilTemp;
        public double SoilMoisture;
        public int PrecMm;
        public int PrecProb;
        public int PrecPeriod;
        public double Cloudness;
        public int PrecType;
        public int PrecStrength;
        public string Icon;
        public string Condition;
        public int UvIndex;
        public int FeelsLike;
        public string Daytime;
        public bool Polar;
        public int FreshSnowMm;
    }

    public class DayShort
    {
        public string Source;
        public int Temp;
        public int TempMin;
        public double WindSpeed;
        public double WindGust;
        public string WindDir;
        public int PressureMm;
        public int PressurePa;
        public int Humidity;
        public int SoilTemp;
        public double SoilMoisture;
        public int PrecMm;
        public int PrecProb;
        public int PrecPeriod;
        public double Cloudness;
        public int PrecType;
        public int PrecStrength;
        public string Icon;
        public string Condition;
        public int UvIndex;
        public int FeelsLike;
        public string Daytime;
        public bool Polar;
        public int FreshSnowMm;
    }

    public class Evening
    {
        public string Source;
        public int TempMin;
        public int TempAvg;
        public int TempMax;
        public double WindSpeed;
        public double WindGust;
        public string WindDir;
        public int PressureMm;
        public int PressurePa;
        public int Humidity;
        public int SoilTemp;
        public double SoilMoisture;
        public int PrecMm;
        public int PrecProb;
        public int PrecPeriod;
        public double Cloudness;
        public int PrecType;
        public int PrecStrength;
        public string Icon;
        public string Condition;
        public int UvIndex;
        public int FeelsLike;
        public string Daytime;
        public bool Polar;
        public int FreshSnowMm;
    }

    public class Fact
    {
        public int ObsTime;
        public int Uptime;
        public int Temp;
        public int FeelsLike;
        public string Icon;
        public string Condition;
        public int Cloudness;
        public int PrecType;
        public int PrecProb;
        public int PrecStrength;
        public bool IsThunder;
        public double WindSpeed;
        public string WindDir;
        public int PressureMm;
        public int PressurePa;
        public int Humidity;
        public string Daytime;
        public bool Polar;
        public string Season;
        public string Source;
        public double SoilMoisture;
        public int SoilTemp;
        public int UvIndex;
        public double WindGust;
    }

    public class Forecast
    {
        public string Date;
        public int DateTs;
        public int Week;
        public string Sunrise;
        public string Sunset;
        public string RiseBegin;
        public string SetEnd;
        public int MoonCode;
        public string MoonText;
        public Parts Parts;
        public List<Hour> Hours;
        public Biomet Biomet;
    }

    public class GeoObject
    {
        public object District;
        public Locality Locality;
        public Province Province;
        public Country Country;
    }

    public class Hour
    {
        public string hour;
        public int HourTs;
        public int Temp;
        public int FeelsLike;
        public string Icon;
        public string Condition;
        public double Cloudness;
        public int PrecType;
        public double PrecStrength;
        public bool IsThunder;
        public string WindDir;
        public double WindSpeed;
        public double WindGust;
        public int PressureMm;
        public int PressurePa;
        public int Humidity;
        public int UvIndex;
        public int SoilTemp;
        public double SoilMoisture;
        public double PrecMm;
        public int PrecPeriod;
        public int PrecProb;

        public Hour(string hour)
        {
            this.hour = hour;
        }
    }

    public class Info
    {
        public bool N;
        public int Geoid;
        public string Url;
        public int Lat;
        public int Lon;
        public Tzinfo Tzinfo;
        public int DefPressureMm;
        public int DefPressurePa;
        public string Slug;
        public int Zoom;
        public bool Nr;
        public bool Ns;
        public bool Nsr;
        public bool P;
        public bool F;
        public bool H;
    }

    public class Locality
    {
        public int Id;
        public string Name;
    }

    public class Morning
    {
        public string Source;
        public int TempMin;
        public int TempAvg;
        public int TempMax;
        public double WindSpeed;
        public double WindGust;
        public string WindDir;
        public int PressureMm;
        public int PressurePa;
        public int Humidity;
        public int SoilTemp;
        public double SoilMoisture;
        public int PrecMm;
        public int PrecProb;
        public int PrecPeriod;
        public double Cloudness;
        public int PrecType;
        public int PrecStrength;
        public string Icon;
        public string Condition;
        public int UvIndex;
        public int FeelsLike;
        public string Daytime;
        public bool Polar;
        public int FreshSnowMm;
    }

    public class Night
    {
        public string Source;
        public int TempMin;
        public int TempAvg;
        public int TempMax;
        public double WindSpeed;
        public double WindGust;
        public string WindDir;
        public int PressureMm;
        public int PressurePa;
        public int Humidity;
        public int SoilTemp;
        public double SoilMoisture;
        public double PrecMm;
        public int PrecProb;
        public int PrecPeriod;
        public double Cloudness;
        public int PrecType;
        public double PrecStrength;
        public string Icon;
        public string Condition;
        public int UvIndex;
        public int FeelsLike;
        public string Daytime;
        public bool Polar;
        public int FreshSnowMm;
    }

    public class NightShort
    {
        public string Source;
        public int Temp;
        public double WindSpeed;
        public double WindGust;
        public string WindDir;
        public int PressureMm;
        public int PressurePa;
        public int Humidity;
        public int SoilTemp;
        public double SoilMoisture;
        public double PrecMm;
        public int PrecProb;
        public int PrecPeriod;
        public double Cloudness;
        public int PrecType;
        public double PrecStrength;
        public string Icon;
        public string Condition;
        public int UvIndex;
        public int FeelsLike;
        public string Daytime;
        public bool Polar;
        public int FreshSnowMm;
    }

    public class Parts
    {
        public Day Day;
        public Morning Morning;
        public Evening Evening;
        public NightShort NightShort;
        public DayShort DayShort;
        public Night Night;
    }

    public class Province
    {
        public int Id;
        public string Name;
    }

    public class Root
    {
        public int Now;
        public DateTime NowDt;
        public Info Info;
        public GeoObject GeoObject;
        public Yesterday Yesterday;
        public Fact Fact;
        public List<Forecast> Forecasts;
    }

    public class Tzinfo
    {
        public string Name;
        public string Abbr;
        public bool Dst;
        public int Offset;
    }

    public class Yesterday
    {
        public int Temp;
    }


}