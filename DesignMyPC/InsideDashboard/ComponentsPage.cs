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
    public partial class ComponentsPage : Form
    {
        int CurrentPage = 0;
        int TotalPages;

        Form AddComponent;
        public ComponentsPage()
        {
            InitializeComponent();
        }
    }
}
