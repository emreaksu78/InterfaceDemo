using System;
using System.Collections.Generic;
using System.Text;

namespace deneme
{
    class BasvuruManager
    {
        public void BasvuruYap(List<IKrediManager> krediManager, List<ILoggerService> loggerServices)
        {
            foreach (var kredi in krediManager)
            {
                kredi.Hesapla();
            }

            foreach (var log in loggerServices)
            {
                log.Log();
            }

        }
    }
}
