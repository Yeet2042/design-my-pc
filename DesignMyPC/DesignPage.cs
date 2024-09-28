using DesignMyPC.InsideDesign;
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
        public static string CPUSelected;
        public static string MBSelected = "";
        public static string RAMSelected = "";
        public static string GPUSelected = "";
        public static string SSDSelected = "";
        public static string HDDSelected = "";
        public static string PSUSelected = "";
        public static string COOLERSelected = "";
        public static string CASESelected = "";

        public DesignPage()
        {
            InitializeComponent();
            CPUButton.BackColor = Color.FromArgb(42, 54, 80);
            PageLabel.Text = Global.DesignSelectionPage;

            OpenCPU();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Global.CloseApplication();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            Global.MinimizeApplication();
        }

        private void OpenCPU()
        {
            InsideDesign.cpu cpu = new InsideDesign.cpu();
            cpu.TopLevel = false;

            DesignContainer.Controls.Clear();
            DesignContainer.Controls.Add(cpu);
            cpu.Show();
        }
        private void OpenMB()
        {
            InsideDesign.mb mb = new InsideDesign.mb();
            mb.TopLevel = false;

            DesignContainer.Controls.Clear();
            DesignContainer.Controls.Add(mb);
            mb.Show();
        }
        private void OpenRAM()
        {
            InsideDesign.ram ram = new InsideDesign.ram();
            ram.TopLevel = false;

            DesignContainer.Controls.Clear();
            DesignContainer.Controls.Add(ram);
            ram.Show();
        }
        private void OpenGPU()
        {
            InsideDesign.gpu gpu = new InsideDesign.gpu();
            gpu.TopLevel = false;

            DesignContainer.Controls.Clear();
            DesignContainer.Controls.Add(gpu);
            gpu.Show();
        }
        private void OpenSSD()
        {
            InsideDesign.ssd ssd = new InsideDesign.ssd();
            ssd.TopLevel = false;

            DesignContainer.Controls.Clear();
            DesignContainer.Controls.Add(ssd);
            ssd.Show();
        }
        private void OpenHDD()
        {
            InsideDesign.hdd hdd = new InsideDesign.hdd();
            hdd.TopLevel = false;

            DesignContainer.Controls.Clear();
            DesignContainer.Controls.Add(hdd);
            hdd.Show();
        }
        private void OpenPSU()
        {
            InsideDesign.psu psu = new InsideDesign.psu();
            psu.TopLevel = false;

            DesignContainer.Controls.Clear();
            DesignContainer.Controls.Add(psu);
            psu.Show();
        }
        private void OpenCOOLER()
        {
            InsideDesign.cooler cooler = new InsideDesign.cooler();
            cooler.TopLevel = false;

            DesignContainer.Controls.Clear();
            DesignContainer.Controls.Add(cooler);
            cooler.Show();
        }
        private void OpenCASE()
        {
            InsideDesign.Case Case = new InsideDesign.Case();
            Case.TopLevel = false;

            DesignContainer.Controls.Clear();
            DesignContainer.Controls.Add(Case);
            Case.Show();
        }
        void CPUButton_Click(object sender, EventArgs e)
        {
            OpenCPU();

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
            OpenMB();

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
            OpenRAM();

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
            OpenGPU();

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
            OpenSSD();

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
            OpenHDD();

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
            OpenPSU();

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
            OpenCOOLER();

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
            OpenCASE();

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
            DesignPage designPage = new DesignPage();
            designPage.TopLevel = false;
            Global.Design = designPage;

            Global.OpenDesign();
        }

        private void BackToDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashBoard = new Dashboard();
            dashBoard.TopLevel = false;
            Global.Dashboard = dashBoard;

            Global.OpenDashboard();
        }
    }
}
