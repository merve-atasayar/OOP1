using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection 
        public void BasvuruYap(IKrediManager kredimanager, ILoggerService loggerService) 
        {
            // başvuran bilgilerinin değerlendirme
            //
            kredimanager.Hesapla();
            loggerService.Log();
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
