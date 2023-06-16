using System;
using System.Collections.Generic;

namespace SunCloud.Model
{

    ///<summary>
    ///Класс, содержащий данные о погоде по API Яндекса
    ///</summary>
    public class YandexApiModel
    {
        ///<summary>
        ///Класс, содержащий данные о биометрических показателях
        ///</summary>
        public class Biomet
        {
            ///<summary>
            ///Индекс биометрического показателя
            ///</summary>
            public int? index;

            ///<summary>
            ///Состояние биометрического показателя
            ///</summary>
            public string condition;
        }

        ///<summary>
        ///Класс, содержащий данные о стране
        ///</summary>
        public class Country
        {
            ///<summary>
            ///Идентификатор страны
            ///</summary>
            public int? id;

            ///<summary>
            ///Название страны
            ///</summary>
            public string name;
        }

        ///<summary>
        ///Класс, содержащий данные о погоде на определенный день
        ///</summary>
        public class Day
        {
            ///<summary>
            ///Источник данных
            ///</summary>
            public string _source;

            ///<summary>
            ///Минимальная температура воздуха
            ///</summary>
            public int? temp_min;

            ///<summary>
            ///Средняя температура воздуха
            ///</summary>
            public int? temp_avg;

            ///<summary>
            ///Максимальная температура воздуха
            ///</summary>
            public int? temp_max;

            ///<summary>
            ///Скорость ветра
            ///</summary>
            public double? wind_speed;

            ///<summary>
            ///Порывы ветра
            ///</summary>
            public double? wind_gust;

            ///<summary>
            ///Направление ветра
            ///</summary>
            public string wind_dir;

            ///<summary>
            ///Атмосферное давление в мм рт. ст.
            ///</summary>
            public int? pressure_mm;

            ///<summary>
            ///Атмосферное давление в Па
            ///</summary>
            public int? pressure_pa;

            ///<summary>
            ///Относительная влажность воздуха
            ///</summary>
            public int? humidity;

            ///<summary>
            ///Температура почвы
            ///</summary>
            public int? soil_temp;

            ///<summary>
            ///Влажность почвы
            ///</summary>
            public double? soil_moisture;

            ///<summary>
            ///Количество осадков в мм
            ///</summary>
            public int? prec_mm;

            ///<summary>
            ///Вероятность выпадения осадков в %
            ///</summary>
            public int? prec_prob;

            ///<summary>
            ///Продолжительность осадков в минутах
            ///</summary>
            public int? prec_period;

            ///<summary>
            ///Облачность в %
            ///</summary>
            public double? cloudness;

            ///<summary>
            ///Тип осадков
            ///</summary>
            public int? prec_type;

            ///<summary>
            ///Интенсивность осадков
            ///</summary>
            public int? prec_strength;

            ///<summary>
            ///Код значка погоды
            ///</summary>
            public string icon;

            ///<summary>
            ///Описание погодных условий
            ///</summary>
            public string condition;

            ///<summary>
            ///Ультрафиолетовый индекс
            ///</summary>
            public int? uv_index;

            ///<summary>
            ///Ощущаемая температура
            ///</summary>
            public int? feels_like;

            ///<summary>
            ///День или ночь
            ///</summary>
            public string daytime;

            ///<summary>
            ///Признак полярного дня или ночи
            ///</summary>
            public bool? polar;

            ///<summary>
            ///Высота свежевыпавшего снега
            ///</summary>
            public int? fresh_snow_mm;
        }
        /// <summary>
        /// Класс, содержащий данные о погоде днем (сокращенный вариант)
        /// </summary>
        public class DayShort
        {
            /// <summary>
            /// Источник данных
            /// </summary>
            public string _source;

            /// <summary>
            /// Температура воздуха
            /// </summary>
            public int temp;

            /// <summary>
            /// Минимальная температура воздуха
            /// </summary>
            public int temp_min;

            /// <summary>
            /// Скорость ветра
            /// </summary>
            public double wind_speed;

            /// <summary>
            /// Порывы ветра
            /// </summary>
            public double wind_gust;

            /// <summary>
            /// Направление ветра
            /// </summary>
            public string wind_dir;

            /// <summary>
            /// Атмосферное давление в мм рт. ст.
            /// </summary>
            public int pressure_mm;

            /// <summary>
            /// Атмосферное давление в Па
            /// </summary>
            public int pressure_pa;

            /// <summary>
            /// Относительная влажность воздуха
            /// </summary>
            public int humidity;

            /// <summary>
            /// Температура почвы
            /// </summary>
            public int soil_temp;

            /// <summary>
            /// Влажность почвы
            /// </summary>
            public double soil_moisture;

