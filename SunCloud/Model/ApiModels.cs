using System;
using System.Collections.Generic;

namespace SunCloud.Model
{

    ///<summary>
    ///�����, ���������� ������ � ������ �� API �������
    ///</summary>
    public class YandexApiModel
    {
        ///<summary>
        ///�����, ���������� ������ � �������������� �����������
        ///</summary>
        public class Biomet
        {
            ///<summary>
            ///������ ��������������� ����������
            ///</summary>
            public int? index;

            ///<summary>
            ///��������� ��������������� ����������
            ///</summary>
            public string condition;
        }

        ///<summary>
        ///�����, ���������� ������ � ������
        ///</summary>
        public class Country
        {
            ///<summary>
            ///������������� ������
            ///</summary>
            public int? id;

            ///<summary>
            ///�������� ������
            ///</summary>
            public string name;
        }

        ///<summary>
        ///�����, ���������� ������ � ������ �� ������������ ����
        ///</summary>
        public class Day
        {
            ///<summary>
            ///�������� ������
            ///</summary>
            public string _source;

            ///<summary>
            ///����������� ����������� �������
            ///</summary>
            public int? temp_min;

            ///<summary>
            ///������� ����������� �������
            ///</summary>
            public int? temp_avg;

            ///<summary>
            ///������������ ����������� �������
            ///</summary>
            public int? temp_max;

            ///<summary>
            ///�������� �����
            ///</summary>
            public double? wind_speed;

            ///<summary>
            ///������ �����
            ///</summary>
            public double? wind_gust;

            ///<summary>
            ///����������� �����
            ///</summary>
            public string wind_dir;

            ///<summary>
            ///����������� �������� � �� ��. ��.
            ///</summary>
            public int? pressure_mm;

            ///<summary>
            ///����������� �������� � ��
            ///</summary>
            public int? pressure_pa;

            ///<summary>
            ///������������� ��������� �������
            ///</summary>
            public int? humidity;

            ///<summary>
            ///����������� �����
            ///</summary>
            public int? soil_temp;

            ///<summary>
            ///��������� �����
            ///</summary>
            public double? soil_moisture;

            ///<summary>
            ///���������� ������� � ��
            ///</summary>
            public int? prec_mm;

            ///<summary>
            ///����������� ��������� ������� � %
            ///</summary>
            public int? prec_prob;

            ///<summary>
            ///����������������� ������� � �������
            ///</summary>
            public int? prec_period;

            ///<summary>
            ///���������� � %
            ///</summary>
            public double? cloudness;

            ///<summary>
            ///��� �������
            ///</summary>
            public int? prec_type;

            ///<summary>
            ///������������� �������
            ///</summary>
            public int? prec_strength;

            ///<summary>
            ///��� ������ ������
            ///</summary>
            public string icon;

            ///<summary>
            ///�������� �������� �������
            ///</summary>
            public string condition;

            ///<summary>
            ///���������������� ������
            ///</summary>
            public int? uv_index;

            ///<summary>
            ///��������� �����������
            ///</summary>
            public int? feels_like;

            ///<summary>
            ///���� ��� ����
            ///</summary>
            public string daytime;

            ///<summary>
            ///������� ��������� ��� ��� ����
            ///</summary>
            public bool? polar;

            ///<summary>
            ///������ �������������� �����
            ///</summary>
            public int? fresh_snow_mm;
        }
        /// <summary>
        /// �����, ���������� ������ � ������ ���� (����������� �������)
        /// </summary>
        public class DayShort
        {
            /// <summary>
            /// �������� ������
            /// </summary>
            public string _source;

            /// <summary>
            /// ����������� �������
            /// </summary>
            public int temp;

            /// <summary>
            /// ����������� ����������� �������
            /// </summary>
            public int temp_min;

            /// <summary>
            /// �������� �����
            /// </summary>
            public double wind_speed;

            /// <summary>
            /// ������ �����
            /// </summary>
            public double wind_gust;

            /// <summary>
            /// ����������� �����
            /// </summary>
            public string wind_dir;

            /// <summary>
            /// ����������� �������� � �� ��. ��.
            /// </summary>
            public int pressure_mm;

            /// <summary>
            /// ����������� �������� � ��
            /// </summary>
            public int pressure_pa;

            /// <summary>
            /// ������������� ��������� �������
            /// </summary>
            public int humidity;

            /// <summary>
            /// ����������� �����
            /// </summary>
            public int soil_temp;

            /// <summary>
            /// ��������� �����
            /// </summary>
            public double soil_moisture;

            /// <summary>
            /// ���������� ������� � ��
            /// </summary>
            public int prec_mm;

