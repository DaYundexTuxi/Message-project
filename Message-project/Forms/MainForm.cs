using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Message_project.Interfaces;

using System.IO.Ports;
using System.Threading;
using Windows.Devices.SerialCommunication;
using Windows.Devices.Enumeration;
using Windows.Storage.Streams;
using System.Diagnostics.Eventing.Reader;

//using NLog;

// model view controller

namespace Message_project.Forms
{
    public partial class MainForm : Form
    {
        // some fields just for button functions
        private readonly FormsPhoneNumbersManager _phoneNumbersManager = new();
        private readonly ButtonOperations _buttonOperations = new();

        // field to get subscribed for event and use it 
        private CheckForReplies _checkForReplies;

        public MainForm()
        {
            _checkForReplies = new CheckForReplies();
            _checkForReplies.CheckForRepliesEvent += OnCheckForReplies;
            InitializeComponent();
        }

        // the main function of the program - send a pre-generated message, or a custom one to inputed phone numbers by choosing a theme or\and entering numbers
        private void SendMessages_Click(object sender, EventArgs e)
        {
            // declarting a OKbutton for message box
            MessageBoxButtons btnOK = MessageBoxButtons.OK;

            // clear filled themes and phoneNumbers labels
            lblInputedTheme.Text = "";
            lblInputedPhoneNumbers.Text = "";
            
            // sending inputed phone numbers and returning only validated (e.g. 20394823) 
            string validatedPhoneNumbers = _buttonOperations.getValidatedPhoneNumbers(txtbPhoneNumbersInput.Text);

            // if statement to chose what exact method to use - pre-generated mesage or a custom one
            if (clbListOfThemes.CheckedItems.Count == 1 && validatedPhoneNumbers != "" && rtbCustomMessage.Text == "")
            {
                // the pre-generated messages variant 
                string chosenTheme = clbListOfThemes.CheckedItems[0].ToString();

                _phoneNumbersManager.fillThePhoneNumbersArray(validatedPhoneNumbers);

                
                List<string> sendedMessages = _buttonOperations.sendMessage(validatedPhoneNumbers, chosenTheme);

                lblInputedTheme.Text = "Theme: " + chosenTheme;
                lblInputedPhoneNumbers.Text = "Phone numbers: " + validatedPhoneNumbers;

                foreach (string listItem in sendedMessages)
                {
                    lbxResultOutput.Items.Add(listItem);
                }

                _phoneNumbersManager.clearPhoneNumbersArray();
                _buttonOperations.clearMessagesToSend();
            } 
            else if (clbListOfThemes.CheckedItems.Count == 0 && validatedPhoneNumbers != "" && rtbCustomMessage.Text != "")
            {
                // the custom message variant
                lblInputedTheme.Text = "Theme: Custom";
                lblInputedPhoneNumbers.Text = "Phone numbers: " + validatedPhoneNumbers;

                string writedCustomMessage = rtbCustomMessage.Text;
                string fullSendedMessage;
                string[] validatedPhoneNumbersArray = validatedPhoneNumbers.Split(",");


                for (int i = 0; i < validatedPhoneNumbersArray.Length; i++)
                {
                    fullSendedMessage = $"Message ({validatedPhoneNumbersArray[i]}): {writedCustomMessage}";
                    lbxResultOutput.Items.Add(fullSendedMessage);
                }
            }
            else
            {
                // in case (pre-generated messages) entered phone numbers or theme are empty; (custom message) in case entered phone numbers are empty  
                MessageBox.Show("There\'s something wrong with provided information, check it please.", "Error in provided information", btnOK, MessageBoxIcon.Error);
            }

        }

        private void btnPastePhoneNumbers_Click(object sender, EventArgs e)
        {
            txtbPhoneNumbersInput.Text = Clipboard.GetText();
        }

        private void OnCheckForReplies(object sender, bool hasNewReplies)
        {
            if (hasNewReplies)
            {
                // a function to check for replies
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _checkForReplies.StartAsync();
        }
    }
}
