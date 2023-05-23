using System;

namespace arayuzler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface içinde property varsa ilk değer atanmaz. Metod varsa gövdesi yazılmaz.
            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();

            SmsLogger smsLogger = new();
            smsLogger.WriteLog();

            Console.WriteLine("******* Manager Kullanıldıktan Sonra ********");

            LogManager fileLogManager = new LogManager(new FileLogger());
            LogManager dbLogManager = new LogManager(new DatabaseLogger());
            LogManager smsLogManager = new LogManager(new SmsLogger());

            fileLogManager.WriteLog();
            dbLogManager.WriteLog();
            smsLogManager.WriteLog();

            Console.ReadLine();
        }
    }
}
