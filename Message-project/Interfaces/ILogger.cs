﻿using System;
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
        void Log(string message);
    }
}
