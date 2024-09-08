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
    public partial class LandingPage : Form
    {
        private Panel ContainerPanel;
        public LandingPage(Panel panel)
        {
            InitializeComponent();
            ContainerPanel = panel;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ContainerPanel.Controls.Clear();
            LoginPage f = new LoginPage(ContainerPanel);
            f.TopLevel = false;
            ContainerPanel.Controls.Add(f);
            f.Show();
            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            ContainerPanel.Controls.Clear();
        }
    }
}
