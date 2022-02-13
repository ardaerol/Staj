using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService , ILoggerService loggerService2)
        {
            //Başvuran bilgilerini değerlendirme
            //
            
            krediManager.Hesapla();
            loggerService.Log();
            loggerService2.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
