using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Сторонняя библиотека
            WeatherAlertSystem weatherAlertSystem = new WeatherAlertSystem();
            // Используем адаптер для интеграции
            IActivityNotifier activityNotifier = new ActivityNotifierAdapter(weatherAlertSystem);
            // Отправляем сообщение через адаптированный интерфейс
            activityNotifier.Notify("It's a great day for hiking!");
            Console.ReadKey();
        }
    }
}
