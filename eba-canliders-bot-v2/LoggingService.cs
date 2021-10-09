using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace eba_canliders_bot_v2
{
    public static class LoggingService
    {
        public static void WriteLog(string message) 
        {
            string logPath = @"log.txt";

            using (StreamWriter writer = new StreamWriter(logPath, true))
            {

                writer.WriteLine($"{DateTime.Now} : {message}");

            }
        }
    }
}
