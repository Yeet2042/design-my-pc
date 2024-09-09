﻿using System;
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
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            MainForm.CloseApplication();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            MainForm.MinimizeApplication();
        }

        private void RegisterButtonInLogin_Click(object sender, EventArgs e)
        {
            MainForm.MainContainerPanel.Controls.Clear();
            LoginPage f = new LoginPage();
            f.TopLevel = false;
            MainForm.MainContainerPanel.Controls.Add(f);
            f.Show();
        }
    }
}
