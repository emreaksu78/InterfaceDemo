using System;

namespace deneme
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına yollandı");
        }
    }
}
