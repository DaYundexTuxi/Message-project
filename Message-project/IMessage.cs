using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_project
{
    internal interface IMessage
    {
        // interface - base for making messages (for console - plain text, for )
        string getThemesList(ILogger logger) { string a = ""; return a; } 

        string generateMessageText(int themeId, ILogger logger) { string a = ""; return a; } 
    }
}