            /// <summary>
            /// Количество осадков в мм
            /// </summary>
            public int prec_mm;

            /// <summary>
            /// Вероятность выпадения осадков в %
            /// </summary>
            public int prec_prob;

            /// <summary>
            /// Продолжительность осадков в минутах
            /// </summary>
            public int prec_period;

            /// <summary>
            /// Облачность в %
            /// </summary>
            public double cloudness;

            /// <summary>
            /// Тип осадков
            /// </summary>
            public int prec_type;

            /// <summary>
            /// Интенсивность осадков
            /// </summary>
            public int prec_strength;

            /// <summary>
            /// Код значка погоды
            /// </summary>
            public string icon;

            /// <summary>
            /// Описание погодных условий
            /// </summary>
            public string condition;

            /// <summary>
            /// Индекс УФ-излучения
            /// </summary>
            public int uv_index;

            /// <summary>
            /// Ощущаемая температура
            /// </summary>
            public int feels_like;

            /// <summary>
            /// Время суток
            /// </summary>
            public string daytime;

            /// <summary>
            /// Признак полярной ночи
            /// </summary>
            public bool polar;

            /// <summary>
            /// Количество свежевыпавшего снега в мм
            /// </summary>
            public int fresh_snow_mm;
        }
        ///<summary>
        ///Класс, содержащий данные о погоде на вечер
        ///</summary>
        public class Evening
        {
            ///<summary>
            ///Источник данных
            ///</summary>
            public string _source;

            ///<summary>
            ///Минимальная температура воздуха
            ///</summary>
            public int? temp_min;

            ///<summary>
            ///Средняя температура воздуха
            ///</summary>
            public int? temp_avg;

            ///<summary>
            ///Максимальная температура воздуха
            ///</summary>
            public int? temp_max;

            ///<summary>
            ///Скорость ветра
            ///</summary>
            public double? wind_speed;

            ///<summary>
            ///Порывы ветра
            ///</summary>
            public double? wind_gust;

            ///<summary>
            ///Направление ветра
            ///</summary>
            public string wind_dir;

            ///<summary>
            ///Атмосферное давление в мм рт. ст.
            ///</summary>
            public int? pressure_mm;

            ///<summary>
            ///Атмосферное давление в Па
            ///</summary>
            public int? pressure_pa;

            ///<summary>
            ///Относительная влажность воздуха
            ///</summary>
            public int? humidity;

            ///<summary>
            ///Температура почвы
            ///</summary>
            public int? soil_temp;

            ///<summary>
            ///Влажность почвы
            ///</summary>
            public double? soil_moisture;

            ///<summary>
            ///Количество осадков в мм
            ///</summary>
            public int? prec_mm;

            ///<summary>
            ///Вероятность выпадения осадков в %
            ///</summary>
            public int? prec_prob;

            ///<summary>
            ///Продолжительность осадков в минутах
            ///</summary>
            public int? prec_period;

            ///<summary>
            ///Облачность в %
            ///</summary>
            public double? cloudness;

            ///<summary>
            ///Тип осадков
            ///</summary>
            public int? prec_type;

            ///<summary>
            ///Интенсивность осадков
            ///</summary>
            public int? prec_strength;

            ///<summary>
            ///Код значка погоды
            ///</summary>
            public string icon;

            ///<summary>
            ///Описание погодных условий
            ///</summary>
            public string condition;

            ///<summary>
            ///Ультрафиолетовый индекс
            ///</summary>
            public int? uv_index;

            ///<summary>
            ///Ощущаемая температура
            ///</summary>
            public int? feels_like;

            ///<summary>
            ///День или ночь
            ///</summary>
            public string daytime;

            ///<summary>
            ///Признак полярного дня или ночи
            ///</summary>
            public bool? polar;

            ///<summary>
            ///Высота свежевыпавшего снега
            ///</summary>
            public int? fresh_snow_mm;
        }

        ///<summary>
        ///Класс, содержащий данные о фактической погоде
        ///</summary>
        public class Fact
        {
            ///<summary>
            ///Время наблюдения за погодой
            ///</summary>
            public int? obs_time;

            ///<summary>
            ///Время работы API в секундах
            ///</summary>
            public int? uptime;

            ///<summary>
            ///Температура воздуха
            ///</summary>
            public int? temp;

            ///<summary>
            ///Ощущаемая температура
            ///</summary>
            public int? feels_like;

            ///<summary>
            ///Код значка погоды
            ///</summary>
            public string icon;

            ///<summary>
            ///Описание погодных условий
            ///</summary>
            public string condition;

            ///<summary>
            ///Облачность в %
            ///</summary>
            public double? cloudness;

            ///<summary>
            ///Тип осадков
            ///</summary>
            public int? prec_type;

