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
    public partial class DesignPage : Form
    {
        public DesignPage()
        {
            InitializeComponent();
            CPUButton.BackColor = Color.FromArgb(42, 54, 80);
            PageLabel.Text = Global.DesignSelectionPage;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Global.CloseApplication();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            Global.MinimizeApplication();
        }

        private void CPUButton_Click(object sender, EventArgs e)
        {
            CPUButton.BackColor = Color.FromArgb(42, 54, 80);
            MBButton.BackColor = Color.FromArgb(51, 62, 83);
            RAMButton.BackColor = Color.FromArgb(51, 62, 83);
            GPUButton.BackColor = Color.FromArgb(51, 62, 83);
            SSDButton.BackColor = Color.FromArgb(51, 62, 83);
            HDDButton.BackColor = Color.FromArgb(51, 62, 83);
            PSUButton.BackColor = Color.FromArgb(51, 62, 83);
            COOLERButton.BackColor = Color.FromArgb(51, 62, 83);
            CASEButton.BackColor = Color.FromArgb(51, 62, 83);
            Global.DesignSelectionPage = "ซีพียู";
            PageLabel.Text = Global.DesignSelectionPage;
        }

        private void MBButton_Click(object sender, EventArgs e)
        {
            CPUButton.BackColor = Color.FromArgb(51, 62, 83);
            MBButton.BackColor = Color.FromArgb(42, 54, 80);
            RAMButton.BackColor = Color.FromArgb(51, 62, 83);
            GPUButton.BackColor = Color.FromArgb(51, 62, 83);
            SSDButton.BackColor = Color.FromArgb(51, 62, 83);
            HDDButton.BackColor = Color.FromArgb(51, 62, 83);
            PSUButton.BackColor = Color.FromArgb(51, 62, 83);
            COOLERButton.BackColor = Color.FromArgb(51, 62, 83);
            CASEButton.BackColor = Color.FromArgb(51, 62, 83);
            Global.DesignSelectionPage = "เมนบอร์ด";
            PageLabel.Text = Global.DesignSelectionPage;
        }

        private void RAMButton_Click(object sender, EventArgs e)
        {
            CPUButton.BackColor = Color.FromArgb(51, 62, 83);
            MBButton.BackColor = Color.FromArgb(51, 62, 83);
            RAMButton.BackColor = Color.FromArgb(42, 54, 80);
            GPUButton.BackColor = Color.FromArgb(51, 62, 83);
            SSDButton.BackColor = Color.FromArgb(51, 62, 83);
            HDDButton.BackColor = Color.FromArgb(51, 62, 83);
            PSUButton.BackColor = Color.FromArgb(51, 62, 83);
            COOLERButton.BackColor = Color.FromArgb(51, 62, 83);
            CASEButton.BackColor = Color.FromArgb(51, 62, 83);
            Global.DesignSelectionPage = "แรม";
            PageLabel.Text = Global.DesignSelectionPage;
        }

        private void GPUButton_Click(object sender, EventArgs e)
        {
            CPUButton.BackColor = Color.FromArgb(51, 62, 83);
            MBButton.BackColor = Color.FromArgb(51, 62, 83);
            RAMButton.BackColor = Color.FromArgb(51, 62, 83);
            GPUButton.BackColor = Color.FromArgb(42, 54, 83);
            SSDButton.BackColor = Color.FromArgb(51, 62, 83);
            HDDButton.BackColor = Color.FromArgb(51, 62, 83);
            PSUButton.BackColor = Color.FromArgb(51, 62, 83);
            COOLERButton.BackColor = Color.FromArgb(51, 62, 83);
            CASEButton.BackColor = Color.FromArgb(51, 62, 83);
            Global.DesignSelectionPage = "การ์ดจอ";
            PageLabel.Text = Global.DesignSelectionPage;
        }

        private void SSDButton_Click(object sender, EventArgs e)
        {
            CPUButton.BackColor = Color.FromArgb(51, 62, 83);
            MBButton.BackColor = Color.FromArgb(51, 62, 83);
            RAMButton.BackColor = Color.FromArgb(51, 62, 83);
            GPUButton.BackColor = Color.FromArgb(51, 62, 83);
            SSDButton.BackColor = Color.FromArgb(42, 54, 83);
            HDDButton.BackColor = Color.FromArgb(51, 62, 83);
            PSUButton.BackColor = Color.FromArgb(51, 62, 83);
            COOLERButton.BackColor = Color.FromArgb(51, 62, 83);
            CASEButton.BackColor = Color.FromArgb(51, 62, 83);
            Global.DesignSelectionPage = "โซลิดสเตต";
            PageLabel.Text = Global.DesignSelectionPage;
        }

        private void HDDButton_Click(object sender, EventArgs e)
        {
            CPUButton.BackColor = Color.FromArgb(51, 62, 83);
            MBButton.BackColor = Color.FromArgb(51, 62, 83);
            RAMButton.BackColor = Color.FromArgb(51, 62, 83);
            GPUButton.BackColor = Color.FromArgb(51, 62, 83);
            SSDButton.BackColor = Color.FromArgb(51, 62, 83);
            HDDButton.BackColor = Color.FromArgb(42, 54, 83);
            PSUButton.BackColor = Color.FromArgb(51, 62, 83);
            COOLERButton.BackColor = Color.FromArgb(51, 62, 83);
            CASEButton.BackColor = Color.FromArgb(51, 62, 83);
            Global.DesignSelectionPage = "ฮาร์ดดิสก์";
            PageLabel.Text = Global.DesignSelectionPage;
        }

        private void PSUButton_Click(object sender, EventArgs e)
        {
            CPUButton.BackColor = Color.FromArgb(51, 62, 83);
            MBButton.BackColor = Color.FromArgb(51, 62, 83);
            RAMButton.BackColor = Color.FromArgb(51, 62, 83);
            GPUButton.BackColor = Color.FromArgb(51, 62, 83);
            SSDButton.BackColor = Color.FromArgb(51, 62, 83);
            HDDButton.BackColor = Color.FromArgb(51, 62, 83);
            PSUButton.BackColor = Color.FromArgb(42, 54, 83);
            COOLERButton.BackColor = Color.FromArgb(51, 62, 83);
            CASEButton.BackColor = Color.FromArgb(51, 62, 83);
            Global.DesignSelectionPage = "พาวเวอร์ซัพพลาย";
            PageLabel.Text = Global.DesignSelectionPage;
        }

        private void COOLERButton_Click(object sender, EventArgs e)
        {
            CPUButton.BackColor = Color.FromArgb(51, 62, 83);
            MBButton.BackColor = Color.FromArgb(51, 62, 83);
            RAMButton.BackColor = Color.FromArgb(51, 62, 83);
            GPUButton.BackColor = Color.FromArgb(51, 62, 83);
            SSDButton.BackColor = Color.FromArgb(51, 62, 83);
            HDDButton.BackColor = Color.FromArgb(51, 62, 83);
            PSUButton.BackColor = Color.FromArgb(51, 62, 83);
            COOLERButton.BackColor = Color.FromArgb(42, 54, 83);
            CASEButton.BackColor = Color.FromArgb(51, 62, 83);
            Global.DesignSelectionPage = "คูลเลอร์";
            PageLabel.Text = Global.DesignSelectionPage;
        }

        private void CASEButton_Click(object sender, EventArgs e)
        {
            CPUButton.BackColor = Color.FromArgb(51, 62, 83);
            MBButton.BackColor = Color.FromArgb(51, 62, 83);
            RAMButton.BackColor = Color.FromArgb(51, 62, 83);
            GPUButton.BackColor = Color.FromArgb(51, 62, 83);
            SSDButton.BackColor = Color.FromArgb(51, 62, 83);
            HDDButton.BackColor = Color.FromArgb(51, 62, 83);
            PSUButton.BackColor = Color.FromArgb(51, 62, 83);
            COOLERButton.BackColor = Color.FromArgb(51, 62, 83);
            CASEButton.BackColor = Color.FromArgb(42, 54, 83);
            Global.DesignSelectionPage = "เคส";
            PageLabel.Text = Global.DesignSelectionPage;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
