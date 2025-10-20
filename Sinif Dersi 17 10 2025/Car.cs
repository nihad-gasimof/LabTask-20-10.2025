using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_Dersi_17_10_2025
{
    internal class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public float FuelCapacity;
        public float FuelFor1Km;
        public float CurrentFuel;
        public Car( string brand, string model,int year, float fuelFor1Km, float currentFuel) : base(year)
        {
            Year = year;
            FuelFor1Km = fuelFor1Km;
            CurrentFuel = currentFuel;
            Brand = brand;
            Model = model;

        }

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, FuelFor1Km: {FuelFor1Km}, CurrentFuel: {CurrentFuel}");
        }

        public void Drive(float km)
        {
            float neededFuel = km * FuelFor1Km;
            if (neededFuel<CurrentFuel)
            {
                float LastFuel = CurrentFuel - neededFuel;
                Console.WriteLine($"Sizin Qalan Fueliniz {LastFuel}");
            }
            else
            {
                Console.WriteLine("Sizin Fueliniz kifayet qeder deyil");
            }

        }
    }
}