            ///<summary>
            ///Вероятность выпадения осадков в %
            ///</summary>
            public int? prec_prob;

            ///<summary>
            ///Интенсивность осадков
            ///</summary>
            public int? prec_strength;

            ///<summary>
            ///Признак грозы
            ///</summary>
            public bool? is_thunder;

            ///<summary>
            ///Скорость ветра
            ///</summary>
            public double? wind_speed;

            ///<summary>
            ///Направление ветра
            ///</summary>
            public string wind_dir;

            ///<summary>
            ///Атмосферное давление в мм рт. ст.
            ///</summary>
            public int? pressure_mm;

            ///<summary>
            ///Атмосферное давление в Па
            ///</summary>
            public int? pressure_pa;

            ///<summary>
            ///Относительная влажность воздуха
            ///</summary>
            public int? humidity;

            ///<summary>
            ///День или ночь
            ///</summary>
            public string daytime;

            ///<summary>
            ///Признак полярного дня или ночи
            ///</summary>
            public bool? polar;

            ///<summary>
            ///Сезон
            ///</summary>
            public string season;

            ///<summary>
            ///Источник данных
            ///</summary>
            public string source;

            ///<summary>
            ///Влажность почвы
            ///</summary>
            public double? soil_moisture;

            ///<summary>
            ///Температура почвы
            ///</summary>
            public int? soil_temp;

            ///<summary>
            ///Ультрафиолетовый индекс
            ///</summary>
            public int? uv_index;

            ///<summary>
            ///Порывы ветра
            ///</summary>
            public double? wind_gust;
        }

        /// <summary>
        /// Класс, содержащий данные о прогнозе погоды
        /// </summary>
        public class Forecast
        {
            /// <summary>
            /// Дата
            /// </summary>
            public string date;

            /// <summary>
            /// Время в формате Unix
            /// </summary>
            public int date_ts;

            /// <summary>
            /// Номер недели
            /// </summary>
            public int week;

            /// <summary>
            /// Время восхода солнца
            /// </summary>
            public string sunrise;

            /// <summary>
            /// Время заката солнца
            /// </summary>
            public string sunset;

            /// <summary>
            /// Время начала гражданского сумеречного света
            /// </summary>
            public string rise_begin;

            /// <summary>
            /// Время окончания гражданского сумеречного света
            /// </summary>
            public string set_end;

            /// <summary>
            /// Код фазы луны
            /// </summary>
            public int moon_code;

            /// <summary>
            /// Текстовое описание фазы луны
            /// </summary>
            public string moon_text;

            /// <summary>
            /// Части суток
            /// </summary>
            public Parts parts;

            /// <summary>
            /// Список прогнозов погоды по часам
            /// </summary>
            public List<Hour> hours;

            /// <summary>
            /// Данные о биометрических показателях
            /// </summary>
            public Biomet biomet;
        }
        /// <summary>
        /// Класс, содержащий информацию о населенном пункте
        /// </summary>
        public class Locality
        {
            /// <summary>
            /// Идентификатор населенного пункта
            /// </summary>
            public int id;

            /// <summary>
            /// Название населенного пункта
            /// </summary>
            public string name;
        }
        /// <summary>
        /// Класс, содержащий данные о географическом объекте
        /// </summary>
        public class GeoObject
        {
            /// <summary>
            /// Район
            /// </summary>
            public object district;

            /// <summary>
            /// Населенный пункт
            /// </summary>
            public Locality locality;

            /// <summary>
            /// Провинция
            /// </summary>
            public Province province;

            /// <summary>
            /// Страна
            /// </summary>
            public Country country;
        }

        /// <summary>
        /// Класс, содержащий данные о погоде на определенный час
        /// </summary>
        public class Hour
        {
            /// <summary>
            /// Час
            /// </summary>
            public string hour;

            /// <summary>
            /// Время в формате Unix
            /// </summary>
            public int? hour_ts;

            /// <summary>
            /// Температура воздуха
            /// </summary>
            public int? temp;

            /// <summary>
            /// Ощущаемая температура
            /// </summary>
            public int? feels_like;

            /// <summary>
            /// Код значка погоды
            /// </summary>
            public string icon;

            /// <summary>
            /// Описание погодных условий
            /// </summary>
            public string condition;

            /// <summary>
            /// Облачность в %
            /// </summary>
            public double? cloudness;

            /// <summary>
            /// Тип осадков
            /// </summary>
            public int? prec_type;

            /// <summary>
            /// Интенсивность осадков
            /// </summary>
            public int? prec_strength;

            /// <summary>
            /// Признак грозы
            /// </summary>
            public bool? is_thunder;

            /// <summary>
            /// Направление ветра
            /// </summary>
            public string wind_dir;

