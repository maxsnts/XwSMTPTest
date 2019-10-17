namespace XwSMTPTest
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textFrom = new System.Windows.Forms.TextBox();
            this.textReplyTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textTo = new System.Windows.Forms.TextBox();
            this.textCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textSender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textSubject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBody = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textSMTPHost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textSMTPPort = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textSMTPUser = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textSMTPPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBCC = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.comboSavedAs = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboSMTPSecurity = new System.Windows.Forms.ComboBox();
            this.comboLibrary = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(446, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(418, 515);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            // 
            // textFrom
            // 
            this.textFrom.Location = new System.Drawing.Point(127, 67);
            this.textFrom.Name = "textFrom";
            this.textFrom.Size = new System.Drawing.Size(313, 20);
            this.textFrom.TabIndex = 2;
            // 
            // textReplyTo
            // 
            this.textReplyTo.Location = new System.Drawing.Point(127, 93);
            this.textReplyTo.Name = "textReplyTo";
            this.textReplyTo.Size = new System.Drawing.Size(313, 20);
            this.textReplyTo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "To:";
            // 
            // textTo
            // 
            this.textTo.Location = new System.Drawing.Point(127, 145);
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(313, 20);
            this.textTo.TabIndex = 5;
            // 
            // textCC
            // 
            this.textCC.Location = new System.Drawing.Point(127, 171);
            this.textCC.Name = "textCC";
            this.textCC.Size = new System.Drawing.Size(313, 20);
            this.textCC.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Reply to:";
            // 
            // textSender
            // 
            this.textSender.Location = new System.Drawing.Point(127, 119);
            this.textSender.Name = "textSender";
            this.textSender.Size = new System.Drawing.Size(313, 20);
            this.textSender.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Subject:";
            // 
            // textSubject
            // 
            this.textSubject.Location = new System.Drawing.Point(127, 223);
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(313, 20);
            this.textSubject.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Body:";
            // 
            // textBody
            // 
            this.textBody.Location = new System.Drawing.Point(127, 249);
            this.textBody.Multiline = true;
            this.textBody.Name = "textBody";
            this.textBody.Size = new System.Drawing.Size(313, 123);
            this.textBody.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "SMTP host:";
            // 
            // textSMTPHost
            // 
            this.textSMTPHost.Location = new System.Drawing.Point(127, 378);
            this.textSMTPHost.Name = "textSMTPHost";
            this.textSMTPHost.Size = new System.Drawing.Size(313, 20);
            this.textSMTPHost.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "SMTP port:";
            // 
            // textSMTPPort
            // 
            this.textSMTPPort.Location = new System.Drawing.Point(127, 404);
            this.textSMTPPort.Name = "textSMTPPort";
            this.textSMTPPort.Size = new System.Drawing.Size(313, 20);
            this.textSMTPPort.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "SMTP user:";
            // 
            // textSMTPUser
            // 
            this.textSMTPUser.Location = new System.Drawing.Point(127, 430);
            this.textSMTPUser.Name = "textSMTPUser";
            this.textSMTPUser.Size = new System.Drawing.Size(313, 20);
            this.textSMTPUser.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 459);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "SMTP password:";
            // 
            // textSMTPPassword
            // 
            this.textSMTPPassword.Location = new System.Drawing.Point(127, 456);
            this.textSMTPPassword.Name = "textSMTPPassword";
            this.textSMTPPassword.Size = new System.Drawing.Size(313, 20);
            this.textSMTPPassword.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 485);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "SMTP security:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "BCC:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "CC:";
            // 
            // textBCC
            // 
            this.textBCC.Location = new System.Drawing.Point(127, 197);
            this.textBCC.Name = "textBCC";
            this.textBCC.Size = new System.Drawing.Size(313, 20);
            this.textBCC.TabIndex = 7;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(127, 509);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(313, 46);
            this.buttonSend.TabIndex = 15;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // comboSavedAs
            // 
            this.comboSavedAs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSavedAs.FormattingEnabled = true;
            this.comboSavedAs.Location = new System.Drawing.Point(127, 13);
            this.comboSavedAs.Name = "comboSavedAs";
            this.comboSavedAs.Size = new System.Drawing.Size(494, 21);
            this.comboSavedAs.TabIndex = 0;
            this.comboSavedAs.SelectedIndexChanged += new System.EventHandler(this.comboSavedAs_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Saved test:";
            // 
            // comboSMTPSecurity
            // 
            this.comboSMTPSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSMTPSecurity.FormattingEnabled = true;
            this.comboSMTPSecurity.Location = new System.Drawing.Point(127, 482);
            this.comboSMTPSecurity.Name = "comboSMTPSecurity";
            this.comboSMTPSecurity.Size = new System.Drawing.Size(313, 21);
            this.comboSMTPSecurity.TabIndex = 14;
            // 
            // comboLibrary
            // 
            this.comboLibrary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLibrary.FormattingEnabled = true;
            this.comboLibrary.Location = new System.Drawing.Point(127, 40);
            this.comboLibrary.Name = "comboLibrary";
            this.comboLibrary.Size = new System.Drawing.Size(313, 21);
            this.comboLibrary.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Use library:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(627, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Save as";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRename
            // 
            this.buttonRename.Location = new System.Drawing.Point(708, 12);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(75, 23);
            this.buttonRename.TabIndex = 17;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(789, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 567);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRename);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboLibrary);
            this.Controls.Add(this.comboSMTPSecurity);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboSavedAs);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBCC);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textSMTPPassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textSMTPUser);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textSMTPPort);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textSMTPHost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBody);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textSender);
            this.Controls.Add(this.textCC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textReplyTo);
            this.Controls.Add(this.textFrom);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XwSMTPTest";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textFrom;
        private System.Windows.Forms.TextBox textReplyTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTo;
        private System.Windows.Forms.TextBox textCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textSubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBody;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textSMTPHost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textSMTPPort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textSMTPUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textSMTPPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBCC;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ComboBox comboSavedAs;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboSMTPSecurity;
        private System.Windows.Forms.ComboBox comboLibrary;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.Button buttonDelete;
    }
}