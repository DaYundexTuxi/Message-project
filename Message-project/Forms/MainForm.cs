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
        double inputedSendDelay = 0d;

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

            // clear filled themes and phoneNumbers labels - displaying used phone numbers and (if used) theme
            lblInputedTheme.Text = "";
            lblInputedPhoneNumbers.Text = "";
            
            // using inputed phone numbers and getting back string of only validated numbers (e.g. 20394823) 
            string validatedPhoneNumbers = _buttonOperations.getValidatedPhoneNumbers(txtbPhoneNumbersInput.Text);
            // writing down the send delay for message
            string sendDelayString = "";

            // stops method in case when there's no entered phone numbers
            if (validatedPhoneNumbers == "")
            {
                MessageBox.Show("You don\'t have any correсt phone number entered. Check them please.", "Phone error", btnOK, MessageBoxIcon.Error);
                return;
            }

            if (clbListOfThemes.CheckedItems.Count == 1 && rtbCustomMessage.Text != "")
            {
                MessageBox.Show("You can\'t send a custom written message with a theme", "Wrong message writing usage", btnOK, MessageBoxIcon.Error);
                return;
            }

            if (clbListOfThemes.CheckedItems.Count == 0 && rtbCustomMessage.Text == "")
            {
                MessageBox.Show("You need to either choose a theme or write a custom message.", "No message to send", btnOK, MessageBoxIcon.Error);
                return;
            }

            if (clbListOfThemes.CheckedItems.Count > 1)
            {
                MessageBox.Show("You can\'t use more than 1 theme", "Wrong theme choice usage", btnOK, MessageBoxIcon.Error);
                return;
            }

            // checking if user entered the delay right - if yes, using it
            if (txtbSendDelay.Text != "")
            {
                try
                {
                    double inputedSendDelay = Convert.ToDouble(txtbSendDelay.Text);
                    sendDelayString = "(" + txtbSendDelay.Text + ")";
                }
                catch (Exception)
                {
                    MessageBox.Show("You need to write down right time to send", "Wrong send delay usage", btnOK, MessageBoxIcon.Error);
                    return;
                }
            }
            
            // if statement to chose what exact method to use - pre-generated message or a custom one
            if (clbListOfThemes.CheckedItems.Count == 1 && rtbCustomMessage.Text == "")
            {
                // the pre-generated messages variant 
                string chosenTheme = clbListOfThemes.CheckedItems[0].ToString();

                _phoneNumbersManager.fillThePhoneNumbersArray(validatedPhoneNumbers);

                
                List<string> sendedMessages = _buttonOperations.sendMessage(validatedPhoneNumbers, chosenTheme);

                lblInputedTheme.Text = "Theme: " + chosenTheme;
                lblInputedPhoneNumbers.Text = "Phone numbers: " + validatedPhoneNumbers;

                for (int i = 0; i < sendedMessages.Count; i++)
                {
                    txtbResults.Text += $"Message ({_phoneNumbersManager.getPhoneNumberByArrayID(i)}): {sendedMessages[i]}"  + "\r\n";
                }

                /* here is needed part of code that actually sends the messages using delay (inputedSendDelay)
                    
                */

                // clearing array with used, not needed information for further use
                _phoneNumbersManager.clearPhoneNumbersArray();
                _buttonOperations.clearMessagesToSend();
            } 
            else 
            {
                // the custom message variant
                lblInputedTheme.Text = "Theme: Custom";
                lblInputedPhoneNumbers.Text = "Phone numbers: " + validatedPhoneNumbers;

                string writedCustomMessage = rtbCustomMessage.Text;
                string fullSendedMessage;
                string[] validatedPhoneNumbersArray = validatedPhoneNumbers.Split(",");

                for (int i = 0; i < validatedPhoneNumbersArray.Length; i++)
                {
                    fullSendedMessage = $"Message ({validatedPhoneNumbersArray[i]}){sendDelayString}: {writedCustomMessage}";
                    txtbResults.Text += fullSendedMessage + "\r\n";
                }

                /* here is needed part of code that actually sends the messages using delay (inputedSendDelay)
                    
                */
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
