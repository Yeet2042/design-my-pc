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

            Global.UserDT.Columns.Add("id", typeof(string));
            Global.UserDT.Columns.Add("username", typeof(string));
            Global.UserDT.Columns.Add("name", typeof(string));
            Global.UserDT.Columns.Add("surname", typeof(string));
            Global.UserDT.Columns.Add("birth", typeof(string));
            Global.UserDT.Columns.Add("email", typeof(string));
            Global.UserDT.Columns.Add("password", typeof(string));
            Global.UserDT.Columns.Add("role", typeof(string));

            Global.UserDT.Rows.Add("001", "admin", "admin", "admin", "11/11/1991", "admin@admin.com", "admin", "admin");
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
