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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Global.MainContainerPanel = ContainerPanel;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            LoginPage loginPage = new LoginPage();
            RegisterPage registerPage = new RegisterPage();

            landingPage.TopLevel = false;
            loginPage.TopLevel = false;
            registerPage.TopLevel = false;

            Global.LoginPage = loginPage;
            Global.RegisterPage = registerPage;

            ContainerPanel.Controls.Add(landingPage);
            landingPage.Show();
        }
    }
}