            /// <summary>
            /// ����������� ��������� ������� � %
            /// </summary>
            public int prec_prob;

            /// <summary>
            /// ����������������� ������� � �������
            /// </summary>
            public int prec_period;

            /// <summary>
            /// ���������� � %
            /// </summary>
            public double cloudness;

            /// <summary>
            /// ��� �������
            /// </summary>
            public int prec_type;

            /// <summary>
            /// ������������� �������
            /// </summary>
            public int prec_strength;

            /// <summary>
            /// ��� ������ ������
            /// </summary>
            public string icon;

            /// <summary>
            /// �������� �������� �������
            /// </summary>
            public string condition;

            /// <summary>
            /// ������ ��-���������
            /// </summary>
            public int uv_index;

            /// <summary>
            /// ��������� �����������
            /// </summary>
            public int feels_like;

            /// <summary>
            /// ����� �����
            /// </summary>
            public string daytime;

            /// <summary>
            /// ������� �������� ����
            /// </summary>
            public bool polar;

            /// <summary>
            /// ���������� �������������� ����� � ��
            /// </summary>
            public int fresh_snow_mm;
        }
        ///<summary>
        ///�����, ���������� ������ � ������ �� �����
        ///</summary>
        public class Evening
        {
            ///<summary>
            ///�������� ������
            ///</summary>
            public string _source;

            ///<summary>
            ///����������� ����������� �������
            ///</summary>
            public int? temp_min;

            ///<summary>
            ///������� ����������� �������
            ///</summary>
            public int? temp_avg;

            ///<summary>
            ///������������ ����������� �������
            ///</summary>
            public int? temp_max;

            ///<summary>
            ///�������� �����
            ///</summary>
            public double? wind_speed;

            ///<summary>
            ///������ �����
            ///</summary>
            public double? wind_gust;

            ///<summary>
            ///����������� �����
            ///</summary>
            public string wind_dir;

            ///<summary>
            ///����������� �������� � �� ��. ��.
            ///</summary>
            public int? pressure_mm;

            ///<summary>
            ///����������� �������� � ��
            ///</summary>
            public int? pressure_pa;

            ///<summary>
            ///������������� ��������� �������
            ///</summary>
            public int? humidity;

            ///<summary>
            ///����������� �����
            ///</summary>
            public int? soil_temp;

            ///<summary>
            ///��������� �����
            ///</summary>
            public double? soil_moisture;

            ///<summary>
            ///���������� ������� � ��
            ///</summary>
            public int? prec_mm;

            ///<summary>
            ///����������� ��������� ������� � %
            ///</summary>
            public int? prec_prob;

            ///<summary>
            ///����������������� ������� � �������
            ///</summary>
            public int? prec_period;

            ///<summary>
            ///���������� � %
            ///</summary>
            public double? cloudness;

            ///<summary>
            ///��� �������
            ///</summary>
            public int? prec_type;

            ///<summary>
            ///������������� �������
            ///</summary>
            public int? prec_strength;

            ///<summary>
            ///��� ������ ������
            ///</summary>
            public string icon;

            ///<summary>
            ///�������� �������� �������
            ///</summary>
            public string condition;

            ///<summary>
            ///���������������� ������
            ///</summary>
            public int? uv_index;

            ///<summary>
            ///��������� �����������
            ///</summary>
            public int? feels_like;

            ///<summary>
            ///���� ��� ����
            ///</summary>
            public string daytime;

            ///<summary>
            ///������� ��������� ��� ��� ����
            ///</summary>
            public bool? polar;

            ///<summary>
            ///������ �������������� �����
            ///</summary>
            public int? fresh_snow_mm;
        }

        ///<summary>
        ///�����, ���������� ������ � ����������� ������
        ///</summary>
        public class Fact
        {
            ///<summary>
            ///����� ���������� �� �������
            ///</summary>
            public int? obs_time;

            ///<summary>
            ///����� ������ API � ��������
            ///</summary>
            public int? uptime;

            ///<summary>
            ///����������� �������
            ///</summary>
            public int? temp;

            ///<summary>
            ///��������� �����������
            ///</summary>
            public int? feels_like;

            ///<summary>
            ///��� ������ ������
            ///</summary>
            public string icon;

            ///<summary>
            ///�������� �������� �������
            ///</summary>
            public string condition;

            ///<summary>
            ///���������� � %
            ///</summary>
            public double? cloudness;

            ///<summary>
            ///��� �������
            ///</summary>
            public int? prec_type;

            ///<summary>
            ///����������� ��������� ������� � %
            ///</summary>
            public int? prec_prob;

