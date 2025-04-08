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
        // making instance to use, furter will make it work with DI
        private readonly IPhoneNumbersManager _phoneNumbersManager = new FormsPhoneNumbersManager();

        // some fields for button functions
        private string inputedPhones = "";
        private string usedTheme = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void SendMessages_Click(object sender, EventArgs e)
        {
            // take numbers, divide them from one string to substrings, send each a message and show number and the message + have a choice between 3 
            inputedPhones = txtbPhoneNumbersInput.Text;
            // message.sendMessage(phonenumber, theme); (with for loop)

            // clear the label
            lblTextOutput1.Text = " ";
            
           // write down used theme\s in lblTextOutput1
            foreach (var item in clbListOfThemes.CheckedItems)
            {
                lblTextOutput1.Text += " " + item.ToString();
            }

            // returning the message using picked theme
            if (lblTextOutput1.Text != "")
            {
                usedTheme = lblTextOutput1.Text; // giving 
                lblTextOutput2.Text = inputedPhones;

                // loop to fill textOutput with generated messages 
                for (int i = 0; i <= _phoneNumbersManager.getPhoneNumbersAmount() ; i++)
                {

                    string message = _phoneNumbersManager.getTheMessage();
                    lbxResultOutput.Items.Add();
                }

            }
            else
            {
                lblTextOutput2.Text = "No picked themes to use";
            }

        }

    }
}
