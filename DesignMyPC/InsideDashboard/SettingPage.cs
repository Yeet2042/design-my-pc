using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignMyPC.InsideDashboard
{
    public partial class SettingPage : Form
    {
        public SettingPage()
        {
            InitializeComponent();
            UsernameTextBox.Text = Global.LogInUser;
            EmailTextBox.Text = Global.LogInEmail;

            PasswordTextBox.PasswordChar = '*';
            ConfirmPasswordTextBox.PasswordChar = '*';
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text != Global.LogInUser)
            {
                SubmitButton.Visible = true;
            }
            else
            {
                SubmitButton.Visible = false;
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (EmailTextBox.Text != Global.LogInEmail)
            {
                SubmitButton.Visible = true;
            }
            else
            {
                SubmitButton.Visible = false;
            }
        }

        private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ConfirmPasswordTextBox.Text != "")
            {
                SubmitButton.Visible = true;
            }
            else
            {
                SubmitButton.Visible = false;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DataRow[] rowUpdate = Global.UserDT.Select($"id = '{Global.LogInID}'");

            if (UsernameTextBox.Text != Global.LogInUser)
            {
                rowUpdate[0]["username"] = UsernameTextBox.Text;
            }

            if (EmailTextBox.Text != Global.LogInEmail)
            {
                rowUpdate[0]["email"] = EmailTextBox.Text;
            }

            if (PasswordTextBox.Text != "" || ConfirmPasswordTextBox.Text != "")
            {
                if (PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
                {
                    MessageBox.Show("รหัสผ่านไม่เหมือนกัน!");
                }
                else
                {
                    rowUpdate[0]["password"] = PasswordTextBox.Text;
                }
            }

            MessageBox.Show("แก้ไขบัญชีเรียบร้อย กรุณาเข้าสู่ระบบใหม่");

            Global.OpenLoginPage();

            Global.LogInID = "";
            Global.LogInUser = "";
            Global.LogInEmail = "";
            Global.LogInRole = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("แน่ใจ?", "ลบบัญชี", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataRow[] rowUpdate = Global.UserDT.Select($"id = '{Global.LogInID}'");

                rowUpdate[0].Delete();

                MessageBox.Show("ลบบัญชีสำเร็จ");

                Global.OpenLoginPage();

                Global.LogInID = "";
                Global.LogInUser = "";
                Global.LogInEmail = "";
                Global.LogInRole = "";
            }
        }
    }
}
