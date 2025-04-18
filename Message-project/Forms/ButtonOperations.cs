﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Message_project.Interfaces;

namespace Message_project.Forms
{
    internal class ButtonOperations
    {
        public ButtonOperations() { }

        private FormsPhoneNumbersManager formsPhoneNumbersManager = new();

        private List<string> messagesToSend = [];

        public List<string> sendMessage(string phoneNumbers, string messageTheme)
        {
            // loop to enter generated message in to the list to send it back
            for (int i = 0; i < formsPhoneNumbersManager.getPhoneNumbersAmount(); i++)
            {
                string message = formsPhoneNumbersManager.getTheMessage(formsPhoneNumbersManager.getThemeID(messageTheme));
                string usedPhoneNumber = formsPhoneNumbersManager.getPhoneNumberByArrayID(i);

                string generatedMessage = $"Message to {usedPhoneNumber}: {message}";

                messagesToSend.Add(generatedMessage);
            }

            return messagesToSend;

        }
        
        public string getValidatedPhoneNumbers(string phoneNumbers)
        {
            string validatedPhoneNumbers = "";
            string[] numbersOfPhones = phoneNumbers.Split(',');

            // validating phone numbers and adding validated to list
            for (int i = 0; i < numbersOfPhones.Length; i++)
            {
                // getting rid of spaces in phone number
                string onePhoneNumber = numbersOfPhones[i].Replace(" ", "");

                if (formsPhoneNumbersManager.isValid(onePhoneNumber))
                {
                    validatedPhoneNumbers += onePhoneNumber + ", ";
                }
            }

            // getting rid of ", " on the end only if there's any numbers in list
            if (validatedPhoneNumbers.Length > 0)
            {
                validatedPhoneNumbers = validatedPhoneNumbers.Remove(validatedPhoneNumbers.Length - 2);
            }

            return validatedPhoneNumbers;
        } 

        public void clearMessagesToSend()
        {
            messagesToSend.Clear();
        }
    }
}
