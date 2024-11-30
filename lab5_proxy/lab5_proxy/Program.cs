using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVideoService freeUser = new VideoServiceProxy(false);
            IVideoService premiumUser = new VideoServiceProxy(true);

            // Попытка доступа для пользователя с обычной подпиской
            freeUser.AccessLesson("Advanced Design Patterns");

            // Попытка доступа для пользователя с премиум подпиской
            premiumUser.AccessLesson("Advanced Design Patterns");
            Console.ReadKey();
        }
    }
}
