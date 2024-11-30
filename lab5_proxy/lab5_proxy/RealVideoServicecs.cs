using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_proxy
{
    // Реальный класс, предоставляющий доступ к урокам
    internal class RealVideoService : IVideoService
    {
        public void AccessLesson(string lessonName)
        {
            Console.WriteLine($"Accessing lesson: {lessonName}");
        }
    }
}