            /// <summary>
            /// Скорость ветра
            /// </summary>
            public double? wind_speed;

            /// <summary>
            /// Порывы ветра
            /// </summary>
            public double? wind_gust;

            /// <summary>
            /// Атмосферное давление в мм рт. ст.
            /// </summary>
            public int? pressure_mm;

            /// <summary>
            /// Атмосферное давление в Па
            /// </summary>
            public int? pressure_pa;

            /// <summary>
            /// Относительная влажность воздуха
            /// </summary>
            public int? humidity;

            /// <summary>
            /// Температура почвы
            /// </summary>
            public int? soil_temp;

            /// <summary>
            /// Влажность почвы
            /// </summary>
            public double? soil_moisture;

            /// <summary>
            /// Количество осадков в мм
            /// </summary>
            public int? prec_mm;

            /// <summary>
            /// Продолжительность осадков в минутах
            /// </summary>
            public int? prec_period;

            /// <summary>
            /// Вероятность выпадения осадков в %
            /// </summary>
            public int? prec_prob;
        }

        /// <summary>
        /// Класс, содержащий информацию о местоположении
        /// </summary>
        public class Info
        {
            /// <summary>
            /// Признак северного полушария
            /// </summary>
            public bool? n;

            /// <summary>
            /// Идентификатор географического объекта
            /// </summary>
            public int? geoid;

            /// <summary>
            /// URL-адрес
            /// </summary>
            public string url;

            /// <summary>
            /// Широта
            /// </summary>
            public int? lat;

            /// <summary>
            /// Долгота
            /// </summary>
            public int? lon;

            /// <summary>
            /// Информация о часовом поясе
            /// </summary>
            public Tzinfo tzinfo;

            /// <summary>
            /// Атмосферное давление по умолчанию в мм рт. ст.
            /// </summary>
            public int? def_pressure_mm;

            /// <summary>
            /// Атмосферное давление по умолчанию в Па
            /// </summary>
            public int? def_pressure_pa;

            /// <summary>
            /// URL-адрес объекта
            /// </summary>
            public string slug;

            /// <summary>
            /// Уровень масштабирования карты
            /// </summary>
            public int? zoom;

            /// <summary>
            /// Признак северо-западного края карты
            /// </summary>
            public bool? nr;

            /// <summary>
            /// Признак южного края карты
            /// </summary>
            public bool? ns;

            /// <summary>
            /// Признак юго-восточного края карты
            /// </summary>
            public bool? nsr;

            /// <summary>
            /// Признак перекрывания карты
            /// </summary>
            public bool? p;

            /// <summary>
            /// Признак отображения федеральных округов на карте
            /// </summary>
            public bool? f;

            /// <summary>
            /// Признак отображения границ субъектов России на карте
            /// </summary>
            public bool? _h;
        }
        /// <summary>
        /// Класс, содержащий данные о погоде ночью (сокращенный вариант)
        /// </summary>
        public class NightShort
        {
            /// <summary>
            /// Источник данных
            /// </summary>
            public string _source;

            /// <summary>
            /// Температура воздуха
            /// </summary>
            public int? temp;

            /// <summary>
            /// Скорость ветра
            /// </summary>
            public double? wind_speed;

            /// <summary>
            /// Порывы ветра
            /// </summary>
            public double? wind_gust;

            /// <summary>
            /// Направление ветра
            /// </summary>
            public string wind_dir;

            /// <summary>
            /// Атмосферное давление в мм рт. ст.
            /// </summary>
            public int? pressure_mm;

            /// <summary>
            /// Атмосферное давление в Па
            /// </summary>
            public int? pressure_pa;

            /// <summary>
            /// Относительная влажность воздуха
            /// </summary>
            public int? humidity;

            /// <summary>
            /// Температура почвы
            /// </summary>
            public int? soil_temp;

            /// <summary>
            /// Влажность почвы
            /// </summary>
            public double? soil_moisture;

            /// <summary>
            /// Количество осадков в мм
            /// </summary>
            public int? prec_mm;

            /// <summary>
            /// Вероятность выпадения осадков в %
            /// </summary>
            public int? prec_prob;

            /// <summary>
            /// Продолжительность осадков в минутах
            /// </summary>
            public int? prec_period;

            /// <summary>
            /// Облачность в %
            /// </summary>
            public double? cloudness;

            /// <summary>
            /// Тип осадков
            /// </summary>
            public int? prec_type;

            /// <summary>
            /// Интенсивность осадков
            /// </summary>
            public int? prec_strength;

            /// <summary>
            /// Код значка погоды
            /// </summary>
            public string icon;

            /// <summary>
            /// Описание погодных условий
            /// </summary>
            public string condition;

