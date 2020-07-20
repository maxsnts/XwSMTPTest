using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace XwSMTPTest
{
    public partial class Main : Form
    {
        List<Test> tests = new List<Test>();

        //*************************************************************************************************************
        public Main()
        {
            InitializeComponent();
        }

        //*************************************************************************************************************
        private void Main_Load(object sender, EventArgs e)
        {
            Text += PrintVersion(typeof(Main));
            comboLibrary.Items.Add(".Net");
            comboLibrary.Items.Add("MailKit");
            comboLibrary.SelectedIndex = 0;
            comboSMTPSecurity.Items.Add("None");
            comboSMTPSecurity.Items.Add("STARTTLS");
            comboSMTPSecurity.SelectedIndex = 0;
            LoadTests();
        }

        //*************************************************************************************************************
        private string PrintVersion(Type type)
        {
            return " v" + System.Diagnostics.FileVersionInfo.GetVersionInfo(
                System.Reflection.Assembly.GetAssembly(type).Location).FileVersion.ToString();
        }

        //*************************************************************************************************************
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboSavedAs.SelectedIndex == 0) //temp
            {
                string name = Prompt.ShowDialog("Name for settings group", "Save settings group");
                if (name.Trim() == "")
                {
                    MessageBox.Show("Name can not be empty");
                    return;
                }

                Test test = new Test();
                test.SaveAs = name;
                int index = comboSavedAs.Items.Add(test);
                SaveTests(index);
                comboSavedAs.SelectedIndex = index;
            }
            else
            {
                SaveTests(comboSavedAs.SelectedIndex);
            }
        }

        //*************************************************************************************************************
        private void buttonRename_Click(object sender, EventArgs e)
        {
            if (comboSavedAs.SelectedIndex != 0) //temp
            {
                Test test = (Test)comboSavedAs.SelectedItem;
                int index = comboSavedAs.SelectedIndex;

                string name = Prompt.ShowDialog("Name for settings group", "Save settings group", test.SaveAs);
                if (name.Trim() == "")
                {
                    MessageBox.Show("Name can not be empty");
                    return;
                }

                test.SaveAs = name;
                comboSavedAs.Items[index] = test;
                SaveTests(index);
            }
            
        }

        //*************************************************************************************************************
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Test test = (Test)comboSavedAs.SelectedItem;
            if (MessageBox.Show("Delete selected profile?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                comboSavedAs.Items.Remove(test);
                comboSavedAs.SelectedIndex = 0;
                SaveTests();
            }
        }
        
        //*************************************************************************************************************
        private void LoadTests()
        {
            if (File.Exists("savedtests.json"))
            {
                string file = File.ReadAllText("savedtests.json");
                tests = JsonConvert.DeserializeObject<List<Test>>(file);
            }
            else
            {
                tests = new List<Test>();
                Test test = new Test();
                test.SaveAs = "LAST USED TEST DATA";
                tests.Add(test);
            }

            comboSavedAs.Items.Clear();
            foreach (Test test in tests)
            {
                comboSavedAs.Items.Add(test);
                comboSavedAs.SelectedIndex = 0;
                buttonRename.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }

        //*************************************************************************************************************
        private Test SaveTests(int index = 0)
        {
            Test lastUsed = (Test)comboSavedAs.Items[index];
            lastUsed.Library = comboLibrary.SelectedItem.ToString();
            lastUsed.From = textFrom.Text.Trim();
            lastUsed.ReplyTo = textReplyTo.Text.Trim();
            lastUsed.To = textTo.Text.Trim();
            lastUsed.Sender = textSender.Text.Trim();
            lastUsed.CC = textCC.Text.Trim();
            lastUsed.BCC = textBCC.Text.Trim();
            lastUsed.Subject = textSubject.Text.Trim();
            lastUsed.Body = textBody.Text.Trim();
            lastUsed.SMTPHost = textSMTPHost.Text.Trim();
            lastUsed.SMTPPort = textSMTPPort.Text.Trim();
            lastUsed.SMTPUser = textSMTPUser.Text.Trim();
            lastUsed.SMTPPassword = textSMTPPassword.Text.Trim();
            lastUsed.SMTPSecurity = comboSMTPSecurity.SelectedItem.ToString();

            tests.Clear();
            foreach (Test test in comboSavedAs.Items)
            {
                tests.Add(test);
            }
            string json = JsonConvert.SerializeObject(tests, Formatting.Indented);
            File.WriteAllText("savedtests.json", json);

            return lastUsed;
        }

        //*************************************************************************************************************
        private void comboSavedAs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Test test = (Test)comboSavedAs.SelectedItem;
            comboLibrary.SelectedItem = test.Library;
            textFrom.Text = test.From;
            textReplyTo.Text = test.ReplyTo;
            textTo.Text = test.To;
            textSender.Text = test.Sender;
            textCC.Text = test.CC;
            textBCC.Text = test.BCC;
            textSubject.Text = test.Subject;
            textBody.Text = test.Body;
            textSMTPHost.Text = test.SMTPHost;
            textSMTPPort.Text = test.SMTPPort;
            textSMTPUser.Text = test.SMTPUser;
            textSMTPPassword.Text = test.SMTPPassword;
            comboSMTPSecurity.SelectedItem = test.SMTPSecurity;

            if (comboSavedAs.SelectedIndex == 0)
            {
                buttonRename.Enabled = false;
                buttonDelete.Enabled = false;
            }
            else
            {
                buttonRename.Enabled = true;
                buttonDelete.Enabled = true;
            }
        }

        //*************************************************************************************************************
        private void Log(string message)
        {
            textLog.AppendText("-----------------------------------------------------------------\r\n");
            textLog.AppendText(message);
            textLog.AppendText("\r\n");
        }

        //*************************************************************************************************************
        private void buttonSend_Click(object sender, EventArgs e)
        {
            textLog.Text = "";
            Test test = SaveTests();

            Log("Sending...");
            switch (test.Library)
            {
                case ".Net":
                    TestWithDotNet(test);
                    break;
                case "MailKit":
                    TestWithMailKit(test);
                    break;
                default:
                    Log("Unkonwn Library");
                    break;
            }
        }

        //*************************************************************************************************************
        private void TestWithDotNet(Test test) 
        {
            try
            {
                using (var oSMTP = new System.Net.Mail.SmtpClient())
                {
                    oSMTP.Host = test.SMTPHost;
                    oSMTP.Port = int.Parse(test.SMTPPort);
                    
                    if (test.SMTPUser != "")
                    {
                        oSMTP.Credentials = new NetworkCredential(test.SMTPUser, test.SMTPPassword);
                    }

                    if (test.SMTPSecurity == "STARTTLS")
                    {
                        ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                        oSMTP.EnableSsl = true;
                    }

                    using (var oMail = new System.Net.Mail.MailMessage(test.From, test.To, test.Subject, test.Body))
                    {
                        oMail.IsBodyHtml = false;
                        oMail.BodyEncoding = System.Text.Encoding.UTF8;
                        oMail.SubjectEncoding = System.Text.Encoding.UTF8;

                        if (test.ReplyTo != "")
                            oMail.ReplyToList.Add(test.ReplyTo);

                        if (test.Sender != "")
                            oMail.Sender = new System.Net.Mail.MailAddress(test.Sender);

                        if (test.CC != "")
                            oMail.CC.Add(test.CC);

                        if (test.BCC != "")
                            oMail.Bcc.Add(test.BCC);
                        
                        oSMTP.Send(oMail);
                    }
                }

                Log("********* SENT *********");
            }
            catch (Exception ex)
            {
                textLog.AppendText("=================================================================\r\n");
                Log(ex.Message);
                Log(ex.StackTrace);
            }
        }

        //*************************************************************************************************************
        private void TestWithMailKit(Test test)
        {

            try
            {
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    if (test.SMTPSecurity == "STARTTLS")
                    {
                        client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                        client.Connect(test.SMTPHost, int.Parse(test.SMTPPort), MailKit.Security.SecureSocketOptions.StartTls);
                    }
                    else
                    {
                        client.Connect(test.SMTPHost, int.Parse(test.SMTPPort), MailKit.Security.SecureSocketOptions.None);
                    }

                    if (test.SMTPUser != "")
                    {
                        client.Authenticate(test.SMTPUser, test.SMTPPassword);
                    }

                    
                    var message = new MimeKit.MimeMessage();
                    message.From.Add(new MimeKit.MailboxAddress(test.From));
                    message.To.Add(new MimeKit.MailboxAddress(test.To));
                    message.Subject = test.Subject;
                    message.Body = new MimeKit.TextPart("plain")
                    {
                        Text = test.Body
                    };

                    client.Send(message);
                    client.Disconnect(true);
                }

                Log("********* SENT *********");
            }
            catch (Exception ex)
            {
                textLog.AppendText("=================================================================\r\n");
                Log(ex.Message);
                Log(ex.StackTrace);
            }
        }
    }
}
