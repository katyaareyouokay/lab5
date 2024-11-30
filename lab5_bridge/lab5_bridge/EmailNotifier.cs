using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_bridge
{
    // отправка email
    internal class EmailNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Отправка Email: {message}");
        }
    }
}