            /// <summary>
            /// Индекс УФ-излучения
            /// </summary>
            public int? uv_index;

            /// <summary>
            /// Ощущаемая температура
            /// </summary>
            public int? feels_like;

            /// <summary>
            /// Время суток
            /// </summary>
            public string daytime;

            /// <summary>
            /// Признак полярной ночи
            /// </summary>
            public bool? polar;

            /// <summary>
            /// Количество свежевыпавшего снега в мм
            /// </summary>
            public int? fresh_snow_mm;
        }
        public class Morning
        {
            /// <summary>
            /// Источник данных
            /// </summary>
            public string _source;

            /// <summary>
            /// Минимальная температура воздуха
            /// </summary>
            public int temp_min;

            /// <summary>
            /// Средняя температура воздуха
            /// </summary>
            public int temp_avg;

            /// <summary>
            /// Максимальная температура воздуха
            /// </summary>
            public int temp_max;

            /// <summary>
            /// Скорость ветра
            /// </summary>
            public double wind_speed;

            /// <summary>
            /// Порывы ветра
            /// </summary>
            public double wind_gust;

            /// <summary>
            /// Направление ветра
            /// </summary>
            public string wind_dir;

            /// <summary>
            /// Атмосферное давление в мм рт. ст.
            /// </summary>
            public int pressure_mm;

            /// <summary>
            /// Атмосферное давление в Па
            /// </summary>
            public int pressure_pa;

            /// <summary>
            /// Относительная влажность воздуха
            /// </summary>
            public int humidity;

            /// <summary>
            /// Температура почвы
            /// </summary>
            public int soil_temp;

            /// <summary>
            /// Влажность почвы
            /// </summary>
            public double soil_moisture;

            /// <summary>
            /// Количество осадков в мм
            /// </summary>
            public int prec_mm;

            /// <summary>
            /// Вероятность выпадения осадков в %
            /// </summary>
            public int prec_prob;

            /// <summary>
            /// Продолжительность осадков в минутах
            /// </summary>
            public int prec_period;

            /// <summary>
            /// Облачность в %
            /// </summary>
            public double cloudness;

            /// <summary>
            /// Тип осадков
            /// </summary>
            public int prec_type;

            /// <summary>
            /// Интенсивность осадков
            /// </summary>
            public int prec_strength;

            /// <summary>
            /// Код значка погоды
            /// </summary>
            public string icon;

            /// <summary>
            /// Описание погодных условий
            /// </summary>
            public string condition;

            /// <summary>
            /// Индекс УФ-излучения
            /// </summary>
            public int uv_index;

            /// <summary>
            /// Ощущаемая температура
            /// </summary>
            public int feels_like;

            /// <summary>
            /// Время суток
            /// </summary>
            public string daytime;

            /// <summary>
            /// Признак полярной ночи
            /// </summary>
            public bool polar;

            /// <summary>
            /// Количество свежевыпавшего снега в мм
            /// </summary>
            public int FreshSnowMm;
        }
        /// <summary>
        /// Класс, представляющий ночную погоду
        /// </summary>
        public class Night
        {
            /// <summary>
            /// Источник данных
            /// </summary>
            public string _source;
            /// <summary>
            /// Минимальная температура воздуха в градусах Цельсия
            /// </summary>
            public int? temp_min;
            /// <summary>
            /// Средняя температура воздуха в градусах Цельсия
            /// </summary>
            public int? temp_avg;
            /// <summary>
            /// Максимальная температура воздуха в градусах Цельсия
            /// </summary>
            public int? temp_max;
            /// <summary>
            /// Скорость ветра в м/с
            /// </summary>
            public double? wind_speed;
            /// <summary>
            /// Порывы ветра в м/с
            /// </summary>
            public double? wind_gust;
            /// <summary>
            /// Направление ветра
            /// </summary>
            public string wind_dir;
            /// <summary>
            /// Атмосферное давление в мм рт. ст.
            /// </summary>
            public int? pressure_mm;
            /// <summary>
            /// Атмосферное давление в Па
            /// </summary>
            public int? pressure_pa;
            /// <summary>
            /// Влажность воздуха в процентах
            /// </summary>
            public int? humidity;
            /// <summary>
            /// Температура почвы в градусах Цельсия
            /// </summary>
            public int? soil_temp;
            /// <summary>
            /// Влажность почвы в процентах
            /// </summary>
            public double? soil_moisture;
            /// <summary>
            /// Количество осадков в мм
            /// </summary>
            public int? prec_mm;
            /// <summary>
            /// Вероятность выпадения осадков в процентах
            /// </summary>
            public int? prec_prob;
            /// <summary>
            /// Продолжительность осадков в минутах
            /// </summary>
            public int? prec_period;
            /// <summary>
            /// Облачность в процентах
            /// </summary>
            public double? cloudness;
            /// <summary>
            /// Тип осадков
            /// </summary>
            public int? prec_type;
            /// <summary>
            /// Интенсивность осадков
            /// </summary>
            public int? prec_strength;
            /// <summary>
            /// Иконка, соответствующая погодным условиям
            /// </summary>
            public string icon;
            /// <summary>
            /// Описание погодных условий
            /// </summary>
            public string condition;
            /// <summary>
            /// Индекс УФ-излучения
            /// </summary>
            public int? uv_index;
            /// <summary>
            /// Ощущаемая температура воздуха в градусах Цельсия
            /// </summary>
            public int? feels_like;
            /// <summary>
            /// Время суток: "ночь", "утро", "день" или "вечер"
            /// </summary>
            public string daytime;
            /// <summary>
            /// Является ли местность полярной
            /// </summary>
            public bool? polar;
            /// <summary>
            /// Количество свежевыпавшего снега в мм
            /// </summary>
            public int? fresh_snow_mm;
        }

