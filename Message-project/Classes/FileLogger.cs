using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Message_project.Interfaces;
using Microsoft.Extensions.Logging;
using NLog;

namespace Message_project.Forms
{
    internal class FileLogger : Interfaces.ILogger
    {

        public void logInfo(string infoMessage, Logger logger)
        {
            logger.Info("Info message: {message} from: {username}", infoMessage, "aboba");
        }

        //public void logWarn(string warningMessage, Logger logger)
        //{
        //    logger.Warn("Warning message: {message}, from:{}", warningMessage);
        //}

        //public void logError(string errorMessage, Logger logger)
        //{
        //    logger.Warn("Error message: {message}, from:{}", errorMessage);
        //}
    }
}