            ///<summary>
            ///������������� �������
            ///</summary>
            public int? prec_strength;

            ///<summary>
            ///������� �����
            ///</summary>
            public bool? is_thunder;

            ///<summary>
            ///�������� �����
            ///</summary>
            public double? wind_speed;

            ///<summary>
            ///����������� �����
            ///</summary>
            public string wind_dir;

            ///<summary>
            ///����������� �������� � �� ��. ��.
            ///</summary>
            public int? pressure_mm;

            ///<summary>
            ///����������� �������� � ��
            ///</summary>
            public int? pressure_pa;

            ///<summary>
            ///������������� ��������� �������
            ///</summary>
            public int? humidity;

            ///<summary>
            ///���� ��� ����
            ///</summary>
            public string daytime;

            ///<summary>
            ///������� ��������� ��� ��� ����
            ///</summary>
            public bool? polar;

            ///<summary>
            ///�����
            ///</summary>
            public string season;

            ///<summary>
            ///�������� ������
            ///</summary>
            public string source;

            ///<summary>
            ///��������� �����
            ///</summary>
            public double? soil_moisture;

            ///<summary>
            ///����������� �����
            ///</summary>
            public int? soil_temp;

            ///<summary>
            ///���������������� ������
            ///</summary>
            public int? uv_index;

            ///<summary>
            ///������ �����
            ///</summary>
            public double? wind_gust;
        }

        /// <summary>
        /// �����, ���������� ������ � �������� ������
        /// </summary>
        public class Forecast
        {
            /// <summary>
            /// ����
            /// </summary>
            public string date;

            /// <summary>
            /// ����� � ������� Unix
            /// </summary>
            public int date_ts;

            /// <summary>
            /// ����� ������
            /// </summary>
            public int week;

            /// <summary>
            /// ����� ������� ������
            /// </summary>
            public string sunrise;

            /// <summary>
            /// ����� ������ ������
            /// </summary>
            public string sunset;

            /// <summary>
            /// ����� ������ ������������ ����������� �����
            /// </summary>
            public string rise_begin;

            /// <summary>
            /// ����� ��������� ������������ ����������� �����
            /// </summary>
            public string set_end;

            /// <summary>
            /// ��� ���� ����
            /// </summary>
            public int moon_code;

            /// <summary>
            /// ��������� �������� ���� ����
            /// </summary>
            public string moon_text;

            /// <summary>
            /// ����� �����
            /// </summary>
            public Parts parts;

            /// <summary>
            /// ������ ��������� ������ �� �����
            /// </summary>
            public List<Hour> hours;

            /// <summary>
            /// ������ � �������������� �����������
            /// </summary>
            public Biomet biomet;
        }
        /// <summary>
        /// �����, ���������� ���������� � ���������� ������
        /// </summary>
        public class Locality
        {
            /// <summary>
            /// ������������� ����������� ������
            /// </summary>
            public int id;

            /// <summary>
            /// �������� ����������� ������
            /// </summary>
            public string name;
        }
        /// <summary>
        /// �����, ���������� ������ � �������������� �������
        /// </summary>
        public class GeoObject
        {
            /// <summary>
            /// �����
            /// </summary>
            public object district;

            /// <summary>
            /// ���������� �����
            /// </summary>
            public Locality locality;

            /// <summary>
            /// ���������
            /// </summary>
            public Province province;

            /// <summary>
            /// ������
            /// </summary>
            public Country country;
        }

        /// <summary>
        /// �����, ���������� ������ � ������ �� ������������ ���
        /// </summary>
        public class Hour
        {
            /// <summary>
            /// ���
            /// </summary>
            public string hour;

            /// <summary>
            /// ����� � ������� Unix
            /// </summary>
            public int? hour_ts;

            /// <summary>
            /// ����������� �������
            /// </summary>
            public int? temp;

            /// <summary>
            /// ��������� �����������
            /// </summary>
            public int? feels_like;

            /// <summary>
            /// ��� ������ ������
            /// </summary>
            public string icon;

            /// <summary>
            /// �������� �������� �������
            /// </summary>
            public string condition;

            /// <summary>
            /// ���������� � %
            /// </summary>
            public double? cloudness;

            /// <summary>
            /// ��� �������
            /// </summary>
            public int? prec_type;

            /// <summary>
            /// ������������� �������
            /// </summary>
            public int? prec_strength;

            /// <summary>
            /// ������� �����
            /// </summary>
            public bool? is_thunder;

            /// <summary>
            /// ����������� �����
            /// </summary>
            public string wind_dir;

            /// <summary>
            /// �������� �����
            /// </summary>
            public double? wind_speed;

