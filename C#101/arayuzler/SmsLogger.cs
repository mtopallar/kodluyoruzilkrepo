using System;

namespace arayuzler
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new System.NotImplementedException();
            Console.WriteLine("Sms olarak log yazar.");
        }
    }
}