        /// <summary>
        /// Класс, представляющий различные части дня
        /// </summary>
        /// <summary>
        /// Класс, представляющий различные части дня
        /// </summary>
        public class Parts
        {
            /// <summary>
            /// Краткая информация о дневной погоде
            /// </summary>
            public DayShort day_short;
            /// <summary>
            /// Информация о погоде утром
            /// </summary>
            public Morning morning;
            /// <summary>
            /// Информация о ночной погоде
            /// </summary>
            public Night night;
            /// <summary>
            /// Краткая информация о ночной погоде
            /// </summary>
            public NightShort night_short;
            /// <summary>
            /// Информация о погоде вечером
            /// </summary>
            public Evening evening;
            /// <summary>
            /// Информация о дневной погоде
            /// </summary>
            public Day day;
        }

        /// <summary>
        /// Класс, представляющий регион
        /// </summary>
        public class Province
        {
            /// <summary>
            /// Идентификатор региона
            /// </summary>
            public int? id;
            /// <summary>
            /// Название региона
            /// </summary>
            public string name;
        }

        /// <summary>
        /// Класс, представляющий модель погоды
        /// </summary>
        public class Model
        {
            /// <summary>
            /// Текущая температура воздуха
            /// </summary>
            public int? now;
            /// <summary>
            /// Текущее время и дата
            /// </summary>
            public DateTime? now_dt;
            /// <summary>
            /// Информация о погоде
            /// </summary>
            public Info info;
            /// <summary>
            /// Географический объект
            /// </summary>
            public GeoObject geo_object;
            /// <summary>
            /// Информация о погоде за прошедший день
            /// </summary>
            public Yesterday yesterday;
            /// <summary>
            /// Фактическая погода
            /// </summary>
            public Fact fact;
            /// <summary>
            /// Список прогнозов погоды
            /// </summary>
            public List<Forecast> forecasts;
        }

        /// <summary>
        /// Класс, представляющий информацию о часовом поясе
        /// </summary>
        public class Tzinfo
        {
            /// <summary>
            /// Название часового пояса
            /// </summary>
            public string name;
            /// <summary>
            /// Аббревиатура часового пояса
            /// </summary>
            public string abbr;
            /// <summary>
            /// Используется ли переход на летнее время
            /// </summary>
            public bool? dst;
            /// <summary>
            /// Смещение от UTC в секундах
            /// </summary>
            public int? offset;
        }

        /// <summary>
        /// Класс, представляющий информацию о погоде за прошедший день
        /// </summary>
        public class Yesterday
        {
            /// <summary>
            /// Средняя температура воздуха за прошедший день
            /// </summary>
            public int? temp;
        }
    }

    /// <summary>
    /// Полный тип данных Api по нахождению города
    /// </summary>
    public class LocationApiModel
    {
        /// <summary>
        /// Класс, содержащий данные об адресе, полученные из сервиса подсказок
        /// </summary>
        public class Data
        {
            /// <summary>
            /// Почтовый индекс
            /// </summary>
            public string postal_code;

            /// <summary>
            /// Страна
            /// </summary>
            public string country;

            /// <summary>
            /// Код ISO страны
            /// </summary>
            public string country_iso_code;

            /// <summary>
            /// Федеральный округ
            /// </summary>
            public string federal_district;

            /// <summary>
            /// Идентификатор ФИАС региона
            /// </summary>
            public string region_fias_id;

            /// <summary>
            /// Идентификатор КЛАДР региона
            /// </summary>
            public string region_kladr_id;

            /// <summary>
            /// Код ISO региона
            /// </summary>
            public string region_iso_code;

