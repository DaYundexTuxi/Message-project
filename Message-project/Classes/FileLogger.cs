using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Message_project.interfaces;

namespace Message_project.Classes
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