            /// <summary>
            /// ������ �����
            /// </summary>
            public double? wind_gust;

            /// <summary>
            /// ����������� �������� � �� ��. ��.
            /// </summary>
            public int? pressure_mm;

            /// <summary>
            /// ����������� �������� � ��
            /// </summary>
            public int? pressure_pa;

            /// <summary>
            /// ������������� ��������� �������
            /// </summary>
            public int? humidity;

            /// <summary>
            /// ����������� �����
            /// </summary>
            public int? soil_temp;

            /// <summary>
            /// ��������� �����
            /// </summary>
            public double? soil_moisture;

            /// <summary>
            /// ���������� ������� � ��
            /// </summary>
            public int? prec_mm;

            /// <summary>
            /// ����������������� ������� � �������
            /// </summary>
            public int? prec_period;

            /// <summary>
            /// ����������� ��������� ������� � %
            /// </summary>
            public int? prec_prob;
        }

        /// <summary>
        /// �����, ���������� ���������� � ��������������
        /// </summary>
        public class Info
        {
            /// <summary>
            /// ������� ��������� ���������
            /// </summary>
            public bool? n;

            /// <summary>
            /// ������������� ��������������� �������
            /// </summary>
            public int? geoid;

            /// <summary>
            /// URL-�����
            /// </summary>
            public string url;

            /// <summary>
            /// ������
            /// </summary>
            public int? lat;

            /// <summary>
            /// �������
            /// </summary>
            public int? lon;

            /// <summary>
            /// ���������� � ������� �����
            /// </summary>
            public Tzinfo tzinfo;

            /// <summary>
            /// ����������� �������� �� ��������� � �� ��. ��.
            /// </summary>
            public int? def_pressure_mm;

            /// <summary>
            /// ����������� �������� �� ��������� � ��
            /// </summary>
            public int? def_pressure_pa;

            /// <summary>
            /// URL-����� �������
            /// </summary>
            public string slug;

            /// <summary>
            /// ������� ��������������� �����
            /// </summary>
            public int? zoom;

            /// <summary>
            /// ������� ������-��������� ���� �����
            /// </summary>
            public bool? nr;

            /// <summary>
            /// ������� ������ ���� �����
            /// </summary>
            public bool? ns;

            /// <summary>
            /// ������� ���-���������� ���� �����
            /// </summary>
            public bool? nsr;

            /// <summary>
            /// ������� ������������ �����
            /// </summary>
            public bool? p;

            /// <summary>
            /// ������� ����������� ����������� ������� �� �����
            /// </summary>
            public bool? f;

            /// <summary>
            /// ������� ����������� ������ ��������� ������ �� �����
            /// </summary>
            public bool? _h;
        }
        /// <summary>
        /// �����, ���������� ������ � ������ ����� (����������� �������)
        /// </summary>
        public class NightShort
        {
            /// <summary>
            /// �������� ������
            /// </summary>
            public string _source;

            /// <summary>
            /// ����������� �������
            /// </summary>
            public int? temp;

            /// <summary>
            /// �������� �����
            /// </summary>
            public double? wind_speed;

            /// <summary>
            /// ������ �����
            /// </summary>
            public double? wind_gust;

            /// <summary>
            /// ����������� �����
            /// </summary>
            public string wind_dir;

            /// <summary>
            /// ����������� �������� � �� ��. ��.
            /// </summary>
            public int? pressure_mm;

            /// <summary>
            /// ����������� �������� � ��
            /// </summary>
            public int? pressure_pa;

            /// <summary>
            /// ������������� ��������� �������
            /// </summary>
            public int? humidity;

            /// <summary>
            /// ����������� �����
            /// </summary>
            public int? soil_temp;

            /// <summary>
            /// ��������� �����
            /// </summary>
            public double? soil_moisture;

            /// <summary>
            /// ���������� ������� � ��
            /// </summary>
            public int? prec_mm;

            /// <summary>
            /// ����������� ��������� ������� � %
            /// </summary>
            public int? prec_prob;

            /// <summary>
            /// ����������������� ������� � �������
            /// </summary>
            public int? prec_period;

            /// <summary>
            /// ���������� � %
            /// </summary>
            public double? cloudness;

            /// <summary>
            /// ��� �������
            /// </summary>
            public int? prec_type;

            /// <summary>
            /// ������������� �������
            /// </summary>
            public int? prec_strength;

            /// <summary>
            /// ��� ������ ������
            /// </summary>
            public string icon;

            /// <summary>
            /// �������� �������� �������
            /// </summary>
            public string condition;