            /// <summary>
            /// Регион с типом
            /// </summary>
            public string region_with_type;

            /// <summary>
            /// Тип региона
            /// </summary>
            public string region_type;

            /// <summary>
            /// Полное наименование типа региона
            /// </summary>
            public string region_type_full;

            /// <summary>
            /// Наименование региона
            /// </summary>
            public string region;

            /// <summary>
            /// Идентификатор ФИАС района
            /// </summary>
            public string area_fias_id;

            /// <summary>
            /// Идентификатор КЛАДР района
            /// </summary>
            public string area_kladr_id;

            /// <summary>
            /// Район с типом
            /// </summary>
            public string area_with_type;

            /// <summary>
            /// Тип района
            /// </summary>
            public string area_type;

            /// <summary>
            /// Полное наименование типа района
            /// </summary>
            public string area_type_full;

            /// <summary>
            /// Наименование района
            /// </summary>
            public string area;

            /// <summary>
            /// Идентификатор ФИАС города
            /// </summary>
            public string city_fias_id;

            /// <summary>
            /// Идентификатор КЛАДР города
            /// </summary>
            public string city_kladr_id;

            /// <summary>
            /// Город с типом
            /// </summary>
            public string city_with_type;

            /// <summary>
            /// Тип города
            /// </summary>
            public string city_type;

            /// <summary>
            /// Полное наименование типа города
            /// </summary>
            public string city_type_full;

            /// <summary>
            /// Наименование города
            /// </summary>
            public string city;

            /// <summary>
            /// Район города
            /// </summary>
            public object city_area;

            /// <summary>
            /// Идентификатор ФИАС района города
            /// </summary>
            public object city_district_fias_id;

            /// <summary>
            /// Идентификатор КЛАДР района города
            /// </summary>
            public object city_district_kladr_id;

            /// <summary>
            /// Район города с типом
            /// </summary>
            public object city_district_with_type;

            /// <summary>
            /// Тип района города
            /// </summary>
            public object city_district_type;

            /// <summary>
            /// Полное наименование типа района города
            /// </summary>
            public object city_district_type_full;

            /// <summary>
            /// Наименование района города
            /// </summary>
            public object city_district;

            /// <summary>
            /// Идентификатор ФИАС населенного пункта
            /// </summary>
            public string settlement_fias_id;

            /// <summary>
            /// Идентификатор КЛАДР населенного пункта
            /// </summary>
            public string settlement_kladr_id;

            /// <summary>
            /// Населенный пункт с типом
            /// </summary>
            public string settlement_with_type;

            /// <summary>
            /// Тип населенного пункта
            /// </summary>
            public string settlement_type;

            /// <summary>
            /// Полное наименование типа населенного пункта
            /// </summary>
            public string settlement_type_full;

            /// <summary>
            /// Наименование населенного пункта
            /// </summary>
            public string settlement;

            /// <summary>
            /// Идентификатор ФИАС улицы
            /// </summary>
            public string street_fias_id;

            /// <summary>
            /// Идентификатор КЛАДР улицы
            /// </summary>
            public string street_kladr_id;

            /// <summary>
            /// Улица с типом
            /// </summary>
            public string street_with_type;

            /// <summary>
            /// Тип улицы
            /// </summary>
            public string street_type;

            /// <summary>
            /// Полное наименование типа улицы
            /// </summary>
            public string street_type_full;

            /// <summary>
            /// Наименование улицы
            /// </summary>
            public string street;

            /// <summary>
            /// Идентификатор ФИАС земельного участка
            /// </summary>
            public object stead_fias_id;

            /// <summary>
            /// Кадастровый номер земельного участка
            /// </summary>
            public object stead_cadnum;

            /// <summary>
            /// Тип земельного участка
            /// </summary>
            public object stead_type;

            /// <summary>
            /// Полное наименование типа земельного участка
            /// </summary>
            public object stead_type_full;

            /// <summary>
            /// Земельный участок
            /// </summary>
            public object stead;

            /// <summary>
            /// Идентификатор ФИАС дома
            /// </summary>
            public object house_fias_id;

            /// <summary>
            /// Идентификатор КЛАДР дома
            /// </summary>
            public object house_kladr_id;

            /// <summary>
            /// Кадастровый номер дома
            /// </summary>
            public object house_cadnum;

            /// <summary>
            /// Тип дома
            /// </summary>
            public object house_type;

            /// <summary>
            /// Полное наименование типа дома
            /// </summary>
            public object house_type_full;

            /// <summary>
            /// Номер дома
            /// 
            public object house;

            /// <summary>
            /// Тип корпуса/строения
            /// </summary>
            public object block_type;

