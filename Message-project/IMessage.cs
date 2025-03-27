using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Message_project
{
    internal interface IMessage
    {
        // interface - base for making messages (for console - plain text, for )
        void sendMessage(string phoneNumber, ILogger logger) { }

        void writeThemesList() { }

        // !!!!!!!!!!!
        string generateMessageText(int themeId, ILogger logger) { string a = ""; return a; } // here to make it virtual
    }
}
