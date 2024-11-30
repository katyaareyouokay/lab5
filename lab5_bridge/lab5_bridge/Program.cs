using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Устройства
            INotifier smsNotifier = new SMSNotifier();
            INotifier emailNotifier = new EmailNotifier();
            // Уведомления
            Notification weatherViaSMS = new WeatherNotification(smsNotifier);
            Notification incidentViaEmail = new IncidentNotification(emailNotifier);
            weatherViaSMS.Send("Солнечно, 25°C");
            incidentViaEmail.Send("ДТП на главной улице");
            Console.ReadKey();
        }
    }
}