            /// <summary>
            /// Полное наименование типа корпуса/строения
            /// </summary>
            public object block_type_full;

            /// <summary>
            /// Корпус/строение
            /// </summary>
            public object block;

            /// <summary>
            /// Номер подъезда
            /// </summary>
            public object entrance;

            /// <summary>
            /// Номер этажа
            /// </summary>
            public object floor;

            /// <summary>
            /// Идентификатор ФИАС квартиры
            /// </summary>
            public object flat_fias_id;

            /// <summary>
            /// Кадастровый номер квартиры
            /// </summary>
            public object flat_cadnum;

            /// <summary>
            /// Тип квартиры
            /// </summary>
            public object flat_type;

            /// <summary>
            /// Полное наименование типа квартиры
            /// </summary>
            public object flat_type_full;

            /// <summary>
            /// Номер квартиры
            /// </summary>
            public object flat;

            /// <summary>
            /// Площадь квартиры
            /// </summary>
            public object flat_area;

            /// <summary>
            /// Цена за квадратный метр
            /// </summary>
            public object square_meter_price;

            /// <summary>
            /// Цена квартиры
            ///</summary>
            /// 
            public object flat_price;

            /// <summary>
            /// Идентификатор ФИАС комнаты
            /// </summary>
            public object room_fias_id;

            /// <summary>
            /// Кадастровый номер комнаты
            /// </summary>
            public object room_cadnum;

            /// <summary>
            /// Тип комнаты
            /// </summary>
            public object room_type;

            /// <summary>
            /// Полное наименование типа комнаты
            /// </summary>
            public object room_type_full;

            /// <summary>
            /// Комната
            /// </summary>
            public object room;

            /// <summary>
            /// Абонентский ящик
            /// </summary>
            public object postal_box;

            /// <summary>
            /// Идентификатор ФИАС объекта
            /// </summary>
            public string fias_id;

            /// <summary>
            /// Код ФИАС объекта
            /// </summary>
            public object fias_code;

            /// <summary>
            /// Уровень адресного объекта в ФИАС
            /// </summary>
            public string fias_level;

            /// <summary>
            /// Статус актуальности ФИАС адресного объекта
            /// </summary>
            public string fias_actuality_state;

            /// <summary>
            /// Код КЛАДР объекта
            /// </summary>
            public string kladr_id;

            /// <summary>
            /// Идентификатор геонама
            /// </summary>
            public string geoname_id;

            /// <summary>
            /// Маркер центра региона или района
            /// </summary>
            public string capital_marker;

            /// <summary>
            /// Код ОКАТО
            /// </summary>
            public string okato;

            /// <summary>
            /// Код ОКТМО
            /// </summary>
            public string oktmo;

            /// <summary>
            /// Код ИФНС для физических лиц
            /// </summary>
            public string tax_office;

            /// <summary>
            /// Код ИФНС для организаций
            /// </summary>
            public string tax_office_legal;

            /// <summary>
            /// Часовой пояс
            /// </summary>
            public object timezone;

            /// <summary>
            /// Широта
            /// </summary>
            public string geo_lat;

            /// <summary>
            /// Долгота
            /// </summary>
            public string geo_lon;

            /// <summary>
            /// Расстояние до ближайшей кольцевой
            /// </summary>
            public object beltway_hit;

            /// <summary>
            /// Расстояние до кольцевой в километрах
            /// </summary>
            public object beltway_distance;

            /// <summary>
            /// Ближайшее метро
            /// </summary>
            public object metro;

            /// <summary>
            /// Список административных объектов в обратном порядке от конкретного до общего
            /// </summary>
            public object divisions;

            /// <summary>
            /// Код качества населенного пункта
            /// </summary>
            public string qc_geo;

            /// <summary>
            /// Код качества обработки адреса
            /// </summary>
            public object qc_complete;

            /// <summary>
            /// Код качества дома
            /// </summary>
            public object qc_house;

            /// <summary>
            /// Список предыдущих значений адреса
            /// </summary>
            public List<string> history_values;

            /// <summary>
            /// Нераспознанные части адреса
            /// </summary>
            public object unparsed_parts;

            /// <summary>
            /// Источник данных
            /// </summary>
            public object source;

            /// <summary>
            /// Код качества
            /// </summary>
            public object qc;
        }

        public class Root
        {
            /// <summary>
            /// Список подсказок
            /// </summary>
            public List<Suggestion> suggestions;
        }

        public class Suggestion
        {
            /// <summary>
            /// Значение подсказки
            /// </summary>
            public string value;

            /// <summary>
            /// Неразобранный адрес
            /// </summary>
            public string unrestricted_value;

            /// <summary>
            /// Данные об адресе
            /// </summary>
            public Data data;
        }

    }

}