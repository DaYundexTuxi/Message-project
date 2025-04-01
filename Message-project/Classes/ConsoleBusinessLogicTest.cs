using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Message_project.Interfaces;

namespace Message_project.Classes
{
    internal class ConsoleBusinessLogicTest
    {
        private readonly IMessage _mg;
        private readonly ILogger _logger;
        private readonly IPhoneNumbersManager _phoneNumbersManager;

        public ConsoleBusinessLogicTest(IMessage mg, ILogger logger, IPhoneNumbersManager phoneNumbersManager)
        {
            _mg = mg;
            _logger = logger;
            _phoneNumbersManager = phoneNumbersManager;
        }

        public void test()
        {

            _phoneNumbersManager.fillThePhoneNumbersArray(true);

            // showing the list of entered phone numbers
            Console.WriteLine(_phoneNumbersManager.getEnteredPhoneNumbers());

            //asking for sending email 
            Console.Write($"You have entered {PhoneNumbersManager.enteredPhoneNumberArray.Length} phone numbers, do you want to send them an sms?(y/n): ");
            char answerAboutSendingSMS = Convert.ToChar(Console.ReadLine());

            //asking for the theme of a message 
            Console.Write($"You can choose the theme from this list(write the number of theme):");
            // printing out the list of themes

            Console.WriteLine(_mg.getThemesList());
            int enteredTheme = Convert.ToInt32(Console.ReadLine());

            //if asnwer yes - sends the message (rn only generates the message and gives it back as text)
            if (answerAboutSendingSMS == 'y')
            {
                foreach (string individualPhoneNumber in PhoneNumbersManager.enteredPhoneNumberArray)
                {
                    PhoneNumbersManager usedPhoneNumber = new PhoneNumbersManager(individualPhoneNumber);
                    Console.WriteLine(_phoneNumbersManager.getTheMessage(enteredTheme));
                }
            }
            else
            {
                Console.WriteLine("ok-");
            }
        }
    }
}
