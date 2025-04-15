using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.System.UserProfile;

using System.IO.Ports;
using Message_project.Interfaces;

//using NLog;

// model view controller

namespace Message_project.Forms
{
    public partial class MainForm : Form
    {
        // some instances for button functions
        private readonly FormsPhoneNumbersManager _phoneNumbersManager = new();
        private readonly ButtonOperations _buttonOperations = new();

        // will be used for random delay for sending message - not done!
        Random rnd = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void SendMessages_Click(object sender, EventArgs e)
        {
            // take numbers, divide them from one string to substrings, send each a message and show number and the message + have a choice between 3 

            // clear fillef themes and phoneNumbers labels
            lblInputedTheme.Text = "";
            lblInputedPhoneNumbers.Text = "";

            // clear textbox for numbers and for themes
            //txtbPhoneNumbersInput.Text = "";

            MessageBoxButtons btnOK = MessageBoxButtons.OK;



            string validatedPhoneNumbers = _buttonOperations.getValidatedPhoneNumbers(txtbPhoneNumbersInput.Text);

            if (clbListOfThemes.CheckedItems.Count == 1 && validatedPhoneNumbers != "")
            {
                string chosenTheme = clbListOfThemes.CheckedItems[0].ToString();

                _phoneNumbersManager.fillThePhoneNumbersArray(validatedPhoneNumbers);

                List<string> sendedMessages = _buttonOperations.sendMessage(validatedPhoneNumbers, chosenTheme);

                foreach (string listItem in sendedMessages)
                {
                    lbxResultOutput.Items.Add(listItem);
                }

                _phoneNumbersManager.clearPhoneNumbersArray();
                _buttonOperations.clearMessagesToSend();
            }
            else
            {
                MessageBox.Show("There\'s something wrong with provided information, check it please.", "Error in provided information", btnOK, MessageBoxIcon.Error);
            }

        }

        private void btnPastePhoneNumbers_Click(object sender, EventArgs e)
        {
            txtbPhoneNumbersInput.Text = Clipboard.GetText();
        }

    }
}
