using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_adapter
{
    // Интерфейс нашей системы для отправки сообщений об активности.
    internal interface IActivityNotifier
    {
        void Notify(string message);
    }
}
