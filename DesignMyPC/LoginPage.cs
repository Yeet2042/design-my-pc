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
            Global.OpenRegisterPage();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Global.CloseApplication();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            Global.MinimizeApplication();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "" ||
                PasswordTextBox.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน!");
            }
            else
            {
                if (Global.Login(UsernameTextBox.Text, PasswordTextBox.Text))
                {
                    MessageBox.Show("เข้าสู่ระบบสำเร็จ");
                }
                else
                {
                    MessageBox.Show("ชื่อผู็ใช้หรือรหัสผ่านไม่ถูกต้อง!");
                }
            }
        }
    }
}
