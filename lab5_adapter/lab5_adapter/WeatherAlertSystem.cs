using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_adapter
{
    // Сторонняя библиотека, предоставляющая данные о погоде.
    internal class WeatherAlertSystem
    {
        public void SendWeatherAlert(string alert)
        {
            Console.WriteLine("Weather Alert: " + alert);
        }
    }
}
