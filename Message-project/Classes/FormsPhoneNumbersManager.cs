using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using Message_project.Interfaces;

namespace Message_project.Forms
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
            enteredPhoneNumberArray = [.. phoneNumbers.Split(',').Select(phoneNum => phoneNum.Trim())];
        }

        public void clearPhoneNumbersArray()
        {
            enteredPhoneNumberArray = [];
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

        public string getPhoneNumberByArrayID(int id)
        {
            return enteredPhoneNumberArray[id];
        }

        // generating the message by used theme and returning it as string + logging the message in file
        public string getTheMessage(int themeId)
        {
            string messageText = messageGenerator.getGeneratedMessageText(themeId);
            loggerr.logInfo(messageText, fileLogger);
            return $"{messageText}";
        }

        // method to simply validate if phone number is real (exmpl. : 23544563)
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

        // method to get theme's ID comparing it to the themesDictionary dictionaries values
        public int getThemeID(string theme)
        {
            // getting rid of spaces and apostrophes
            string cleanTheme = theme.Replace(" ", "").Replace("'", "");

            // default value for theme is 0 -> will cause an error
            int id = 0;

            //can get rid of it by lambda function -> var dictItem = MessageGenerator.themesDictionary.FirstOrDefault(t => t.value == theme.Trim())

            for (int i = 1; i <= messageGenerator.getThemesCount(); i++)
            {
                string currentTheme = MessageGenerator.themesDictionary[i];

                if (currentTheme.Trim() == cleanTheme)
                {
                    id = i;
                    break;
                }
            }

            return id;
        }
    }
}
