using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_adapter
{
    // Адаптер между WeatherAlertSystem и IActivityNotifier.
    internal class ActivityNotifierAdapter : IActivityNotifier
    {
        private WeatherAlertSystem _weatherAlertSystem;

        public ActivityNotifierAdapter(WeatherAlertSystem weatherAlertSystem)
        {
            _weatherAlertSystem = weatherAlertSystem;
        }

        public void Notify(string message)
        {
            // Адаптируем метод оповещения о погоде для наших нужд.
            _weatherAlertSystem.SendWeatherAlert("Outdoor Activity: " + message);
        }
    }
}
