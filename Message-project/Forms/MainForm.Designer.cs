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
            components = new System.ComponentModel.Container();
            SendMessages = new Button();
            lblPhoneNumbersText = new Label();
            txtbPhoneNumbersInput = new TextBox();
            lblInputedTheme = new Label();
            lblInputedPhoneNumbers = new Label();
            lblResultMessages = new Label();
            clbListOfThemes = new CheckedListBox();
            btnPastePhoneNumbers = new Button();
            lblMessage = new Label();
            rtbCustomMessage = new RichTextBox();
            txtbSendDelay = new TextBox();
            lblTimeToSend = new Label();
            txtbResults = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // SendMessages
            // 
            SendMessages.Location = new Point(270, 383);
            SendMessages.Name = "SendMessages";
            SendMessages.Size = new Size(226, 65);
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
            txtbPhoneNumbersInput.Location = new Point(29, 52);
            txtbPhoneNumbersInput.Multiline = true;
            txtbPhoneNumbersInput.Name = "txtbPhoneNumbersInput";
            txtbPhoneNumbersInput.Size = new Size(190, 242);
            txtbPhoneNumbersInput.TabIndex = 2;
            toolTip1.SetToolTip(txtbPhoneNumbersInput, "Here will be used only valid ones - e.g. 20000000");
            // 
            // lblInputedTheme
            // 
            lblInputedTheme.AutoSize = true;
            lblInputedTheme.Location = new Point(601, 7);
            lblInputedTheme.Name = "lblInputedTheme";
            lblInputedTheme.Size = new Size(10, 15);
            lblInputedTheme.TabIndex = 3;
            lblInputedTheme.Text = " ";
            // 
            // lblInputedPhoneNumbers
            // 
            lblInputedPhoneNumbers.AutoSize = true;
            lblInputedPhoneNumbers.Location = new Point(601, 34);
            lblInputedPhoneNumbers.Name = "lblInputedPhoneNumbers";
            lblInputedPhoneNumbers.Size = new Size(10, 15);
            lblInputedPhoneNumbers.TabIndex = 4;
            lblInputedPhoneNumbers.Text = " ";
            // 
            // lblResultMessages
            // 
            lblResultMessages.AutoSize = true;
            lblResultMessages.Location = new Point(539, 26);
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
            clbListOfThemes.Location = new Point(270, 309);
            clbListOfThemes.Name = "clbListOfThemes";
            clbListOfThemes.Size = new Size(226, 58);
            clbListOfThemes.TabIndex = 7;
            // 
            // btnPastePhoneNumbers
            // 
            btnPastePhoneNumbers.Location = new Point(29, 309);
            btnPastePhoneNumbers.Name = "btnPastePhoneNumbers";
            btnPastePhoneNumbers.Size = new Size(190, 23);
            btnPastePhoneNumbers.TabIndex = 8;
            btnPastePhoneNumbers.Text = "Paste from clipboard";
            btnPastePhoneNumbers.UseVisualStyleBackColor = true;
            btnPastePhoneNumbers.Click += btnPastePhoneNumbers_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(270, 26);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(56, 15);
            lblMessage.TabIndex = 9;
            lblMessage.Text = "Message:";
            // 
            // rtbCustomMessage
            // 
            rtbCustomMessage.Location = new Point(270, 52);
            rtbCustomMessage.Name = "rtbCustomMessage";
            rtbCustomMessage.Size = new Size(226, 242);
            rtbCustomMessage.TabIndex = 10;
            rtbCustomMessage.Text = "";
            // 
            // txtbSendDelay
            // 
            txtbSendDelay.Location = new Point(121, 363);
            txtbSendDelay.Name = "txtbSendDelay";
            txtbSendDelay.Size = new Size(98, 23);
            txtbSendDelay.TabIndex = 11;
            // 
            // lblTimeToSend
            // 
            lblTimeToSend.AutoSize = true;
            lblTimeToSend.Location = new Point(29, 366);
            lblTimeToSend.Name = "lblTimeToSend";
            lblTimeToSend.Size = new Size(86, 15);
            lblTimeToSend.TabIndex = 12;
            lblTimeToSend.Text = "TimeToSend(h)";
            // 
            // txtbResults
            // 
            txtbResults.Location = new Point(539, 52);
            txtbResults.Multiline = true;
            txtbResults.Name = "txtbResults";
            txtbResults.ReadOnly = true;
            txtbResults.ScrollBars = ScrollBars.Vertical;
            txtbResults.Size = new Size(422, 396);
            txtbResults.TabIndex = 13;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 460);
            Controls.Add(txtbResults);
            Controls.Add(lblTimeToSend);
            Controls.Add(txtbSendDelay);
            Controls.Add(lblInputedPhoneNumbers);
            Controls.Add(rtbCustomMessage);
            Controls.Add(lblResultMessages);
            Controls.Add(lblMessage);
            Controls.Add(lblInputedTheme);
            Controls.Add(btnPastePhoneNumbers);
            Controls.Add(clbListOfThemes);
            Controls.Add(SendMessages);
            Controls.Add(txtbPhoneNumbersInput);
            Controls.Add(lblPhoneNumbersText);
            Name = "MainForm";
            Text = "Message sender program";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SendMessages;
        private Label lblPhoneNumbersText;
        private TextBox txtbPhoneNumbersInput;
        private Label lblInputedTheme;
        private Label lblInputedPhoneNumbers;
        private Label lblResultMessages;
        private CheckedListBox clbListOfThemes;
        private Button btnPastePhoneNumbers;
        private Label lblMessage;
        private RichTextBox rtbCustomMessage;
        private TextBox txtbSendDelay;
        private Label lblTimeToSend;
        private TextBox txtbResults;
        private ToolTip toolTip1;
    }
}