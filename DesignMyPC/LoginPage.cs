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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void RegisterButtonInLogin_Click(object sender, EventArgs e)
        {
            MainForm.MainContainerPanel.Controls.Clear();
            RegisterPage f = new RegisterPage();
            f.TopLevel = false;
            MainForm.MainContainerPanel.Controls.Add(f);
            f.Show();
        }
    }
}
