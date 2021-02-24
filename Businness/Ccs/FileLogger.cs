using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Ccs
{
    public class FileLogger : IILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
