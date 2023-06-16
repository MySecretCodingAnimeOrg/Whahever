public class YandexApiModel
{
    public class Biomet
    {
        public int? index;
        public string condition;
    }

    public class Country
    {
        public int? id;
        public string name;
    }

    public class Day
    {
        public string _source;
        public int? temp_min;
        public int? temp_avg;
        public int? temp_max;
        public double? wind_speed;
        public double? wind_gust;
        public string wind_dir;
        public int? pressure_mm;
        public int? pressure_pa;
        public int? humidity;
        public int? soil_temp;
        public double? soil_moisture;
        public int? prec_mm;
        public int? prec_prob;
        public int? prec_period;
        public double? cloudness;
        public int? prec_type;
        public int? prec_strength;
        public string icon;
        public string condition;
        public int? uv_index;
        public int? feels_like;
        public string daytime;
        public bool? polar;
        public int? fresh_snow_mm;
    }

    public class DayShort
    {
        public string _source;
        public int? temp;
        public int? temp_min;
        public double? wind_speed;
        public double? wind_gust;
        public string wind_dir;
        public int? pressure_mm;
        public int? pressure_pa;
        public int? humidity;
        public int? soil_temp;
        public double? soil_moisture;
        public int? prec_mm;
        public int? prec_prob;
        public int? prec_period;
        public double? cloudness;
        public int? prec_type;
        public int? prec_strength;
        public string icon;
        public string condition;
        public int? uv_index;
        public int? feels_like;
        public string daytime;
        public bool? polar;
        public int? fresh_snow_mm;
    }

    public class Evening
    {
        public string _source;
        public int? temp_min;
        public int? temp_avg;
        public int? temp_max;
        public double? wind_speed;
        public double? wind_gust;
        public string wind_dir;
        public int? pressure_mm;
        public int? pressure_pa;
        public int? humidity;
        public int? soil_temp;
        public double? soil_moisture;
        public int? prec_mm;
        public int? prec_prob;
        public int? prec_period;
        public double? cloudness;
        public int? prec_type;
        public int? prec_strength;
        public string icon;
        public string condition;
        public int? uv_index;
        public int? feels_like;
        public string daytime;
        public bool? polar;
        public int? fresh_snow_mm;
    }

    public class Fact
    {
        public int? obs_time;
        public int? uptime;
        public int? temp;
        public int? feels_like;
        public string icon;
        public string condition;
        public double? cloudness;
        public int? prec_type;
        public int? prec_prob;
        public int? prec_strength;
        public bool? is_thunder;
        public double? wind_speed;
        public string wind_dir;
        public int? pressure_mm;
        public int? pressure_pa;
        public int? humidity;
        public string daytime;
        public bool? polar;
        public string season;
        public string source;
        public double? soil_moisture;
        public int? soil_temp;
        public int? uv_index;
        public double? wind_gust;
    }

    public class Forecast
    {
        public string date;
        public int? date_ts;
        public int? week;
        public string sunrise;
        public string sunset;
        public string rise_begin;
        public string set_end;
        public int? moon_code;
        public string moon_text;
        public Parts parts;
        public List<Hour> hours;
        public Biomet biomet;
    }

    public class GeoObject
    {
        public object district;
        public Locality locality;
        public Province province;
        public Country country;
    }

    public class Hour
    {
        public string hour;
        public int? hour_ts;
        public int? temp;
        public int? feels_like;
        public string icon;
        public string condition;
        public double? cloudness;
        public int? prec_type;
        public int? prec_strength;
        public bool? is_thunder;
        public string wind_dir;
        public double? wind_speed;
        public double? wind_gust;
        public int? pressure_mm;
        public int? pressure_pa;
        public int? humidity;
        public int? uv_index;
        public int? soil_temp;
        public double? soil_moisture;
        public int? prec_mm;
        public int? prec_period;
        public int? prec_prob;
    }

    public class Info
    {
        public bool? n;
        public int? geoid;
        public string url;
        public int? lat;
        public int? lon;
        public Tzinfo tzinfo;
        public int? def_pressure_mm;
        public int? def_pressure_pa;
        public string slug;
        public int? zoom;
        public bool? nr;
        public bool? ns;
        public bool? nsr;
        public bool? p;
        public bool? f;
        public bool? _h;
    }

    public class Locality
    {
        public int? id;
        public string name;
    }

    public class Morning
    {
        public string _source;
        public int? temp_min;
        public int? temp_avg;
        public int? temp_max;
        public double? wind_speed;
        public double? wind_gust;
        public string wind_dir;
        public int? pressure_mm;
        public int? pressure_pa;
        public int? humidity;
        public int? soil_temp;
        public double? soil_moisture;
        public int? prec_mm;
        public int? prec_prob;
        public int? prec_period;
        public double? cloudness;
        public int? prec_type;
        public int? prec_strength;
        public string icon;
        public string condition;
        public int? uv_index;
        public int? feels_like;
        public string daytime;
        public bool? polar;
        public int? fresh_snow_mm;
    }

    public class Night
    {
        public string _source;
        public int? temp_min;
        public int? temp_avg;
        public int? temp_max;
        public double? wind_speed;
        public double? wind_gust;
        public string wind_dir;
        public int? pressure_mm;
        public int? pressure_pa;
        public int? humidity;
        public int? soil_temp;
        public double? soil_moisture;
        public int? prec_mm;
        public int? prec_prob;
        public int? prec_period;
        public double? cloudness;
        public int? prec_type;
        public int? prec_strength;
        public string icon;
        public string condition;
        public int? uv_index;
        public int? feels_like;
        public string daytime;
        public bool? polar;
        public int? fresh_snow_mm;
    }

    public class NightShort
    {
        public string _source;
        public int? temp;
        public double? wind_speed;
        public double? wind_gust;
        public string wind_dir;
        public int? pressure_mm;
        public int? pressure_pa;
        public int? humidity;
        public int? soil_temp;
        public double? soil_moisture;
        public int? prec_mm;
        public int? prec_prob;
        public int? prec_period;
        public double? cloudness;
        public int? prec_type;
        public int? prec_strength;
        public string icon;
        public string condition;
        public int? uv_index;
        public int? feels_like;
        public string daytime;
        public bool? polar;
        public int? fresh_snow_mm;
    }

    public class Parts
    {
        public DayShort day_short;
        public Morning morning;
        public Night night;
        public NightShort night_short;
        public Evening evening;
        public Day day;
    }

    public class Province
    {
        public int? id;
        public string name;
    }

    public class Model
    {
        public int? now;
        public DateTime? now_dt;
        public Info info;
        public GeoObject geo_object;
        public Yesterday yesterday;
        public Fact fact;
        public List<Forecast> forecasts;
    }

    public class Tzinfo
    {
        public string name;
        public string abbr;
        public bool? dst;
        public int? offset;
    }

    public class Yesterday
    {
        public int? temp;
    }
}