            /// <summary>
            /// ������ ��-���������
            /// </summary>
            public int? uv_index;

            /// <summary>
            /// ��������� �����������
            /// </summary>
            public int? feels_like;

            /// <summary>
            /// ����� �����
            /// </summary>
            public string daytime;

            /// <summary>
            /// ������� �������� ����
            /// </summary>
            public bool? polar;

            /// <summary>
            /// ���������� �������������� ����� � ��
            /// </summary>
            public int? fresh_snow_mm;
        }
        public class Morning
        {
            /// <summary>
            /// �������� ������
            /// </summary>
            public string _source;

            /// <summary>
            /// ����������� ����������� �������
            /// </summary>
            public int temp_min;

            /// <summary>
            /// ������� ����������� �������
            /// </summary>
            public int temp_avg;

            /// <summary>
            /// ������������ ����������� �������
            /// </summary>
            public int temp_max;

            /// <summary>
            /// �������� �����
            /// </summary>
            public double wind_speed;

            /// <summary>
            /// ������ �����
            /// </summary>
            public double wind_gust;

            /// <summary>
            /// ����������� �����
            /// </summary>
            public string wind_dir;

            /// <summary>
            /// ����������� �������� � �� ��. ��.
            /// </summary>
            public int pressure_mm;

            /// <summary>
            /// ����������� �������� � ��
            /// </summary>
            public int pressure_pa;

            /// <summary>
            /// ������������� ��������� �������
            /// </summary>
            public int humidity;

            /// <summary>
            /// ����������� �����
            /// </summary>
            public int soil_temp;

            /// <summary>
            /// ��������� �����
            /// </summary>
            public double soil_moisture;

            /// <summary>
            /// ���������� ������� � ��
            /// </summary>
            public int prec_mm;

            /// <summary>
            /// ����������� ��������� ������� � %
            /// </summary>
            public int prec_prob;

            /// <summary>
            /// ����������������� ������� � �������
            /// </summary>
            public int prec_period;

            /// <summary>
            /// ���������� � %
            /// </summary>
            public double cloudness;

            /// <summary>
            /// ��� �������
            /// </summary>
            public int prec_type;

            /// <summary>
            /// ������������� �������
            /// </summary>
            public int prec_strength;

            /// <summary>
            /// ��� ������ ������
            /// </summary>
            public string icon;

            /// <summary>
            /// �������� �������� �������
            /// </summary>
            public string condition;

            /// <summary>
            /// ������ ��-���������
            /// </summary>
            public int uv_index;

            /// <summary>
            /// ��������� �����������
            /// </summary>
            public int feels_like;

            /// <summary>
            /// ����� �����
            /// </summary>
            public string daytime;

            /// <summary>
            /// ������� �������� ����
            /// </summary>
            public bool polar;

            /// <summary>
            /// ���������� �������������� ����� � ��
            /// </summary>
            public int FreshSnowMm;
        }
        /// <summary>
        /// �����, �������������� ������ ������
        /// </summary>
        public class Night
        {
            /// <summary>
            /// �������� ������
            /// </summary>
            public string _source;
            /// <summary>
            /// ����������� ����������� ������� � �������� �������
            /// </summary>
            public int? temp_min;
            /// <summary>
            /// ������� ����������� ������� � �������� �������
            /// </summary>
            public int? temp_avg;
            /// <summary>
            /// ������������ ����������� ������� � �������� �������
            /// </summary>
            public int? temp_max;
            /// <summary>
            /// �������� ����� � �/�
            /// </summary>
            public double? wind_speed;
            /// <summary>
            /// ������ ����� � �/�
            /// </summary>
            public double? wind_gust;
            /// <summary>
            /// ����������� �����
            /// </summary>
            public string wind_dir;
            /// <summary>
            /// ����������� �������� � �� ��. ��.
            /// </summary>
            public int? pressure_mm;
            /// <summary>
            /// ����������� �������� � ��
            /// </summary>
            public int? pressure_pa;
            /// <summary>
            /// ��������� ������� � ���������
            /// </summary>
            public int? humidity;
            /// <summary>
            /// ����������� ����� � �������� �������
            /// </summary>
            public int? soil_temp;
            /// <summary>
            /// ��������� ����� � ���������
            /// </summary>
            public double? soil_moisture;
            /// <summary>
            /// ���������� ������� � ��
            /// </summary>
            public int? prec_mm;
            /// <summary>
            /// ����������� ��������� ������� � ���������
            /// </summary>
            public int? prec_prob;
            /// <summary>
            /// ����������������� ������� � �������
            /// </summary>
            public int? prec_period;
            /// <summary>
            /// ���������� � ���������
            /// </summary>
            public double? cloudness;
            /// <summary>
            /// ��� �������
            /// </summary>
            public int? prec_type;
            /// <summary>
            /// ������������� �������
            /// </summary>
            public int? prec_strength;
            /// <summary>
            /// ������, ��������������� �������� ��������
            /// </summary>
            public string icon;
            /// <summary>
            /// �������� �������� �������
            /// </summary>
            public string condition;
            /// <summary>
            /// ������ ��-���������
            /// </summary>
            public int? uv_index;
            /// <summary>
            /// ��������� ����������� ������� � �������� �������
            /// </summary>
            public int? feels_like;
            /// <summary>
            /// ����� �����: "����", "����", "����" ��� "�����"
            /// </summary>
            public string daytime;
            /// <summary>
            /// �������� �� ��������� ��������
            /// </summary>
            public bool? polar;
            /// <summary>
            /// ���������� �������������� ����� � ��
            /// </summary>
            public int? fresh_snow_mm;
        }

