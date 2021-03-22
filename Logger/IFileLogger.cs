using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonateKart_Backend.Logger
{
    interface IFileLogger
    {
        void AddtoLogfile(string logData);
    }
}
