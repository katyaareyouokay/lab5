using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_proxy
{
    // Прокси-класс для контроля доступа
    internal class VideoServiceProxy : IVideoService
    {
        private RealVideoService _realVideoService;
        private bool _hasPremiumAccess;

        public VideoServiceProxy(bool hasPremiumAccess)
        {
            _realVideoService = new RealVideoService();
            _hasPremiumAccess = hasPremiumAccess;
        }

        public void AccessLesson(string lessonName)
        {
            if (_hasPremiumAccess)
            {
                _realVideoService.AccessLesson(lessonName);
            }
            else
            {
                Console.WriteLine("Access denied. Upgrade to premium to access this lesson.");
            }
        }
    }

}
