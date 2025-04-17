namespace Message_project.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SendMessages = new Button();
            lblPhoneNumbersText = new Label();
            txtbPhoneNumbersInput = new TextBox();
            lblInputedTheme = new Label();
            lblInputedPhoneNumbers = new Label();
            panel1 = new Panel();
            lbxResultOutput = new ListBox();
            lblResultMessages = new Label();
            clbListOfThemes = new CheckedListBox();
            btnPastePhoneNumbers = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SendMessages
            // 
            SendMessages.Location = new Point(144, 118);
            SendMessages.Name = "SendMessages";
            SendMessages.Size = new Size(257, 33);
            SendMessages.TabIndex = 0;
            SendMessages.Text = "Send messages";
            SendMessages.UseVisualStyleBackColor = true;
            SendMessages.Click += SendMessages_Click;
            // 
            // lblPhoneNumbersText
            // 
            lblPhoneNumbersText.AutoSize = true;
            lblPhoneNumbersText.Location = new Point(29, 26);
            lblPhoneNumbersText.Name = "lblPhoneNumbersText";
            lblPhoneNumbersText.Size = new Size(94, 15);
            lblPhoneNumbersText.TabIndex = 1;
            lblPhoneNumbersText.Text = "Phone numbers:";
            // 
            // txtbPhoneNumbersInput
            // 
            txtbPhoneNumbersInput.Location = new Point(144, 23);
            txtbPhoneNumbersInput.Multiline = true;
            txtbPhoneNumbersInput.Name = "txtbPhoneNumbersInput";
            txtbPhoneNumbersInput.Size = new Size(583, 60);
            txtbPhoneNumbersInput.TabIndex = 2;
            // 
            // lblInputedTheme
            // 
            lblInputedTheme.AutoSize = true;
            lblInputedTheme.Location = new Point(115, 10);
            lblInputedTheme.Name = "lblInputedTheme";
            lblInputedTheme.Size = new Size(10, 15);
            lblInputedTheme.TabIndex = 3;
            lblInputedTheme.Text = " ";
            // 
            // lblInputedPhoneNumbers
            // 
            lblInputedPhoneNumbers.AutoSize = true;
            lblInputedPhoneNumbers.Location = new Point(115, 37);
            lblInputedPhoneNumbers.Name = "lblInputedPhoneNumbers";
            lblInputedPhoneNumbers.Size = new Size(10, 15);
            lblInputedPhoneNumbers.TabIndex = 4;
            lblInputedPhoneNumbers.Text = " ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(lblInputedPhoneNumbers);
            panel1.Controls.Add(lbxResultOutput);
            panel1.Controls.Add(lblResultMessages);
            panel1.Controls.Add(lblInputedTheme);
            panel1.Location = new Point(29, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(698, 274);
            panel1.TabIndex = 5;
            // 
            // lbxResultOutput
            // 
            lbxResultOutput.FormattingEnabled = true;
            lbxResultOutput.Location = new Point(66, 55);
            lbxResultOutput.Name = "lbxResultOutput";
            lbxResultOutput.Size = new Size(629, 214);
            lbxResultOutput.TabIndex = 8;
            // 
            // lblResultMessages
            // 
            lblResultMessages.AutoSize = true;
            lblResultMessages.Location = new Point(17, 25);
            lblResultMessages.Name = "lblResultMessages";
            lblResultMessages.Size = new Size(47, 15);
            lblResultMessages.TabIndex = 6;
            lblResultMessages.Text = "Results:";
            // 
            // clbListOfThemes
            // 
            clbListOfThemes.CheckOnClick = true;
            clbListOfThemes.FormattingEnabled = true;
            clbListOfThemes.Items.AddRange(new object[] { "Birthday", "International Women's day", "New Year" });
            clbListOfThemes.Location = new Point(407, 91);
            clbListOfThemes.Name = "clbListOfThemes";
            clbListOfThemes.Size = new Size(320, 58);
            clbListOfThemes.TabIndex = 7;
            // 
            // btnPastePhoneNumbers
            // 
            btnPastePhoneNumbers.Location = new Point(144, 89);
            btnPastePhoneNumbers.Name = "btnPastePhoneNumbers";
            btnPastePhoneNumbers.Size = new Size(257, 23);
            btnPastePhoneNumbers.TabIndex = 8;
            btnPastePhoneNumbers.Text = "Paste from clipboard";
            btnPastePhoneNumbers.UseVisualStyleBackColor = true;
            btnPastePhoneNumbers.Click += btnPastePhoneNumbers_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 460);
            Controls.Add(btnPastePhoneNumbers);
            Controls.Add(clbListOfThemes);
            Controls.Add(SendMessages);
            Controls.Add(panel1);
            Controls.Add(txtbPhoneNumbersInput);
            Controls.Add(lblPhoneNumbersText);
            Name = "MainForm";
            Text = "Message sender program";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SendMessages;
        private Label lblPhoneNumbersText;
        private TextBox txtbPhoneNumbersInput;
        private Label lblInputedTheme;
        private Label lblInputedPhoneNumbers;
        private Panel panel1;
        private Label lblResultMessages;
        private CheckedListBox clbListOfThemes;
        private ListBox lbxResultOutput;
        private Button btnPastePhoneNumbers;
    }
}