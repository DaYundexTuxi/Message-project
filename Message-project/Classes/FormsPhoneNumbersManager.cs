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

        public static string[] enteredPhoneNumberArray = { };

        private readonly Logger fileLogger = NLog.LogManager.GetCurrentClassLogger();
        private readonly FileLogger loggerr = new FileLogger();

        static readonly IMessage messageGenerator = new MessageGenerator();

        public void fillThePhoneNumbersArray(string phoneNumbers)
        {
            enteredPhoneNumberArray = phoneNumbers.Split(',');

        }

        public string getEnteredPhoneNumbers()
        {
            throw new NotImplementedException();
        }

        public string getTheMessage(int themeId)
        {
            string messageText = messageGenerator.getGeneratedMessageText(themeId);
            loggerr.logInfo(messageText, fileLogger);
            return $"On the  was sent a message. Text follows: \"{messageText}\".";
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
