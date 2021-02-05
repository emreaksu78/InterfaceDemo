using System;
using System.Collections.Generic;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IKrediManager> krediManagers = new List<IKrediManager>() {new EsnafKrediManager(), new IhtiyacKrediManager(), new TasitKrediManager() };

            List<ILoggerService> loggerServices = new List<ILoggerService>() { new SmsLoggerService(), new FileLoggerService(), new DatabaseLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(krediManagers,loggerServices);



            

        }
    }
}
