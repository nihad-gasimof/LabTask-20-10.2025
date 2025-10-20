using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_Dersi_17_10_2025
{
    internal class Vehicle
    {
        public string color;
        private int _year;
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value<=2025 && value>=1800)
                {
                    _year = value;
                }
                else
                {
                    Console.WriteLine("Duzgun il daxil edin (1800-2025)");
                }
            }
        }



        public Vehicle(int year)
        {
            Year = year;
        }
    }
}
