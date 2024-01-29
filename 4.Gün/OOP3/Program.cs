using System;
using System.Collections.Generic;

namespace OOP3;

class Program
{
    static void Main(String[] args)
    {
        IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); // Interfaceler, implemente ettiği classın referansını tutabilir.
        TasitKrediManager tasitKrediManager = new TasitKrediManager();
        KonutKrediManager konutKrediManager = new KonutKrediManager();
        List<ILoggerService> loggers = new List<ILoggerService>() { new FileLoggerService(), new DatabaseLoggerService() };   
        BasvuruManager basvuruManager = new BasvuruManager();
        ILoggerService databaseloggerService = new DatabaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();
        basvuruManager.BasvuruYap(ihtiyacKrediManager, loggers); 

        List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager};
        // basvuruManager.KrediOnBilgilendirmesiYap(krediler);


    }
}