        /// <summary>
        /// �����, �������������� ��������� ����� ���
        /// </summary>
        /// <summary>
        /// �����, �������������� ��������� ����� ���
        /// </summary>
        public class Parts
        {
            /// <summary>
            /// ������� ���������� � ������� ������
            /// </summary>
            public DayShort day_short;
            /// <summary>
            /// ���������� � ������ �����
            /// </summary>
            public Morning morning;
            /// <summary>
            /// ���������� � ������ ������
            /// </summary>
            public Night night;
            /// <summary>
            /// ������� ���������� � ������ ������
            /// </summary>
            public NightShort night_short;
            /// <summary>
            /// ���������� � ������ �������
            /// </summary>
            public Evening evening;
            /// <summary>
            /// ���������� � ������� ������
            /// </summary>
            public Day day;
        }

        /// <summary>
        /// �����, �������������� ������
        /// </summary>
        public class Province
        {
            /// <summary>
            /// ������������� �������
            /// </summary>
            public int? id;
            /// <summary>
            /// �������� �������
            /// </summary>
            public string name;
        }

        /// <summary>
        /// �����, �������������� ������ ������
        /// </summary>
        public class Model
        {
            /// <summary>
            /// ������� ����������� �������
            /// </summary>
            public int? now;
            /// <summary>
            /// ������� ����� � ����
            /// </summary>
            public DateTime? now_dt;
            /// <summary>
            /// ���������� � ������
            /// </summary>
            public Info info;
            /// <summary>
            /// �������������� ������
            /// </summary>
            public GeoObject geo_object;
            /// <summary>
            /// ���������� � ������ �� ��������� ����
            /// </summary>
            public Yesterday yesterday;
            /// <summary>
            /// ����������� ������
            /// </summary>
            public Fact fact;
            /// <summary>
            /// ������ ��������� ������
            /// </summary>
            public List<Forecast> forecasts;
        }

        /// <summary>
        /// �����, �������������� ���������� � ������� �����
        /// </summary>
        public class Tzinfo
        {
            /// <summary>
            /// �������� �������� �����
            /// </summary>
            public string name;
            /// <summary>
            /// ������������ �������� �����
            /// </summary>
            public string abbr;
            /// <summary>
            /// ������������ �� ������� �� ������ �����
            /// </summary>
            public bool? dst;
            /// <summary>
            /// �������� �� UTC � ��������
            /// </summary>
            public int? offset;
        }

        /// <summary>
        /// �����, �������������� ���������� � ������ �� ��������� ����
        /// </summary>
        public class Yesterday
        {
            /// <summary>
            /// ������� ����������� ������� �� ��������� ����
            /// </summary>
            public int? temp;
        }
    }

    /// <summary>
    /// ������ ��� ������ Api �� ���������� ������
    /// </summary>
    public class LocationApiModel
    {
        /// <summary>
        /// �����, ���������� ������ �� ������, ���������� �� ������� ���������
        /// </summary>
        public class Data
        {
            /// <summary>
            /// �������� ������
            /// </summary>
            public string postal_code;

            /// <summary>
            /// ������
            /// </summary>
            public string country;

            /// <summary>
            /// ��� ISO ������
            /// </summary>
            public string country_iso_code;

            /// <summary>
            /// ����������� �����
            /// </summary>
            public string federal_district;

            /// <summary>
            /// ������������� ���� �������
            /// </summary>
            public string region_fias_id;

            /// <summary>
            /// ������������� ����� �������
            /// </summary>
            public string region_kladr_id;

            /// <summary>
            /// ��� ISO �������
            /// </summary>
            public string region_iso_code;

