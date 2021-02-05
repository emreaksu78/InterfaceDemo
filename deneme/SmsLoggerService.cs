using System;
using System.Collections.Generic;
using System.Text;

namespace deneme
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms yollandı");
        }
    }
}
