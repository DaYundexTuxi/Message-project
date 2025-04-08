using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using Message_project.Interfaces;

namespace Message_project.Classes
{
    internal class FormsPhoneNumbersManager : IPhoneNumbersManager
    {

        private static string[] enteredPhoneNumberArray = { };

        private readonly Logger fileLogger = NLog.LogManager.GetCurrentClassLogger();
        private readonly FileLogger loggerr = new FileLogger();

        static readonly IMessage messageGenerator = new MessageGenerator();

        public FormsPhoneNumbersManager() { }

        public void fillThePhoneNumbersArray(string phoneNumbers)
        {
            enteredPhoneNumberArray = phoneNumbers.Split(',');
        }

        public string getEnteredPhoneNumbers()
        {
            string phoneNumberList = "";
            foreach (string phoneNumber in enteredPhoneNumberArray)
            {
                phoneNumberList += $"{phoneNumber} \n";
            }
            return phoneNumberList.Trim();
        }

        public int getPhoneNumbersAmount()
        {
            return enteredPhoneNumberArray.Length;
        }

        public string getTheMessage(int themeId)
        {
            string messageText = messageGenerator.getGeneratedMessageText(themeId);
            loggerr.logInfo(messageText, fileLogger);
            return $"\"{messageText}\".";
        }

        public bool isValid(string pNumberToCheck)
        {
            if (pNumberToCheck == null)
            {
                return false;
            }
            else
            {
                bool funcValue = pNumberToCheck.Length == 8 && pNumberToCheck[0] == '2';
                return funcValue;
            }

            
        }
    }
}
