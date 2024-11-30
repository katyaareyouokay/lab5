using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_bridge
{
    // Конкретные уведомления о погоде
    internal class WeatherNotification : Notification
    {
        public WeatherNotification(INotifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            notifier.Notify($"Погодное уведомление: {message}");
        }
    }
}
