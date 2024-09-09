using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignMyPC
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            MainForm.MainContainerPanel.Controls.Clear();
            LoginPage f = new LoginPage();
            f.TopLevel = false;
            MainForm.MainContainerPanel.Controls.Add(f);
            f.Show();
            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            MainForm.MainContainerPanel.Controls.Clear();
            RegisterPage f = new RegisterPage();
            f.TopLevel = false;
            MainForm.MainContainerPanel.Controls.Add(f);
            f.Show();
        }
    }
}