            /// <summary>
            /// ������ � �����
            /// </summary>
            public string region_with_type;

            /// <summary>
            /// ��� �������
            /// </summary>
            public string region_type;

            /// <summary>
            /// ������ ������������ ���� �������
            /// </summary>
            public string region_type_full;

            /// <summary>
            /// ������������ �������
            /// </summary>
            public string region;

            /// <summary>
            /// ������������� ���� ������
            /// </summary>
            public string area_fias_id;

            /// <summary>
            /// ������������� ����� ������
            /// </summary>
            public string area_kladr_id;

            /// <summary>
            /// ����� � �����
            /// </summary>
            public string area_with_type;

            /// <summary>
            /// ��� ������
            /// </summary>
            public string area_type;

            /// <summary>
            /// ������ ������������ ���� ������
            /// </summary>
            public string area_type_full;

            /// <summary>
            /// ������������ ������
            /// </summary>
            public string area;

            /// <summary>
            /// ������������� ���� ������
            /// </summary>
            public string city_fias_id;

            /// <summary>
            /// ������������� ����� ������
            /// </summary>
            public string city_kladr_id;

            /// <summary>
            /// ����� � �����
            /// </summary>
            public string city_with_type;

            /// <summary>
            /// ��� ������
            /// </summary>
            public string city_type;

            /// <summary>
            /// ������ ������������ ���� ������
            /// </summary>
            public string city_type_full;

            /// <summary>
            /// ������������ ������
            /// </summary>
            public string city;

            /// <summary>
            /// ����� ������
            /// </summary>
            public object city_area;

            /// <summary>
            /// ������������� ���� ������ ������
            /// </summary>
            public object city_district_fias_id;

            /// <summary>
            /// ������������� ����� ������ ������
            /// </summary>
            public object city_district_kladr_id;

            /// <summary>
            /// ����� ������ � �����
            /// </summary>
            public object city_district_with_type;

            /// <summary>
            /// ��� ������ ������
            /// </summary>
            public object city_district_type;

            /// <summary>
            /// ������ ������������ ���� ������ ������
            /// </summary>
            public object city_district_type_full;

            /// <summary>
            /// ������������ ������ ������
            /// </summary>
            public object city_district;

            /// <summary>
            /// ������������� ���� ����������� ������
            /// </summary>
            public string settlement_fias_id;

            /// <summary>
            /// ������������� ����� ����������� ������
            /// </summary>
            public string settlement_kladr_id;

            /// <summary>
            /// ���������� ����� � �����
            /// </summary>
            public string settlement_with_type;

            /// <summary>
            /// ��� ����������� ������
            /// </summary>
            public string settlement_type;

            /// <summary>
            /// ������ ������������ ���� ����������� ������
            /// </summary>
            public string settlement_type_full;

            /// <summary>
            /// ������������ ����������� ������
            /// </summary>
            public string settlement;

            /// <summary>
            /// ������������� ���� �����
            /// </summary>
            public string street_fias_id;

            /// <summary>
            /// ������������� ����� �����
            /// </summary>
            public string street_kladr_id;

            /// <summary>
            /// ����� � �����
            /// </summary>
            public string street_with_type;

            /// <summary>
            /// ��� �����
            /// </summary>
            public string street_type;

            /// <summary>
            /// ������ ������������ ���� �����
            /// </summary>
            public string street_type_full;

            /// <summary>
            /// ������������ �����
            /// </summary>
            public string street;

            /// <summary>
            /// ������������� ���� ���������� �������
            /// </summary>
            public object stead_fias_id;

            /// <summary>
            /// ����������� ����� ���������� �������
            /// </summary>
            public object stead_cadnum;

            /// <summary>
            /// ��� ���������� �������
            /// </summary>
            public object stead_type;

            /// <summary>
            /// ������ ������������ ���� ���������� �������
            /// </summary>
            public object stead_type_full;

            /// <summary>
            /// ��������� �������
            /// </summary>
            public object stead;

            /// <summary>
            /// ������������� ���� ����
            /// </summary>
            public object house_fias_id;

            /// <summary>
            /// ������������� ����� ����
            /// </summary>
            public object house_kladr_id;

            /// <summary>
            /// ����������� ����� ����
            /// </summary>
            public object house_cadnum;

            /// <summary>
            /// ��� ����
            /// </summary>
            public object house_type;

            /// <summary>
            /// ������ ������������ ���� ����
            /// </summary>
            public object house_type_full;

            /// <summary>
            /// ����� ����
            /// 
            public object house;

            /// <summary>
            /// ��� �������/��������
            /// </summary>
            public object block_type;

