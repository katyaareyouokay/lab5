using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_bridge
{
    // Конкреные уведомления о проишествии
    internal class IncidentNotification : Notification
    {
        public IncidentNotification(INotifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            notifier.Notify($"Уведомление о происшествии: {message}");
        }
    }
}
