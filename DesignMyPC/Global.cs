using System;
using System.Collections.Generic;
using System.Data;
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

        public static DataTable UserDT = new DataTable();

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
            MainContainerPanel.Controls.Clear();
            MainContainerPanel.Controls.Add(LoginPage);
            LoginPage.Show();
        }

        public static void OpenRegisterPage()
        {
            MainContainerPanel.Controls.Clear();
            MainContainerPanel.Controls.Add(RegisterPage);
            RegisterPage.Show();
        }

        private static string AutoID(string prefix, DataTable dt)
        {
            string newID;
            int rowMax = dt.Rows.Count - 1;
            string ID = dt.Rows[rowMax]["id"].ToString().Substring(prefix.Length, 3);
            int n = Convert.ToInt32(ID) + 1;
            newID = prefix + n.ToString("000");
            return newID;
        }

        public static void CreateUser(string username,
            string name,
            string surname,
            string birth,
            string email,
            string password,
            string role)
        {
            UserDT.Rows.Add(AutoID("", UserDT),
                username,
                name,
                surname,
                birth,
                email,
                password,
                role);
        }

        public static bool Login(string username, string password)
        {
            bool success = false;
            foreach (DataRow row in UserDT.Rows)
            {
                if (row["username"].ToString() == username)
                {
                    if (row["password"].ToString() == password)
                    {
                        success = true;
                        break;
                    }
                    else
                    {
                        success = false;
                        break;
                    }
                }

            }
            return success;
        }
    }
}
