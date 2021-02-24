using System;

namespace Businness.Ccs
{
    public class DataBaseLogger : IILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
