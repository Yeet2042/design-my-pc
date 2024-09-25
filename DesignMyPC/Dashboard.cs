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
        public Dashboard()
        {
            InitializeComponent();

            HomeButton.BackColor = Color.FromArgb(42, 54, 80);
            DashboardLabel.Text = Global.DashboardSelectedPage.Trim();

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
            InsideDashboard.HomePage homePage = new InsideDashboard.HomePage();
            homePage.TopLevel = false;

            DashboardContainer.Controls.Clear();
            DashboardContainer.Controls.Add(homePage);
            homePage.Show();
        }

        private void OpenComponentsPage()
        {
            InsideDashboard.ComponentsPage componentsPage = new InsideDashboard.ComponentsPage();
            componentsPage.TopLevel = false;

            DashboardContainer.Controls.Clear();
            DashboardContainer.Controls.Add(componentsPage);
            componentsPage.Show();
        }

        private void OpenAllUsersPage()
        {
            InsideDashboard.AllUsersPage allUsersPage = new InsideDashboard.AllUsersPage();
            allUsersPage.TopLevel = false;

            DashboardContainer.Controls.Clear();
            DashboardContainer.Controls.Add(allUsersPage);
            allUsersPage.Show();
        }

        private void OpenAllComputersPage()
        {
            InsideDashboard.AllComputersPage allComputerPage = new InsideDashboard.AllComputersPage();
            allComputerPage.TopLevel = false;

            DashboardContainer.Controls.Clear();
            DashboardContainer.Controls.Add(allComputerPage);
            allComputerPage.Show();
        }

        private void OpenSettingPage()
        {
            InsideDashboard.SettingPage settingPage = new InsideDashboard.SettingPage();
            settingPage.TopLevel = false;

            DashboardContainer.Controls.Clear();
            DashboardContainer.Controls.Add(settingPage);
            settingPage.Show();
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
            OpenHomePage();

            Global.DashboardSelectedPage = HomeButton.Text;
            DashboardLabel.Text = HomeButton.Text.Trim();

            HomeButton.BackColor = Color.FromArgb(42, 54, 80);
            ComponentsButton.BackColor = Color.FromArgb(51, 62, 83);
            UsersButton.BackColor = Color.FromArgb(51, 62, 83);
            PCsButton.BackColor = Color.FromArgb(51, 62, 83);
        }

        private void ComponentsButton_Click(object sender, EventArgs e)
        {
            OpenComponentsPage();

            Global.DashboardSelectedPage = ComponentsButton.Text;
            DashboardLabel.Text = ComponentsButton.Text.Trim();

            HomeButton.BackColor = Color.FromArgb(51, 62, 83);
            ComponentsButton.BackColor = Color.FromArgb(42, 54, 80);
            UsersButton.BackColor = Color.FromArgb(51, 62, 83);
            PCsButton.BackColor = Color.FromArgb(51, 62, 83);
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            OpenAllUsersPage();
            
            Global.DashboardSelectedPage = UsersButton.Text;
            DashboardLabel.Text = UsersButton.Text.Trim();

            HomeButton.BackColor = Color.FromArgb(51, 62, 83);
            ComponentsButton.BackColor = Color.FromArgb(51, 62, 83);
            UsersButton.BackColor = Color.FromArgb(42, 54, 80);
            PCsButton.BackColor = Color.FromArgb(51, 62, 83);
        }

        private void PCsButton_Click(object sender, EventArgs e)
        {
            OpenAllComputersPage();

            Global.DashboardSelectedPage = PCsButton.Text;
            DashboardLabel.Text = PCsButton.Text.Trim();

            HomeButton.BackColor = Color.FromArgb(51, 62, 83);
            ComponentsButton.BackColor = Color.FromArgb(51, 62, 83);
            UsersButton.BackColor = Color.FromArgb(51, 62, 83);
            PCsButton.BackColor = Color.FromArgb(42, 54, 80);
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            OpenSettingPage();

            Global.DashboardSelectedPage = SettingButton.Text;
            DashboardLabel.Text = SettingButton.Text;

            HomeButton.BackColor = Color.FromArgb(51, 62, 83);
            ComponentsButton.BackColor = Color.FromArgb(51, 62, 83);
            UsersButton.BackColor = Color.FromArgb(51, 62, 83);
            PCsButton.BackColor = Color.FromArgb(51, 62, 83);
        }
    }
}
