using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_project
{
    internal interface IMassage // Interface  to further inherit the basics of the message such as the text, theme, etc. in other classes
    {
        string Theme { get; set; }
        string MessageText { get; set; }

        
    }
}
