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
    public partial class DesignCard : Form
    {
        public DesignCard()
        {
            InitializeComponent();
        }

        private void DesignButton_Click(object sender, EventArgs e)
        {
            Global.DashboardSelectedPage = "ออกแบบ";
            DesignPage designPage = new DesignPage();
            designPage.TopLevel = false;
            Global.Design = designPage;

            Global.OpenDesign();
        }
    }
}
