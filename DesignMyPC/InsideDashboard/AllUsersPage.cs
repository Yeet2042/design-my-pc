using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignMyPC.InsideDashboard
{
    public partial class AllUsersPage : Form
    {
        int index;
        public AllUsersPage()
        {
            InitializeComponent();
            UsersDataGridView.DataSource = Global.UserDT;
        }

        private void UsersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UsersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            IDTextBox.Text = Global.UserDT.Rows[index]["id"].ToString();
            NameTextBox.Text = Global.UserDT.Rows[index]["name"].ToString();
            SurNameTextBox.Text = Global.UserDT.Rows[index]["surname"].ToString();
            BirthPicker.Value = DateTime.Parse(Global.UserDT.Rows[index]["birth"].ToString());
            UsernameTextBox.Text = Global.UserDT.Rows[index]["username"].ToString();
            EmailTextBox.Text = Global.UserDT.Rows[index]["email"].ToString();
            PasswordTextBox.Text = Global.UserDT.Rows[index]["password"].ToString();
            if (Global.UserDT.Rows[index]["role"].ToString() == "admin")
            {
                AdminRadioButton.Checked = true;
            }
            else
            {
                UserRadioButton.Checked = true;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string role = "user";
            if (AdminRadioButton.Checked)
            {
                role = "admin";
            }

            if (
                UsernameTextBox.Text == "" ||
                NameTextBox.Text == "" ||
                SurNameTextBox.Text == "" ||
                EmailTextBox.Text == "" ||
                PasswordTextBox.Text == ""
                )
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน!");
            }
            else
            {
                Global.UserDT.Rows.Add(
                    Global.AutoID("USER", Global.UserDT),
                    UsernameTextBox.Text,
                    NameTextBox.Text,
                    SurNameTextBox.Text,
                    BirthPicker.Value.ToShortDateString(),
                    EmailTextBox.Text,
                    PasswordTextBox.Text,
                    role
                );

                UsersDataGridView.DataSource = Global.UserDT;
                IDTextBox.Text = "";
                UsernameTextBox.Text = "";
                NameTextBox.Text = "";
                SurNameTextBox.Text = "";
                EmailTextBox.Text = "";
                PasswordTextBox.Text = "";
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string role = "user";
            if (AdminRadioButton.Checked)
            {
                role = "admin";
            }
            Global.UserDT.Rows[index]["username"] = UsernameTextBox.Text;
            Global.UserDT.Rows[index]["name"] = NameTextBox.Text;
            Global.UserDT.Rows[index]["surname"] = SurNameTextBox.Text;
            Global.UserDT.Rows[index]["birth"] = BirthPicker.Value.ToShortDateString();
            Global.UserDT.Rows[index]["email"] = EmailTextBox.Text;
            Global.UserDT.Rows[index]["password"] = PasswordTextBox.Text;
            Global.UserDT.Rows[index]["role"] = role;

            UsersDataGridView.DataSource = Global.UserDT;
            IDTextBox.Text = "";
            UsernameTextBox.Text = "";
            NameTextBox.Text = "";
            SurNameTextBox.Text = "";
            EmailTextBox.Text = "";
            PasswordTextBox.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Global.UserDT.Rows[index].Delete();

            UsersDataGridView.DataSource = Global.UserDT;
            IDTextBox.Text = "";
            UsernameTextBox.Text = "";
            NameTextBox.Text = "";
            SurNameTextBox.Text = "";
            EmailTextBox.Text = "";
            PasswordTextBox.Text = "";
        }
    }
}
