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
    public partial class AllComputersPage : Form
    {
        int index;
        public AllComputersPage()
        {
            InitializeComponent();
            PCsDataGridView.DataSource = Global.PcDT;
        }

        private void PCsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if (index >= 0 && index < Global.PcDT.Rows.Count)
            {
                IDTextBox.Text = Global.PcDT.Rows[index]["id"].ToString();
                PCNameTextBox.Text = Global.PcDT.Rows[index]["name"].ToString();
                CreateByTextBox.Text = Global.PcDT.Rows[index]["author_id"].ToString();
                CPUTextBox.Text = Global.PcDT.Rows[index]["cpu"].ToString();
                MBTextBox.Text = Global.PcDT.Rows[index]["mb"].ToString();
                RAMTextBox.Text = Global.PcDT.Rows[index]["ram"].ToString();
                GPUTextBox.Text = Global.PcDT.Rows[index]["gpu"].ToString();
                SSDTextBox.Text = Global.PcDT.Rows[index]["ssd"].ToString();
                HDDTextBox.Text = Global.PcDT.Rows[index]["hdd"].ToString();
                PSUTextBox.Text = Global.PcDT.Rows[index]["psu"].ToString();
                COOLERTextBox.Text = Global.PcDT.Rows[index]["cooling"].ToString();
                CASETextBox.Text = Global.PcDT.Rows[index]["case"].ToString();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (
                PCNameTextBox.Text == "" ||
                CreateByTextBox.Text == ""
                )
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน!");
            }
            else
            {
                Global.PcDT.Rows.Add(
                        Global.AutoID("PC", Global.PcDT),
                        CreateByTextBox.Text,
                        PCNameTextBox.Text,
                        CPUTextBox.Text,
                        MBTextBox.Text,
                        RAMTextBox.Text,
                        GPUTextBox.Text,
                        SSDTextBox.Text,
                        HDDTextBox.Text,
                        PSUTextBox.Text,
                        COOLERTextBox.Text,
                        CASETextBox.Text
                    );

                PCsDataGridView.DataSource = Global.PcDT;
                CreateByTextBox.Text = "";
                PCNameTextBox.Text = "";
                CPUTextBox.Text = "";
                MBTextBox.Text = "";
                RAMTextBox.Text = "";
                GPUTextBox.Text = "";
                SSDTextBox.Text = "";
                HDDTextBox.Text = "";
                PSUTextBox.Text = "";
                COOLERTextBox.Text = "";
                CASETextBox.Text = "";
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Global.PcDT.Rows[index]["id"] = IDTextBox.Text;
            Global.PcDT.Rows[index]["name"] = PCNameTextBox.Text;
            Global.PcDT.Rows[index]["author_id"] = CreateByTextBox.Text;
            Global.PcDT.Rows[index]["cpu"] = CPUTextBox.Text;
            Global.PcDT.Rows[index]["mb"] = MBTextBox.Text;
            Global.PcDT.Rows[index]["ram"] = RAMTextBox.Text;
            Global.PcDT.Rows[index]["gpu"] = GPUTextBox.Text;
            Global.PcDT.Rows[index]["ssd"] = SSDTextBox.Text;
            Global.PcDT.Rows[index]["hdd"] = HDDTextBox.Text;
            Global.PcDT.Rows[index]["psu"] = PSUTextBox.Text;
            Global.PcDT.Rows[index]["cooling"] = COOLERTextBox.Text;
            Global.PcDT.Rows[index]["case"] = CASETextBox.Text;

            PCsDataGridView.DataSource = Global.PcDT;
            CreateByTextBox.Text = "";
            PCNameTextBox.Text = "";
            CPUTextBox.Text = "";
            MBTextBox.Text = "";
            RAMTextBox.Text = "";
            GPUTextBox.Text = "";
            SSDTextBox.Text = "";
            HDDTextBox.Text = "";
            PSUTextBox.Text = "";
            COOLERTextBox.Text = "";
            CASETextBox.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Global.PcDT.Rows[index].Delete();

            PCsDataGridView.DataSource = Global.PcDT;
            CreateByTextBox.Text = "";
            PCNameTextBox.Text = "";
            CPUTextBox.Text = "";
            MBTextBox.Text = "";
            RAMTextBox.Text = "";
            GPUTextBox.Text = "";
            SSDTextBox.Text = "";
            HDDTextBox.Text = "";
            PSUTextBox.Text = "";
            COOLERTextBox.Text = "";
            CASETextBox.Text = "";
        }
    }
}
