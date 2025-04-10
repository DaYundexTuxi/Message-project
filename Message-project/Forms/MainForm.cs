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

namespace Message_project.Classes
{
    public partial class MainForm : Form
    {
        // making instance to use, furter will make it work with DI
        private readonly IPhoneNumbersManager _phoneNumbersManager = new FormsPhoneNumbersManager();

        // some fields for button functions
        private string inputedPhoneNumbers = "";
        private string usedTheme = "";

        // will be used for random delay to send the message
        Random rnd = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void SendMessages_Click(object sender, EventArgs e)
        {
            // take numbers, divide them from one string to substrings, send each a message and show number and the message + have a choice between 3 
            inputedPhoneNumbers = txtbPhoneNumbersInput.Text;
            _phoneNumbersManager.fillThePhoneNumbersArray(inputedPhoneNumbers);

            // clear themes and phoneNumbers labels
            lblInputedTheme.Text = "";
            lblInputedPhoneNumbers.Text = "";

            // clear textbox for numbers and for themes
            //txtbPhoneNumbersInput.Text = "";


            //// write down used theme\s in lblTextOutput1 (really need to remake it so only 1 theme can be chosen at one time)
            foreach (var item in clbListOfThemes.CheckedItems)
            {
                if (item.ToString() != "")
                {
                    lblInputedTheme.Text += item.ToString() + " ";
                }
            }

            // !!!! ТУТ РАСКОММЕНТИТЬ ЧТОБЫ ПОСМОТРЕТЬ 
            //lbxResultOutput.Items.Add(MessageGenerator.themesDictionary[2] == lblInputedTheme.Text.Replace(" ", "").Replace("'", ""));
            //lbxResultOutput.Items.Add(MessageGenerator.themesDictionary[2]);
            //lbxResultOutput.Items.Add(lblInputedTheme.Text.Replace(" ", "").Replace("'", ""));

            // !!!! ТУТ ЗАКОМЕНТИТЬ ЧТОБЫ ПОСМОТРЕТЬ
            // returning the message using picked theme
            if (lblInputedTheme.Text != "")
            {
                usedTheme = lblInputedTheme.Text; // assign first output to theme, for it to be readable (later on will remake clean)
                lblInputedPhoneNumbers.Text = inputedPhoneNumbers;

                // loop to fill textOutput with generated messages 
                for (int i = 0; i < _phoneNumbersManager.getPhoneNumbersAmount(); i++)
                {
                    string message = _phoneNumbersManager.getPhoneNumberByArrayID(i) + " " + _phoneNumbersManager.getTheMessage(_phoneNumbersManager.getThemeID(usedTheme));
                    lbxResultOutput.Items.Add(message);
                }
            }
            else
            {
                lblInputedPhoneNumbers.Text = "";
                lblInputedTheme.Text = "Error: No picked themes to use!";
            }

        }

    }
}
