using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XwSMTPTest
{
    public partial class Main : Form
    {
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
            comboSMTPSecurity.Items.Add("SSL");
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
        private void buttonSend_Click(object sender, EventArgs e)
        {
            SaveTests();
        }

        //*************************************************************************************************************
        private void buttonSave_Click(object sender, EventArgs e)
        {
            
        }

        //*************************************************************************************************************
        private void buttonRename_Click(object sender, EventArgs e)
        {

        }

        //*************************************************************************************************************
        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
        
        //*************************************************************************************************************
        private void LoadTests()
        {
            List<Test> tests = null;
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
        private void SaveTests()
        {
            Test tmp = (Test)comboSavedAs.Items[0]; //Last Used...
            tmp.Library = comboLibrary.SelectedItem.ToString();
            tmp.From = textFrom.Text;
            tmp.ReplyTo = textReplyTo.Text;
            tmp.To = textTo.Text;
            tmp.Sender = textSender.Text;
            tmp.CC = textCC.Text;
            tmp.BCC = textBCC.Text;
            tmp.Subject = textSubject.Text;
            tmp.Body = textBody.Text;
            tmp.SMTPHost = textSMTPHost.Text;
            tmp.SMTPPort = textSMTPPort.Text;
            tmp.SMTPUser = textSMTPUser.Text;
            tmp.SMTPPassword = textSMTPPassword.Text;
            tmp.SMTPSecurity = comboSMTPSecurity.SelectedItem.ToString();

            List<Test> tests = new List<Test>();
            foreach (Test test in comboSavedAs.Items)
            {
                tests.Add(test);
            }
            string json = JsonConvert.SerializeObject(tests, Formatting.Indented);
            File.WriteAllText("savedtests.json", json);
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
        }
    }
}
