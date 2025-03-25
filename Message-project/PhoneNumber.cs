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
        public PhoneNumber(string phoneNumToProceedWith) // constructor for phone numbers to work further with them as objects of this class, not just an array of strings
        {
            string phoneNumber = phoneNumToProceedWith;

            string sendTheMessage(string theme) // function for sending message (atm as a string) returning text (with content of the message) about being succesfully sended
            { 

                MessageConstructor.generateMessageText(theme); // !!!!!!!!!!!!!!!!!! 
                
                return $"On the {phoneNumber} was sent a message. Text follows: \"{messageText}\".";
            }

            void puk()
            {

            }
        }

        public static bool isValid(string pNumberToCheck) // func to check if the phone number is valid (example: 20100230)
        {
            bool funcValue = (pNumberToCheck.Length == 8 && pNumberToCheck[0] == 2) ? true : false;
            return funcValue;
        }
        
    }
}

