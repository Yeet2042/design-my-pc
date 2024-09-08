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
        public Panel ContainerPanel;
        public LoginPage(Panel panel)
        {
            InitializeComponent();
            ContainerPanel = panel;
        }

        private void RegisterButtonInLogin_Click(object sender, EventArgs e)
        {
            ContainerPanel.Controls.Clear();
        }
    }
}
