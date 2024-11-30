using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_bridge
{
    // отправка смс
    internal class SMSNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Отправка СМС: {message}");
        }
    }
}

