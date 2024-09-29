using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DesignMyPC
{
    public partial class SummaryPage : Form
    {
        string PcID;
        int index;
        public SummaryPage(string pcID)
        {
            InitializeComponent();

            PcID = pcID;

            if (Global.LogInRole == "admin")
            {
                NameLabel.ForeColor = Color.FromArgb(198, 120, 221);
            }
            else
            {
                NameLabel.ForeColor = Color.FromArgb(86, 182, 194);
            }
            NameLabel.Text = Global.LogInName;

            DataRow[] result = Global.PcDT.Select($"id = '{pcID}'");

            if (result.Length > 0)
            {
                DataRow foundRow = result[0];
                index = Global.PcDT.Rows.IndexOf(foundRow);
            }

            PCName.Text = Global.PcDT.Rows[index]["name"].ToString();
            CPULabel.Text = "CPU " + Global.PcDT.Rows[index]["cpu"].ToString();
            MBLabel.Text = "Mainboard " + Global.PcDT.Rows[index]["mb"].ToString();
            RAMLabel.Text = "RAM " + Global.PcDT.Rows[index]["ram"].ToString();
            GPULabel.Text = "GPU " + Global.PcDT.Rows[index]["gpu"].ToString();
            SSDLabel.Text = "SSD " + Global.PcDT.Rows[index]["ssd"].ToString();
            HDDLabel.Text = "HDD " + Global.PcDT.Rows[index]["hdd"].ToString();
            PSULabel.Text = "PSU " + Global.PcDT.Rows[index]["psu"].ToString();
            COOLERLabel.Text = "CPU COOLER " + Global.PcDT.Rows[index]["cooler"].ToString();
            CASELabel.Text = "CASE " + Global.PcDT.Rows[index]["case"].ToString();

            PriceLabel.Text = Global.PcDT.Rows[index]["price"].ToString() + " บาท";
            EffLabel.Text = Global.PcDT.Rows[index]["efficient"].ToString() + " %";
            COOLINGLabel.Text = Global.PcDT.Rows[index]["cooling"].ToString() + " %";
            WatttageLabel.Text = Global.PcDT.Rows[index]["wattage"].ToString() + " w";

            PCName.Left = (panel1.Width - PCName.Width) / 2;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Global.CloseApplication();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            Global.MinimizeApplication();
        }

        private void BackToDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashBoard = new Dashboard();
            dashBoard.TopLevel = false;
            Global.Dashboard = dashBoard;

            Global.OpenDashboard();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            string url = "https://www.advice.co.th/product/computer-hardware";

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("แน่ใจ?", "ลบ PC", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataRow[] rowUpdate = Global.PcDT.Select($"id = '{PcID}'");

                rowUpdate[0].Delete();

                MessageBox.Show("ลบ PC สำเร็จ");

                Dashboard dashboard = new Dashboard();
                dashboard.TopLevel = false;
                Global.Dashboard = dashboard;

                Global.OpenDashboard();
            }
        }
    }
}
