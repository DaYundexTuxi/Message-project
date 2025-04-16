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

        // take numbers, divide them from one string to substrings, send each a message and show number and the message + have a choice between 3 themes      
        private async Task SendMessages_Click(object sender, EventArgs e)
        {
            // button for message box
            MessageBoxButtons btnOK = MessageBoxButtons.OK;

            // clear filled themes and phoneNumbers labels
            lblInputedTheme.Text = "";
            lblInputedPhoneNumbers.Text = "";

            string validatedPhoneNumbers = _buttonOperations.getValidatedPhoneNumbers(txtbPhoneNumbersInput.Text);

            if (clbListOfThemes.CheckedItems.Count == 1 && validatedPhoneNumbers != "")
            {
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

                // -------------------------------------------- comment all code in this method below to see how it works right now

                DeviceInformationCollection serialDeviceInfos = await DeviceInformation.FindAllAsync(SerialDevice.GetDeviceSelector());

                foreach (DeviceInformation serialDeviceInfo in serialDeviceInfos)
                {
                    try
                    {
                        SerialDevice serialDevice = await SerialDevice.FromIdAsync(serialDeviceInfo.Id);

                        if (serialDevice != null)
                        {
                            // Found a valid serial device.

                            // Reading a byte from the serial device.
                            DataReader dr = new DataReader(serialDevice.InputStream);
                            int readByte = dr.ReadByte();

                            // Writing a byte to the serial device.
                            DataWriter dw = new DataWriter(serialDevice.OutputStream);
                            dw.WriteByte(0x42);
                        }
                    }
                    catch (Exception)
                    {
                        // Couldn't instantiate the device
                    }
                }

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
