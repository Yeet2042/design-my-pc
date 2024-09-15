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

        DataTable FilteredCPU_DT;
        DataTable FilteredMB_DT;
        DataTable FilteredRAM_DT;
        DataTable FilteredGPU_DT;
        DataTable FilteredSSD_DT;
        DataTable FilteredHDD_DT;
        DataTable FilteredPSU_DT;
        DataTable FilteredCOOLER_DT;
        DataTable FilteredCASE_DT;

        int TotalRows;

        string SelectedType = "";
        string SelectedBrand = "";
        string SelectedSerie = "";
        string SelectedModel = "";

        string[] CPUBrand = { "", "AMD", "INTEL" };
        string[] MBBrand = { "", "ASROCK", "ASUS", "BIOSTAR", "EVGA", "GIGABYTE", "MSI" };
        string[] RAMBrand = { "", "CORSAIR", "CRUCIAL", "G.SKILL", "KINGSTON", "PATRIOT", "SK HYNIX", "TEAMGROUP" };
        string[] GPUBrand = { "", "AMD", "ASUS", "EVGA", "GIGABYTE", "MSI", "NVIDIA", "SAPPHIRE", "XFX", "ZOTAC" };
        string[] SSDBrand = { "", "ADATA", "CORSAIR", "CRUCIAL", "KINGSTON", "SAMSUNG", "SANDISK", "SEAGATE", "TEAMGROUP", "WD" };
        string[] HDDBrand = { "", "HITACHI", "SEAGATE", "TOSHIBA", "WD" };
        string[] PSUBrand = { "", "ANTEC", "ASUS", "COOLER MASTER", "CORSAIR", "EVGA", "FSP", "NZXT", "SEASONIC", "SILVERSTONE", "THERMALTAKE" };
        string[] COOLERBrand = { "", "ARCTIC", "COOLER MASTER", "CORSAIR", "DEEPCOOL", "NOCTUA", "NZXT", "THERMALTAKE" };
        string[] CASEBrand = { "", "COOLER MASTER", "CORSAIR", "FRACTAL DESIGN", "LIAN LI", "NZXT", "PHANTEKS", "THERMALTAKE" };

        string[] CPUSeries = { "", "Ryzen 3", "Ryzen 5", "Ryzen 7", "Ryzen 9", "Threadripper", "Core i3", "Core i5", "Core i7", "Core i9", "Xeon" };
        
        string[] RamType = { "", "DDR4", "DDR5", "ECC DDR4", "ECC DDR5" };
        string[] RamSpeed = {  "",
            "2133 MHz", "2400 MHz", "2666 MHz", "2933 MHz", "3000 MHz",
            "3200 MHz", "3466 MHz", "3600 MHz", "3733 MHz", "3866 MHz",
            "4000 MHz", "4133 MHz", "4266 MHz", "4400 MHz", "4600 MHz",
            "4800 MHz", "5000 MHz", "5200 MHz", "5400 MHz", "5600 MHz",
            "6000 MHz", "6200 MHz", "6400 MHz", "6600 MHz", "6800 MHz",
            "7200 MHz", "7400 MHz", "7600 MHz", "7800 MHz", "8000 MHz"
        };

        string[] GPUSeriesAMD = {  "",
            "Radeon RX 500 Series", "Radeon RX 5000 Series", "Radeon RX 6000 Series", "Radeon RX 7000 Series",
            "Radeon RX Vega Series", "Radeon Pro Series", "Radeon R9 Series", "Radeon R7 Series", "Radeon R5 Series"
        };
        string[] GPUSeriesNVIDIA = {  "",
            "GeForce GTX 10 Series", "GeForce GTX 16 Series", "GeForce RTX 20 Series", "GeForce RTX 30 Series",
            "GeForce RTX 40 Series", "GeForce GTX 900 Series", "GeForce GTX 700 Series", "GeForce RTX A Series (Quadro)",
            "Titan Series", "NVIDIA Quadro Series", "NVIDIA Tesla Series"
        };
        string[] GPUChipset = { "", "AMD", "NVIDIA" };

        string[] SSDCapacity = {"",
            "120GB", "240GB", "250GB", "500GB", "1TB", "2TB", "4TB", "8TB"
        };
        string[] SSDInterface = {"",
            "SATA3", "M.2 NVMe", "M.2 SATA"
        };

        string[] HDDCapacity = {"",
            "1TB", "2TB", "4TB", "6TB", "8TB", "10TB", "12TB"
        };

        string[] PSUWattage = {"",
            "300W", "400W", "500W", "600W", "650W", "750W", "850W", "1000W", "1200W"
        };
        string[] PSUCertification = {"",
            "80+", "80+ Bronze", "80+ Silver", "80+ Gold", "80+ Platinum", "80+ Titanium"
        };

        string[] COOLERff = { "", "AIO", "Tower", "Normal" };

        string[] CASESize = {
            "Full-Tower", "Mid-Tower", "Mini-Tower"
        };
        string[] CASEFormFactor = {
            "ATX", "Micro-ATX", "Mini-ITX", "E-ATX"
        };

        string[] socketAMD = { "", "AM4", "AM5", "sTRX4" };
        string[] socketIntel = { "", "LGA 1151", "LGA 1151-V2", "LGA 1155", "LGA 1200", "LGA 1700", "LGA 2011", "LGA 2011-3" };

        string[] chipsetAMD = {  "",
            "A320", "B350", "B450", "B550", "X370", "X470", "X570",
            "A620", "B650", "B650E", "X670", "X670E",
            "TRX40", "sTRX4"
        };
        string[] chipsetIntel = {  "",
            "H310", "B360", "B365", "H370", "Z370", "Z390",
            "H410", "B460", "H470", "Z490", "H510", "B560", "H570", "Z590",
            "H610", "B660", "H670", "Z690",
            "B760", "H770", "Z790",
            "X79",
            "X99"
        };
        public ComponentsPage()
        {
            InitializeComponent();

            FilteredCPU_DT = Global.CPU_DT;
            FilteredMB_DT = Global.MB_DT;
            FilteredRAM_DT = Global.RAM_DT;
            FilteredGPU_DT = Global.GPU_DT;
            FilteredSSD_DT = Global.SSD_DT;
            FilteredHDD_DT = Global.HDD_DT;
            FilteredPSU_DT = Global.PSU_DT;
            FilteredCOOLER_DT = Global.COOLER_DT;
            FilteredCASE_DT = Global.CASE_DT;

            PreviousPageButton.Left = ((this.Width - PreviousPageButton.Width) / 2) - 32;
            NextPageButton.Left = ((this.Width - NextPageButton.Width) / 2) + 32;
            PageNumber.Left = ((this.Width - PageNumber.Width) / 2);

            PreviousPageButton.Visible = false;
            PageNumber.Text = (CurrentPage + 1).ToString();

            string[] typeFilterArray = { "", "CPU", "Mainboard", "RAM", "GPU", "SSD", "HDD", "PSU", "CPU Cooler", "CASE" };

            foreach (var item in typeFilterArray)
            {
                TypeFilter.Items.Add(item);
            }

            AddComponent addComponent = new AddComponent();
            addComponent.TopLevel = false;
            AddComponent = addComponent;

            TotalPage();
        }
        private void TotalPage()
        {
            TotalRows = 0;
            TotalRows += FilteredCPU_DT.Rows.Count;
            TotalRows += FilteredMB_DT.Rows.Count;
            TotalRows += FilteredRAM_DT.Rows.Count;
            TotalRows += FilteredGPU_DT.Rows.Count;
            TotalRows += FilteredSSD_DT.Rows.Count;
            TotalRows += FilteredHDD_DT.Rows.Count;
            TotalRows += FilteredPSU_DT.Rows.Count;
            TotalRows += FilteredCOOLER_DT.Rows.Count;
            TotalRows += FilteredCASE_DT.Rows.Count;

            double rowsPerPage = 10;
            double pages = TotalRows / rowsPerPage;

            TotalPages = Convert.ToInt32(Math.Ceiling(pages)) - 1;
        }
        private string CardName(int index)
        {
            string prefix = "CardPanel";
            string n = Convert.ToString(index);
            return prefix + n;
        }
        private void UpdatePage()
        {
            CurrentPage = 0;
            PageNumber.Text = (CurrentPage + 1).ToString();

            TotalPage();
            LoadCard();
        }
        private void ClearCard()
        {
            for (int i = 0; i <= 9; i++)
            {
                string cardName = CardName(i);
                Panel panel = this.Controls.Find(cardName, true).FirstOrDefault() as Panel;
                panel.Controls.Clear();
            }
        }
        private void LoadCard()
        {
            ClearCard();

            int rowsPerPage = 10;
            int startIndex = CurrentPage == 0 && Global.LogInRole == "admin" ? 0 : CurrentPage * rowsPerPage - 1;
            int endIndex = Math.Min(startIndex + rowsPerPage, TotalRows);
            int startOnCard = CurrentPage == 0 && Global.LogInRole == "admin" ? 1 : 0;

            if (CurrentPage == 0 && Global.LogInRole == "admin")
            {
                CardPanel0.Controls.Add(AddComponent);
                AddComponent.Show();
            }

            for (int i = startIndex; i < 1; i++)
            {
                string cardName = CardName(startOnCard);
                Panel panel = this.Controls.Find(cardName, true).FirstOrDefault() as Panel;
                startOnCard++;

                if (panel != null)
                {
                    ComponentCard card = new ComponentCard(
                        FilteredCPU_DT.Rows[i]["type"].ToString(),
                        FilteredCPU_DT.Rows[i]["brand"].ToString(),
                        FilteredCPU_DT.Rows[i]["serie"].ToString(),
                        FilteredCPU_DT.Rows[i]["model"].ToString(),
                        FilteredCPU_DT.Rows[i]["core"].ToString(),
                        FilteredCPU_DT.Rows[i]["thread"].ToString(),
                        FilteredCPU_DT.Rows[i]["bClock"].ToString(),
                        FilteredCPU_DT.Rows[i]["tClock"].ToString(),
                        FilteredCPU_DT.Rows[i]["tdp"].ToString(),
                        FilteredCPU_DT.Rows[i]["price"].ToString()
                    );
                    card.TopLevel = false;

                    panel.Controls.Add(card);
                    card.Show();
                }
            }
        }

        private void ComponentsPage_Load(object sender, EventArgs e)
        {
            LoadCard();
        }

        private void TypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DynamicComboBox1.Items.Clear();
            DynamicComboBox2.Items.Clear();
            DynamicComboBox3.Items.Clear();

            if (TypeFilter.SelectedItem.ToString() == "CPU")
            {
                DynamicComboBox1.Text = "Brand";
                DynamicComboBox2.Text = "Series";
                DynamicComboBox3.Text = "Socket";

                foreach (var item in CPUBrand)
                {
                    DynamicComboBox1.Items.Add(item);
                }

                foreach (var item in CPUSeries)
                {
                    DynamicComboBox2.Items.Add(item);
                }

                var combindSocket = socketAMD.Concat(socketIntel);
                foreach (var item in combindSocket)
                {
                    DynamicComboBox3.Items.Add(item);
                }
            }
            else if (TypeFilter.SelectedItem.ToString() == "Mainboard")
            {

                DynamicComboBox1.Text = "Brand";
                DynamicComboBox2.Text = "Socket";
                DynamicComboBox3.Text = "Chipset";

                foreach (var item in MBBrand)
                {
                    DynamicComboBox1.Items.Add(item);
                }

                var combindSocket = socketAMD.Concat(socketIntel);
                foreach (var item in combindSocket)
                {
                    DynamicComboBox2.Items.Add(item);
                }

                var combindChipset = chipsetAMD.Concat(chipsetIntel);
                foreach (var item in combindChipset)
                {
                    DynamicComboBox3.Items.Add(item);
                }

            }
            else if (TypeFilter.SelectedItem.ToString() == "RAM")
            {
                DynamicComboBox1.Text = "Brand";
                DynamicComboBox2.Text = "Ram Type";
                DynamicComboBox3.Text = "Bus Speed";

                foreach (var item in RAMBrand)
                {
                    DynamicComboBox1.Items.Add(item);
                }

                foreach (var item in RamType)
                {
                    DynamicComboBox2.Items.Add(item);
                }
                
                foreach (var item in RamSpeed)
                {
                    DynamicComboBox3.Items.Add(item);
                }
            }
            else if (TypeFilter.SelectedItem.ToString() == "GPU")
            {
                DynamicComboBox1.Text = "Brand";
                DynamicComboBox2.Text = "Series";
                DynamicComboBox3.Text = "Chipset";

                foreach (var item in GPUBrand)
                {
                    DynamicComboBox1.Items.Add(item);
                }

                foreach (var item in GPUChipset)
                {
                    DynamicComboBox2.Items.Add(item);
                }

                var combindGPUSeries = GPUSeriesNVIDIA.Concat(GPUSeriesAMD);
                foreach (var item in combindGPUSeries)
                {
                    DynamicComboBox3.Items.Add(item);
                }
            }
            else if (TypeFilter.SelectedItem.ToString() == "SSD")
            {
                DynamicComboBox1.Text = "Brand";
                DynamicComboBox2.Text = "Capacity";
                DynamicComboBox3.Text = "Interface";

                foreach (var item in SSDBrand)
                {
                    DynamicComboBox1.Items.Add(item);
                }

                foreach (var item in SSDCapacity)
                {
                    DynamicComboBox2.Items.Add(item);
                }

                foreach (var item in SSDInterface)
                {
                    DynamicComboBox3.Items.Add(item);
                }
            }
            else if (TypeFilter.SelectedItem.ToString() == "HDD")
            {
                DynamicComboBox1.Text = "Brand";
                DynamicComboBox2.Text = "Capacity";
                DynamicComboBox3.Text = "";

                foreach (var item in HDDBrand)
                {
                    DynamicComboBox1.Items.Add(item);
                }

                foreach (var item in HDDCapacity)
                {
                    DynamicComboBox2.Items.Add(item);
                }
            }
            else if (TypeFilter.SelectedItem.ToString() == "PSU")
            {
                DynamicComboBox1.Text = "Brand";
                DynamicComboBox2.Text = "Wattage";
                DynamicComboBox3.Text = "Certificate";

                foreach (var item in PSUBrand)
                {
                    DynamicComboBox1.Items.Add(item);
                }

                foreach (var item in PSUWattage)
                {
                    DynamicComboBox2.Items.Add(item);
                }

                foreach (var item in PSUCertification)
                {
                    DynamicComboBox3.Items.Add(item);
                }
            }
            else if (TypeFilter.SelectedItem.ToString() == "CPU Cooler")
            {
                DynamicComboBox1.Text = "Brand";
                DynamicComboBox2.Text = "Form Factor";
                DynamicComboBox3.Text = "";

                foreach (var item in COOLERBrand)
                {
                    DynamicComboBox1.Items.Add(item);
                }

                foreach (var item in COOLERff)
                {
                    DynamicComboBox2.Items.Add(item);
                }
            }
            else if (TypeFilter.SelectedItem.ToString() == "CASE")
            {
                DynamicComboBox1.Text = "Brand";
                DynamicComboBox2.Text = "Form Factor";
                DynamicComboBox3.Text = "Case Size";

                foreach (var item in CASEBrand)
                {
                    DynamicComboBox1.Items.Add(item);
                }

                foreach (var item in CASEFormFactor)
                {
                    DynamicComboBox2.Items.Add(item);
                }

                foreach (var item in CASESize)
                {
                    DynamicComboBox3.Items.Add(item);
                }
            }
        }
    }
}
