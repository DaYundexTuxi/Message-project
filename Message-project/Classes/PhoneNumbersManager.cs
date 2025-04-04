using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Message_project.Interfaces;
using NLog;

namespace Message_project.Classes
{
    internal class PhoneNumbersManager : IPhoneNumbersManager
    {
        // making an array for storing entered phone numbers (from fillThePhoneNumbersArray())
        public static string[] enteredPhoneNumberArray = { };

        // bool field for while cycle from fillThePhoneNumbersArray()
        bool processOfEnteringNumbers;

        // creating an instance of MessageGenerator
        static readonly IMessage messageGenerator = new MessageGenerator();

        // creating logger
        private Logger fileLogger = NLog.LogManager.GetCurrentClassLogger();
        private FileLogger loggerr = new FileLogger();

        // empty constructor for handler
        public PhoneNumbersManager() {}
        
        // constructor for phone numbers to work further with them as objects of this class, not just an array of strings
        public PhoneNumbersManager(string phoneNumToProceedWith)
        {
            string phoneNumber = phoneNumToProceedWith;
        }

        // give out the string of all entered phone numbers
        public string getEnteredPhoneNumbers()
        {
            string phoneNumberList = "";
            foreach (string phoneNumber in enteredPhoneNumberArray)
            {
                phoneNumberList += $"{phoneNumber} \n";
            }
            return phoneNumberList.Trim();
        }

        // method for inputing phone numbers
        public void fillThePhoneNumbersArray(string a)
        {
            processOfEnteringNumbers = true;
            Console.WriteLine("Enter the desired phone numbers: ");
            Console.WriteLine("You can enter \'exit\' to exit the entering the numbers");
            while (processOfEnteringNumbers)
            {
                string inputedPhoneNumber = Console.ReadLine();

                if (inputedPhoneNumber == "exit")
                {
                    break;
                }
                else if (isValid(inputedPhoneNumber))
                {
                    enteredPhoneNumberArray = enteredPhoneNumberArray.Concat([inputedPhoneNumber]).ToArray(); // creates a new array and adds inputedPhoneNumber to it
                    //fileLogger.Log("");
                }
                else
                {
                    Console.WriteLine("Invalid number entered, try again.");
                }
            }
        }

        // get's the messagetext to send by passing the theme ID
        public string getTheMessage(int themeId) // , ILogger fileLogger
        {
            string messageText = messageGenerator.getGeneratedMessageText(themeId);
            loggerr.logInfo(messageText, fileLogger);
            return $"On the  was sent a message. Text follows: \"{messageText}\".";
        }

        // func to check if the phone number is valid (example: 20100230)
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
            //in the future 
        }
    }
}