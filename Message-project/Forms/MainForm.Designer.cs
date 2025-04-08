namespace Message_project.Classes
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
            label1 = new Label();
            txtbPhoneNumbersInput = new TextBox();
            lblTextOutput1 = new Label();
            lblTextOutput2 = new Label();
            panel1 = new Panel();
            lblResultMessages = new Label();
            clbListOfThemes = new CheckedListBox();
            lbxResultOutput = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SendMessages
            // 
            SendMessages.Location = new Point(144, 52);
            SendMessages.Name = "SendMessages";
            SendMessages.Size = new Size(160, 60);
            SendMessages.TabIndex = 0;
            SendMessages.Text = "Send messages";
            SendMessages.UseVisualStyleBackColor = true;
            SendMessages.Click += SendMessages_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 26);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Phone numbers:";
            // 
            // txtbPhoneNumbersInput
            // 
            txtbPhoneNumbersInput.Location = new Point(144, 23);
            txtbPhoneNumbersInput.Name = "txtbPhoneNumbersInput";
            txtbPhoneNumbersInput.Size = new Size(510, 23);
            txtbPhoneNumbersInput.TabIndex = 2;
            // 
            // lblTextOutput1
            // 
            lblTextOutput1.AutoSize = true;
            lblTextOutput1.Location = new Point(3, 142);
            lblTextOutput1.Name = "lblTextOutput1";
            lblTextOutput1.Size = new Size(10, 15);
            lblTextOutput1.TabIndex = 3;
            lblTextOutput1.Text = " ";
            // 
            // lblTextOutput2
            // 
            lblTextOutput2.AutoSize = true;
            lblTextOutput2.Location = new Point(3, 167);
            lblTextOutput2.Name = "lblTextOutput2";
            lblTextOutput2.Size = new Size(10, 15);
            lblTextOutput2.TabIndex = 4;
            lblTextOutput2.Text = " ";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbxResultOutput);
            panel1.Controls.Add(lblTextOutput2);
            panel1.Controls.Add(lblTextOutput1);
            panel1.Location = new Point(144, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 187);
            panel1.TabIndex = 5;
            // 
            // lblResultMessages
            // 
            lblResultMessages.AutoSize = true;
            lblResultMessages.Location = new Point(76, 118);
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
            clbListOfThemes.Location = new Point(310, 54);
            clbListOfThemes.Name = "clbListOfThemes";
            clbListOfThemes.Size = new Size(344, 58);
            clbListOfThemes.TabIndex = 7;
            // 
            // lbxResultOutput
            // 
            lbxResultOutput.FormattingEnabled = true;
            lbxResultOutput.Location = new Point(0, 0);
            lbxResultOutput.Name = "lbxResultOutput";
            lbxResultOutput.Size = new Size(510, 139);
            lbxResultOutput.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 332);
            Controls.Add(clbListOfThemes);
            Controls.Add(lblResultMessages);
            Controls.Add(SendMessages);
            Controls.Add(panel1);
            Controls.Add(txtbPhoneNumbersInput);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Message sender program";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SendMessages;
        private Label label1;
        private TextBox txtbPhoneNumbersInput;
        private Label lblTextOutput1;
        private Label lblTextOutput2;
        private Panel panel1;
        private Label lblResultMessages;
        private CheckedListBox clbListOfThemes;
        private ListBox lbxResultOutput;
    }
}