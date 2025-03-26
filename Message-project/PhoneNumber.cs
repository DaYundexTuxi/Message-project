using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Message_project
{
    class PhoneNumber
    {
        // constructor for phone numbers to work further with them as objects of this class, not just an array of strings
        public PhoneNumber(string phoneNumToProceedWith)
        {
            string phoneNumber = phoneNumToProceedWith;

        }

        public static string sendTheMessage(int theme)
        {
            MessageGenerator msg = new MessageGenerator();
            string messageText = msg.generateMessageText(theme);

            return $"On the  was sent a message. Text follows: \"{messageText}\".";
        }

        public static bool isValid(string pNumberToCheck) // func to check if the phone number is valid (example: 20100230)
        {
            bool funcValue = (pNumberToCheck.Length == 8 && pNumberToCheck[0] == '2') ? true : false;
            return funcValue;
            //in the future 
        }
    }
}