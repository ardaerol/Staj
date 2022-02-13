using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();
            ILoggerService smsmLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,databaseLoggerService,smsmLoggerService);
            
            BasvuruManager basvuruManager2 = new BasvuruManager();
            basvuruManager2.BasvuruYap(ihtiyacKrediManager, fileLogerService,smsmLoggerService);

            BasvuruManager basvuruManager3 = new BasvuruManager();
            basvuruManager3.BasvuruYap(esnafKrediManager,databaseLoggerService,smsmLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            

        }
    }
}
