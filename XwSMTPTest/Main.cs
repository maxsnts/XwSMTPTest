using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XwSMTPTest
{
    public partial class Main : Form
    {
        private List<Test> tests = new List<Test>();

        //*************************************************************************************************************
        public Main()
        {
            InitializeComponent();
        }

        //*************************************************************************************************************
        private void Main_Load(object sender, EventArgs e)
        {
            LoadSavedTests();
        }

        //*************************************************************************************************************
        private void LoadSavedTests()
        { 
            

        }
    }
}
