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
    public partial class MainForm : Form
    {
        public static Panel MainContainerPanel;
        public MainForm()
        {
            InitializeComponent();
            MainContainerPanel = ContainerPanel;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LandingPage f = new LandingPage();
            f.TopLevel = false;
            MainContainerPanel.Controls.Add(f);
            f.Show();
        }
    }
}
