using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager IhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager TasitKrediManager = new TasitKrediManager();
            IKrediManager KonutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(IhtiyacKrediManager, FileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { IhtiyacKrediManager };

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

       
        }
    }
}
