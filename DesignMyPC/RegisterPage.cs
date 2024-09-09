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
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
            ConfirmPasswordTextBox.PasswordChar = '*';
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Global.CloseApplication();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            Global.MinimizeApplication();
        }

        private void LoginButtonInRegister_Click(object sender, EventArgs e)
        {
            Global.OpenLoginPage();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string name = NameTextBox.Text;
            string surname = SurNameTextBox.Text;
            string birth = BirthPicker.Value.ToString();
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;
            string confirmPassword = ConfirmPasswordTextBox.Text;

            if (username == "" ||
                name == "" ||
                surname == "" ||
                birth == "" ||
                email == "" ||
                password == "" ||
                confirmPassword == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน!");
            } else
            {
                if (password != confirmPassword)
                {
                    MessageBox.Show("รหัสผ่านไม่เหมือนกัน!");
                }
                else
                {
                    if (!TermsCheckBox.Checked)
                    {
                        MessageBox.Show("กรุณายอมรับเงื่อนไขและข้อตกลง!");
                    }
                    else
                    {
                        Global.CreateUser(username,
                            name,
                            surname,
                            birth,
                            email,
                            password,
                            "user");

                        MessageBox.Show("สร้างบัญชีเรียบร้อย");

                        UsernameTextBox.Text = "";
                        NameTextBox.Text = "";
                        SurNameTextBox.Text = "";
                        BirthPicker.Value = DateTime.Now;
                        EmailTextBox.Text = "";
                        PasswordTextBox.Text = "";
                        ConfirmPasswordTextBox.Text = "";

                        Global.OpenLoginPage();
                    }
                }
            }
        }
    }
}
