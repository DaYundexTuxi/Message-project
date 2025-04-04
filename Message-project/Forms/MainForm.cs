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
//using NLog;

namespace Message_project.Classes
{
    public partial class MainForm : Form
    {
        private readonly IPhoneNumbersManager _phoneNumbersManager = new PhoneNumbersManager();
        private readonly IMessage _message = new MessageGenerator();

        public MainForm()
        {
            InitializeComponent();
        }

        private string inputedPhones = "";


        private void SendMessages_Click(object sender, EventArgs e)
        {
            // take numbers, divide them from one string to substrings, send each a message and show number and the message + have a choice between 3 
            inputedPhones = txtbPhoneNumbersInput.Text;
            // message.sendMessage(phonenumber, theme); (with for loop)

            // clear the label
            lblTextOutput1.Text = " ";

            foreach (var item in clbListOfThemes.CheckedItems)
            {
                lblTextOutput1.Text += " " + item.ToString();
            }

            //lblTextOutput1.Text = inputedPhones;
            
        }

    }
}
