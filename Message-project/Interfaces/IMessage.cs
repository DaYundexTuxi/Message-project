using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_project.interfaces
{
    internal interface IMessage
    {
        // interface - base for making messages (for console - plain text, for )

        string getThemesList();

        string getGeneratedMessageText(int themeId, ILogger logger);
    }
}
