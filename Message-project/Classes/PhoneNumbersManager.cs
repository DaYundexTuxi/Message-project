using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Message_project.interfaces;

namespace Message_project.Classes
{
    internal class PhoneNumbersManager
    {
        public static string[] enteredPhoneNumberArray = { };
        
        // creating an instance of MessageGenerator
        static readonly IMessage messageGenerator = new MessageGenerator();

        // creating logger
        static ILogger fileLogger = new FileLogger();

        // constructor for phone numbers to work further with them as objects of this class, not just an array of strings
        public PhoneNumbersManager(string phoneNumToProceedWith)
        {
            string phoneNumber = phoneNumToProceedWith;
        }

        // give out the string of all 
        public static string getEnteredPhoneNumbers()
        {
                
            string phoneNumberList = string.Empty;
            foreach (string phoneNumber in enteredPhoneNumberArray)
            {
                phoneNumberList += $"{phoneNumber} \n";
            }
            return phoneNumberList.Trim();
        }

        // method for inputing phone numbers
        public static void fillThePhoneNumbersArray(bool processOfEnteringNumbers)
        {
            Console.WriteLine("Enter the desired phone numbers: ");
            Console.WriteLine("You can enter \'exit\' to exit the entering the numbers");
            while (processOfEnteringNumbers)
            {
                string inputedText = Console.ReadLine();

                if (inputedText == "exit")
                {
                    break;
                }
                else if (isValid(inputedText))
                {
                    enteredPhoneNumberArray = enteredPhoneNumberArray.Concat(new string[] { inputedText }).ToArray(); // creates a new array and adds to it 
                    fileLogger.Log("");
                }
                else
                {
                    Console.WriteLine("Invalid number entered, try again.");
                }
            }
        }

        // get's the messagetext to send by passing the theme ID
        public static string getTheMessage(int themeId, ILogger fileLogger)
        {
            string messageText = messageGenerator.getGeneratedMessageText(themeId, fileLogger); // HERE IT'S USED
            return $"On the  was sent a message. Text follows: \"{messageText}\".";
        }

        // func to check if the phone number is valid (example: 20100230)
        public static bool isValid(string pNumberToCheck) 
        {
            bool funcValue = pNumberToCheck.Length == 8 && pNumberToCheck[0] == '2' ? true : false;
            return funcValue;
            //in the future 
        }
    }
}