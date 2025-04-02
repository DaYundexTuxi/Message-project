using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_project.Interfaces
{
    //made an interface for PhoneNumbersManager 
    internal interface IPhoneNumbersManager
    {
        //string[] EnteredPhoneNumberArray { get; set; }

        string getEnteredPhoneNumbers();

        void fillThePhoneNumbersArray(bool processOfEnteringNumbers);

        string getTheMessage(int themeId);
    }
}
