using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace DonateKart_Backend.Logger
{
    public class FileLogger:IFileLogger
    {
     
            public void AddtoLogfile(string logDetails)
            {
                string path = @"C:\LogData.txt";
                if (!File.Exists(path))
                {
                    File.Create(path);
                    TextWriter tw = new StreamWriter(path);
                    File.AppendAllText(path, logDetails + Environment.NewLine);
                    tw.Close();
                }
                else
                {
                    using (var tw = new StreamWriter(path, true))
                    {
                        File.AppendAllText(path, logDetails + Environment.NewLine);
                    }
                }
            }

        
    }
}
