using System;

namespace deneme
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya yollandı");
        }
    }
}