            /// <summary>
            /// ������ ������������ ���� �������/��������
            /// </summary>
            public object block_type_full;

            /// <summary>
            /// ������/��������
            /// </summary>
            public object block;

            /// <summary>
            /// ����� ��������
            /// </summary>
            public object entrance;

            /// <summary>
            /// ����� �����
            /// </summary>
            public object floor;

            /// <summary>
            /// ������������� ���� ��������
            /// </summary>
            public object flat_fias_id;

            /// <summary>
            /// ����������� ����� ��������
            /// </summary>
            public object flat_cadnum;

            /// <summary>
            /// ��� ��������
            /// </summary>
            public object flat_type;

            /// <summary>
            /// ������ ������������ ���� ��������
            /// </summary>
            public object flat_type_full;

            /// <summary>
            /// ����� ��������
            /// </summary>
            public object flat;

            /// <summary>
            /// ������� ��������
            /// </summary>
            public object flat_area;

            /// <summary>
            /// ���� �� ���������� ����
            /// </summary>
            public object square_meter_price;

            /// <summary>
            /// ���� ��������
            ///</summary>
            /// 
            public object flat_price;

            /// <summary>
            /// ������������� ���� �������
            /// </summary>
            public object room_fias_id;

            /// <summary>
            /// ����������� ����� �������
            /// </summary>
            public object room_cadnum;

            /// <summary>
            /// ��� �������
            /// </summary>
            public object room_type;

            /// <summary>
            /// ������ ������������ ���� �������
            /// </summary>
            public object room_type_full;

            /// <summary>
            /// �������
            /// </summary>
            public object room;

            /// <summary>
            /// ����������� ����
            /// </summary>
            public object postal_box;

            /// <summary>
            /// ������������� ���� �������
            /// </summary>
            public string fias_id;

            /// <summary>
            /// ��� ���� �������
            /// </summary>
            public object fias_code;

            /// <summary>
            /// ������� ��������� ������� � ����
            /// </summary>
            public string fias_level;

            /// <summary>
            /// ������ ������������ ���� ��������� �������
            /// </summary>
            public string fias_actuality_state;

            /// <summary>
            /// ��� ����� �������
            /// </summary>
            public string kladr_id;

            /// <summary>
            /// ������������� �������
            /// </summary>
            public string geoname_id;

            /// <summary>
            /// ������ ������ ������� ��� ������
            /// </summary>
            public string capital_marker;

            /// <summary>
            /// ��� �����
            /// </summary>
            public string okato;

            /// <summary>
            /// ��� �����
            /// </summary>
            public string oktmo;

            /// <summary>
            /// ��� ���� ��� ���������� ���
            /// </summary>
            public string tax_office;

            /// <summary>
            /// ��� ���� ��� �����������
            /// </summary>
            public string tax_office_legal;

            /// <summary>
            /// ������� ����
            /// </summary>
            public object timezone;

            /// <summary>
            /// ������
            /// </summary>
            public string geo_lat;

            /// <summary>
            /// �������
            /// </summary>
            public string geo_lon;

            /// <summary>
            /// ���������� �� ��������� ���������
            /// </summary>
            public object beltway_hit;

            /// <summary>
            /// ���������� �� ��������� � ����������
            /// </summary>
            public object beltway_distance;

            /// <summary>
            /// ��������� �����
            /// </summary>
            public object metro;

            /// <summary>
            /// ������ ���������������� �������� � �������� ������� �� ����������� �� ������
            /// </summary>
            public object divisions;

            /// <summary>
            /// ��� �������� ����������� ������
            /// </summary>
            public string qc_geo;

            /// <summary>
            /// ��� �������� ��������� ������
            /// </summary>
            public object qc_complete;

            /// <summary>
            /// ��� �������� ����
            /// </summary>
            public object qc_house;

            /// <summary>
            /// ������ ���������� �������� ������
            /// </summary>
            public List<string> history_values;

            /// <summary>
            /// �������������� ����� ������
            /// </summary>
            public object unparsed_parts;

            /// <summary>
            /// �������� ������
            /// </summary>
            public object source;

            /// <summary>
            /// ��� ��������
            /// </summary>
            public object qc;
        }

        public class Root
        {
            /// <summary>
            /// ������ ���������
            /// </summary>
            public List<Suggestion> suggestions;
        }

        public class Suggestion
        {
            /// <summary>
            /// �������� ���������
            /// </summary>
            public string value;

            /// <summary>
            /// ������������� �����
            /// </summary>
            public string unrestricted_value;

            /// <summary>
            /// ������ �� ������
            /// </summary>
            public Data data;
        }

    }

}