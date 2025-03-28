using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_project
{
    internal class FileLogger : ILogger
    {
        
        public void Log(string message)
        {
            var fileLogger = NLog.LogManager.GetCurrentClassLogger();

            fileLogger.Info("Just info: {message} from: {username}", message, "aboba");
            NLog.LogManager.Shutdown();
        }
    }
}
