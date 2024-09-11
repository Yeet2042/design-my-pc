using DesignMyPC.InsideDashboard;
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
    public partial class Dashboard : Form
    {
        private Form Home;
        public Dashboard()
        {
            InitializeComponent();

            HomeButton.BackColor = Color.FromArgb(42, 54, 80);
            DashboardLabel.Text = Global.DashboardSelectedPage.Trim();

            InsideDashboard.HomePage homePage = new InsideDashboard.HomePage();

            homePage.TopLevel = false;

            Home = homePage;

            OpenHomePage();

            if (Global.LogInRole == "admin")
            {
                UsersButton.Visible = true;
                PCsButton.Visible = true;
                NameLabel.ForeColor = Color.FromArgb(198, 120, 221);
            }
            else
            {
                UsersButton.Visible= false;
                PCsButton.Visible= false;
                NameLabel.ForeColor = Color.FromArgb(86, 182, 194);
            }

            NameLabel.Text = Global.LogInName;
        }

        private void OpenHomePage()
        {
            DashboardContainer.Controls.Clear();
            DashboardContainer.Controls.Add(Home);
            Home.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Global.CloseApplication();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            Global.MinimizeApplication();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("แน่ใจ?", "ออกจากระบบ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("ออกจากระบบสำเร็จ");

                Global.OpenLoginPage();

                Global.LogInID = "";
                Global.LogInUser = "";
                Global.LogInEmail = "";
                Global.LogInRole = "";
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Global.DashboardSelectedPage = HomeButton.Text;
            DashboardLabel.Text = Global.DashboardSelectedPage.Trim();

            HomeButton.BackColor = Color.FromArgb(42, 54, 80);
            ComponentsButton.BackColor = Color.FromArgb(51, 62, 83);
            UsersButton.BackColor = Color.FromArgb(51, 62, 83);
            PCsButton.BackColor = Color.FromArgb(51, 62, 83);
        }

        private void ComponentsButton_Click(object sender, EventArgs e)
        {
            Global.DashboardSelectedPage = ComponentsButton.Text;
            DashboardLabel.Text = Global.DashboardSelectedPage.Trim();

            HomeButton.BackColor = Color.FromArgb(51, 62, 83);
            ComponentsButton.BackColor = Color.FromArgb(42, 54, 80);
            UsersButton.BackColor = Color.FromArgb(51, 62, 83);
            PCsButton.BackColor = Color.FromArgb(51, 62, 83);
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            Global.DashboardSelectedPage = UsersButton.Text;
            DashboardLabel.Text = Global.DashboardSelectedPage.Trim();

            HomeButton.BackColor = Color.FromArgb(51, 62, 83);
            ComponentsButton.BackColor = Color.FromArgb(51, 62, 83);
            UsersButton.BackColor = Color.FromArgb(42, 54, 80);
            PCsButton.BackColor = Color.FromArgb(51, 62, 83);
        }

        private void PCsButton_Click(object sender, EventArgs e)
        {
            Global.DashboardSelectedPage = PCsButton.Text;
            DashboardLabel.Text = Global.DashboardSelectedPage.Trim();

            HomeButton.BackColor = Color.FromArgb(51, 62, 83);
            ComponentsButton.BackColor = Color.FromArgb(51, 62, 83);
            UsersButton.BackColor = Color.FromArgb(51, 62, 83);
            PCsButton.BackColor = Color.FromArgb(42, 54, 80);
        }
    }
}
