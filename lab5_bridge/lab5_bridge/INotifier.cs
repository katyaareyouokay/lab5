using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_bridge
{
    // Интерфейс устройства для оповещения
    internal interface INotifier
    {
        void Notify(string message);
    }
}
