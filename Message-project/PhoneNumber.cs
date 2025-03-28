using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Message_project
{
    class PhoneNumbers
    {
        // creating an instance of MessageGenerator
        static readonly IMessage messageGenerator = new MessageGenerator();

        // creating logger
        static ILogger fileLogger = new FileLogger();

        // constructor for phone numbers to work further with them as objects of this class, not just an array of strings
        public PhoneNumbers(string phoneNumToProceedWith)
        {
            string phoneNumber = phoneNumToProceedWith;
        }

        // get's the messagetext to send by entering the theme ID

        // !!!!!!!!!!!!!!!!!!!! if i make IMessage.generateMessageText() return void - need to make the MessageGenerator.generateMessageText() somehow void too (maybe make the one in Interface - virtual? and rewrite return from void to string)
        public static string getTheMessage(int themeId)
        {
            string messageText = messageGenerator.generateMessageText(themeId, fileLogger); // HERE IT'S USED
            return $"On the  was sent a message. Text follows: \"{messageText}\".";
        }

        // func to check if the phone number is valid (example: 20100230)
        public static bool isValid(string pNumberToCheck) 
        {
            bool funcValue = (pNumberToCheck.Length == 8 && pNumberToCheck[0] == '2') ? true : false;
            return funcValue;
            //in the future 
        }
    }
}