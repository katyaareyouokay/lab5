using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_bridge
{
    // Абстракция уведомлений
    internal abstract class Notification
    {
        protected INotifier notifier;

        public Notification(INotifier notifier)
        {
            this.notifier = notifier;
        }

        public abstract void Send(string message);
    }
}
