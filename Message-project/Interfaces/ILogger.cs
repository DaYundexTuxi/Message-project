using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Message_project.Interfaces
{
    internal interface ILogger
    {
        void logInfo(string message, Logger logger);

        // void logWarn(string message, Logger logger);

        // void logError(string message, Logger logger);
    }
}
