using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignMyPC
{
    internal class Global
    {
        public static Panel MainContainerPanel;
        public static Form LoginPage;
        public static Form RegisterPage;

        public static void CloseApplication()
        {
            Application.Exit();
        }

        public static void MinimizeApplication()
        {
            Application.OpenForms["MainForm"].WindowState = FormWindowState.Minimized;
        }

        public static void OpenLoginPage()
        {
            Global.MainContainerPanel.Controls.Clear();
            Global.MainContainerPanel.Controls.Add(LoginPage);
            LoginPage.Show();
        }

        public static void OpenRegisterPage()
        {
            Global.MainContainerPanel.Controls.Clear();
            Global.MainContainerPanel.Controls.Add(RegisterPage);
            RegisterPage.Show();
        }
    }
}
