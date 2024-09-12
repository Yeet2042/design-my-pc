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
    public partial class HomePageCard : Form
    {
        public HomePageCard(string name, string cpu, string efficient, string price)
        {
            InitializeComponent();
            PcName.Text = name;
            CPULabel.Text = cpu;
            EfficientLabel.Text = "ประสิทธิภาพ " + efficient.ToString() + " %";
            PriceLabel.Text = price + " บาท";

            int eff = Convert.ToInt32(efficient);

            if (eff >= 0 && eff <= 33)
            {
                PcImage.Image = Properties.Resources.lowend_pc_90px;
            } 
            else if (eff > 33 && eff <= 66)
            {
                PcImage.Image = Properties.Resources.mid_pc_90px;
            } 
            else if (eff > 66 && eff <= 100)
            {
                PcImage.Image = Properties.Resources.highend_pc_90px;
            }
            else
            {
                MessageBox.Show("Error!");
            }

            PcName.Left = (this.Width - PcName.Width) / 2;
            CPULabel.Left = (this.Width - CPULabel.Width) / 2;
            EfficientLabel.Left = (this.Width - EfficientLabel.Width) / 2;
            PriceLabel.Left = (this.Width - PriceLabel.Width) / 2;
        }

    }
}
