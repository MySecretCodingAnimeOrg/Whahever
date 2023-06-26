﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WpfApp2.Model;
using WpfApp2.ViewModel.Helpers;

namespace WpfApp2.ViewModel
{
    public class CityViewModel : BindingHelper
    {
        private ObservableCollection<City> cities;
        private City selectedCity;

        public ObservableCollection<City> Cities
        {
            get { return cities; }
            set
            {
                cities = value;
                OnPropertyChanged(nameof(Cities));
            }
        }

        public City SelectedCity
        {
            get { return selectedCity; }
            set
            {
                selectedCity = value;
                OnPropertyChanged(nameof(SelectedCity));
            }
        }

        public CityViewModel()
        {
            Cities = LoadCities();
        }

        public void AddCity(City city)
        {
            Cities.Add(city);
            SaveCities();
        }

        public void UpdateCity(City city)
        {
            City existingCity = Cities.FirstOrDefault(c => c.Name == city.Name);

            if (existingCity != null)
            {
                existingCity.CountryCode = city.CountryCode;
                existingCity.Latitude = city.Latitude;
                existingCity.Longitude = city.Longitude;
                SaveCities();
            }
        }

        public void DeleteCity(City city)
        {
            Cities.Remove(city);
            SaveCities();
        }

        private ObservableCollection<City> LoadCities()
        {
            try
            {
                string filePath = "cities.json";

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    return JsonSerializer.Deserialize<ObservableCollection<City>>(json);
                }
            }
            catch (IOException ex)
            {
                // Обработка ошибки чтения файла
            }

            return new ObservableCollection<City>();
        }

        private void SaveCities()
        {
            try
            {
                string filePath = "cities.json";
                string json = JsonSerializer.Serialize(Cities);
                File.WriteAllText(filePath, json);
            }
            catch (IOException ex)
            {
                // Обработка ошибки записи файла
            }
        }
    }
}
