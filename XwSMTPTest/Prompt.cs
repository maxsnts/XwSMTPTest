using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XwSMTPTest
{
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption, string value = "")
        {
            Form prompt = new Form()
            {
                Width = 460,
                Height = 160,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Width = 300, Text = text };
            TextBox textBox = new TextBox() { Left = 20, Top = 40, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 320, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.MinimizeBox = false;
            prompt.MaximizeBox = false;
            textBox.Text = value;
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
