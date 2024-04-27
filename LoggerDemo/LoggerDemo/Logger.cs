using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.IO;

namespace LoggerDemo
{
    public static class Logger
    {
        public static void WriteLogMessage(string message)
        {
            string logpath = ConfigurationManager.AppSettings["logPath"];
            using(StreamWriter writer=new StreamWriter(logpath))
            {
                writer.WriteLine($"{DateTime.Now} : {message}");
            }
        }
    }
}
