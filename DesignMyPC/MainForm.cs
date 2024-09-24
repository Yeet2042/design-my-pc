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
        public MainForm()
        {
            InitializeComponent();
            Global.MainContainerPanel = ContainerPanel;

            Global.UserDT.Columns.Add("id", typeof(string));
            Global.UserDT.Columns.Add("username", typeof(string));
            Global.UserDT.Columns.Add("name", typeof(string));
            Global.UserDT.Columns.Add("surname", typeof(string));
            Global.UserDT.Columns.Add("birth", typeof(string));
            Global.UserDT.Columns.Add("email", typeof(string));
            Global.UserDT.Columns.Add("password", typeof(string));
            Global.UserDT.Columns.Add("role", typeof(string));

            Global.UserDT.Rows.Add("USER001", "admin", "admin", "admin", "11/11/2540", "admin@admin.com", "admin", "admin");
            Global.UserDT.Rows.Add("USER002", "user", "user", "user", "22/12/2546", "user@user.com", "user", "user");

            Global.CPU_DT.Columns.Add("id", typeof(string));
            Global.CPU_DT.Columns.Add("type", typeof(string));
            Global.CPU_DT.Columns.Add("brand", typeof(string));
            Global.CPU_DT.Columns.Add("serie", typeof(string));
            Global.CPU_DT.Columns.Add("model", typeof(string));
            Global.CPU_DT.Columns.Add("socket", typeof(string));
            Global.CPU_DT.Columns.Add("chipset", typeof(string));
            Global.CPU_DT.Columns.Add("core", typeof(int));
            Global.CPU_DT.Columns.Add("thread", typeof(int));
            Global.CPU_DT.Columns.Add("bClock", typeof(double));
            Global.CPU_DT.Columns.Add("tClock", typeof(double));
            Global.CPU_DT.Columns.Add("technology", typeof(int));
            Global.CPU_DT.Columns.Add("tdp", typeof(int));
            Global.CPU_DT.Columns.Add("efficient", typeof(int));
            Global.CPU_DT.Columns.Add("price", typeof(int));
            Global.CPU_DT.Columns.Add("link", typeof(string));

            string[] chipsetSet001 = { "A620", "B650", "B650E", "X670", "X670E", "X870", "X870E" };
            string chipset001 = string.Join(",", chipsetSet001);
            Global.CPU_DT.Rows.Add("CPU001", "CPU", "AMD", "Ryzen 9", "9950X", "AM5", chipset001, 16, 32, 4.3, 5.7, 5, 170, 100, 26290, "https://www.bnn.in.th/th/p/computer-hardware-diy/cpu-computer-hardware-diy/amd-cpu-computer-hardware-diy/amd-cpu-ryzen-9-9950x-43ghz-16c32t-am5-730143315272_zpqgko?ref=search-result");

            Global.MB_DT.Columns.Add("id", typeof(string));
            Global.MB_DT.Columns.Add("type", typeof(string));
            Global.MB_DT.Columns.Add("brand", typeof(string));
            Global.MB_DT.Columns.Add("serie", typeof(string));
            Global.MB_DT.Columns.Add("socket", typeof(string));
            Global.MB_DT.Columns.Add("chipset", typeof(string));
            Global.MB_DT.Columns.Add("ramSlot", typeof(int));
            Global.MB_DT.Columns.Add("ramMax", typeof(int));
            Global.MB_DT.Columns.Add("ramType", typeof(string));
            Global.MB_DT.Columns.Add("pcieX16", typeof(int));
            Global.MB_DT.Columns.Add("sata3", typeof(int));
            Global.MB_DT.Columns.Add("m2", typeof(int));
            Global.MB_DT.Columns.Add("formFactor", typeof(string));
            Global.MB_DT.Columns.Add("cpuPhase", typeof(int));
            Global.MB_DT.Columns.Add("efficient", typeof(int));
            Global.MB_DT.Columns.Add("price", typeof(int));
            Global.MB_DT.Columns.Add("link", typeof(string));

            Global.MB_DT.Rows.Add("MB001", "MB", "ASUS", "ROG STRIX", "AM5", "X670E", 4, 192, "DDR5", 2, 4, 4, "ATX", 24, 100, 18880, "https://www.jib.co.th/web/product/readProduct/56450/2597/MAINBOARD--%E0%B9%80%E0%B8%A1%E0%B8%99%E0%B8%9A%E0%B8%AD%E0%B8%A3%E0%B9%8C%E0%B8%94--ASUS-ROG-STRIX-X670E-E-GAMING-WIFI--SOCKET-AM5---ATX-");

            Global.RAM_DT.Columns.Add("id", typeof(string));
            Global.RAM_DT.Columns.Add("type", typeof(string));
            Global.RAM_DT.Columns.Add("brand", typeof(string));
            Global.RAM_DT.Columns.Add("serie", typeof(string));
            Global.RAM_DT.Columns.Add("ramType", typeof(string));
            Global.RAM_DT.Columns.Add("size", typeof(int));
            Global.RAM_DT.Columns.Add("sizeType", typeof(string));
            Global.RAM_DT.Columns.Add("speed", typeof(int));
            Global.RAM_DT.Columns.Add("cl", typeof(string));
            Global.RAM_DT.Columns.Add("color", typeof(string));
            Global.RAM_DT.Columns.Add("power", typeof(int));
            Global.RAM_DT.Columns.Add("efficient", typeof(int));
            Global.RAM_DT.Columns.Add("price", typeof(int));
            Global.RAM_DT.Columns.Add("link", typeof(string));

            Global.RAM_DT.Rows.Add("RAM001", "RAM", "COSAIR", "Dominator Titanium", "DDR5", 64, "32x2", 6400, "32-40-40-84", "white", 2, 100 , 12790, "https://www.bnn.in.th/th/p/corsair-ram-pc-ddr5-64gb6400mhz-cl32-dominator-titanium-rgb-white-cmp64gx5m2b6400c32w-840006674467_z3q240?utm_source=notebookspec.com&utm_medium=referral&utm_campaign=ecom_notebookspec_PCcomponent_ram_corsair-dominator-titanium-rgb-ddr5-64gb-32gbx2-6400-white");

            Global.GPU_DT.Columns.Add("id", typeof(string));
            Global.GPU_DT.Columns.Add("type", typeof(string));
            Global.GPU_DT.Columns.Add("brand", typeof(string));
            Global.GPU_DT.Columns.Add("subBrand", typeof(string));
            Global.GPU_DT.Columns.Add("serie", typeof(string));
            Global.GPU_DT.Columns.Add("model", typeof(string));
            Global.GPU_DT.Columns.Add("bClock", typeof(int));
            Global.GPU_DT.Columns.Add("tClock", typeof(int));
            Global.GPU_DT.Columns.Add("ramType", typeof(string));
            Global.GPU_DT.Columns.Add("ramSize", typeof(int));
            Global.GPU_DT.Columns.Add("interface", typeof(string));
            Global.GPU_DT.Columns.Add("power", typeof(int));
            Global.GPU_DT.Columns.Add("efficient", typeof(int));
            Global.GPU_DT.Columns.Add("price", typeof(int));
            Global.GPU_DT.Columns.Add("link", typeof(string));

            Global.GPU_DT.Rows.Add("GPU001", "GPU", "NVIDIA", "ASUS", "ROG STRIX", "RTX 4090", 2235, 2640, "GDDR6X", 24, "X16", 1000, 100, 93900, "https://www.advice.co.th/product/graphic-card-vga-/nvidia-4000-series/vga-asus-geforce-rtx-4090-rog-strix-o24g-gaming-btf-24gb-gddr6x");

            Global.SSD_DT.Columns.Add("id", typeof(string));
            Global.SSD_DT.Columns.Add("type", typeof(string));
            Global.SSD_DT.Columns.Add("brand", typeof(string));
            Global.SSD_DT.Columns.Add("serie", typeof(string));
            Global.SSD_DT.Columns.Add("model", typeof(string));
            Global.SSD_DT.Columns.Add("interface", typeof(string));
            Global.SSD_DT.Columns.Add("protocal", typeof(string));
            Global.SSD_DT.Columns.Add("size", typeof(int));
            Global.SSD_DT.Columns.Add("read", typeof(int));
            Global.SSD_DT.Columns.Add("write", typeof(int));
            Global.SSD_DT.Columns.Add("cell", typeof(string));
            Global.SSD_DT.Columns.Add("tbw", typeof(int));
            Global.SSD_DT.Columns.Add("technology", typeof(string));
            Global.SSD_DT.Columns.Add("power", typeof(int));
            Global.SSD_DT.Columns.Add("efficient", typeof(int));
            Global.SSD_DT.Columns.Add("price", typeof(int));
            Global.SSD_DT.Columns.Add("link", typeof(string));

            Global.SSD_DT.Rows.Add("SSD001", "SSD", "SAMSUNG", "PRO", "990", "M.2", "NVME", 4, 7450, 6900, "TLC", 1200, "3D-NAND", 10, 100, 14250, "https://www.advice.co.th/product/ssd-solid-state-drive-/ssd-m-2-pcie-nvme-2-tb-up/4-tb-ssd-m-2-pcie-4-0-samsung-990-pro-mz-v9p4t0bw-");

            Global.HDD_DT.Columns.Add("id", typeof(string));
            Global.HDD_DT.Columns.Add("type", typeof(string));
            Global.HDD_DT.Columns.Add("brand", typeof(string));
            Global.HDD_DT.Columns.Add("serie", typeof(string));
            Global.HDD_DT.Columns.Add("formFactor", typeof(string));
            Global.HDD_DT.Columns.Add("interface", typeof(string));
            Global.HDD_DT.Columns.Add("size", typeof(int));
            Global.HDD_DT.Columns.Add("speed", typeof(int));
            Global.HDD_DT.Columns.Add("buffer", typeof(int));
            Global.HDD_DT.Columns.Add("power", typeof(int));
            Global.HDD_DT.Columns.Add("efficient", typeof(int));
            Global.HDD_DT.Columns.Add("price", typeof(int));
            Global.HDD_DT.Columns.Add("link", typeof(string));

            Global.HDD_DT.Rows.Add("HDD001", "HDD", "WD", "Black", "3.5", "SATA3", 10, 7200, 256, 8, 100, 11660, "https://www.advice.co.th/product/hard-disk-for-pc/hard-disk-pc-sata-iii-8-tb-up-/10-tb-hdd-wd-black-7200rpm-256mb-sata-3-wd101fzbx-");

            Global.PSU_DT.Columns.Add("id", typeof(string));
            Global.PSU_DT.Columns.Add("type", typeof(string));
            Global.PSU_DT.Columns.Add("brand", typeof(string));
            Global.PSU_DT.Columns.Add("serie", typeof(string));
            Global.PSU_DT.Columns.Add("formFactor", typeof(string));
            Global.PSU_DT.Columns.Add("maxPower", typeof(int));
            Global.PSU_DT.Columns.Add("cert", typeof(string));
            Global.PSU_DT.Columns.Add("modular", typeof(bool));
            Global.PSU_DT.Columns.Add("efficient", typeof(int));
            Global.PSU_DT.Columns.Add("price", typeof(int));
            Global.PSU_DT.Columns.Add("link", typeof(string));

            Global.PSU_DT.Rows.Add("PSU001", "PSU", "ASUS", "THOR", "ATX", 1600, "80+ Titanium", true, 100, 16900, "https://www.advice.co.th/product/power-supply/-80plustitanium-1000w-1600w-/power-supply-80plus-titanium-1600w-asus-rog-thor-1600t");

            Global.COOLER_DT.Columns.Add("id", typeof(string));
            Global.COOLER_DT.Columns.Add("type", typeof(string));
            Global.COOLER_DT.Columns.Add("brand", typeof(string));
            Global.COOLER_DT.Columns.Add("serie", typeof(string));
            Global.COOLER_DT.Columns.Add("model", typeof(string));
            Global.COOLER_DT.Columns.Add("coolerType", typeof(string));
            Global.COOLER_DT.Columns.Add("socket", typeof(string));
            Global.COOLER_DT.Columns.Add("size", typeof(string));
            Global.COOLER_DT.Columns.Add("tdp", typeof(string));
            Global.COOLER_DT.Columns.Add("efficient", typeof(int));
            Global.COOLER_DT.Columns.Add("price", typeof(int));
            Global.COOLER_DT.Columns.Add("link", typeof(string));

            string[] socketSet001 = { "AM5", "AM4", "sTRX4", "TR4", "1700", "1151", "1150", "1155", "1156", "1366", "2011", "2011-3", "2066" };
            string socket001 = string.Join(",", socketSet001);
            Global.COOLER_DT.Rows.Add("CL001", "CL", "NZXT", "Kraken", "Z73", "AIO", socket001, 360, 200, 100, 10900, "https://www.advice.co.th/product/cooling-system/liquid-cooling/liquid-cooling-nzxt-kraken-z73");

            Global.CASE_DT.Columns.Add("id", typeof(string));
            Global.CASE_DT.Columns.Add("type", typeof(string));
            Global.CASE_DT.Columns.Add("brand", typeof(string));
            Global.CASE_DT.Columns.Add("serie", typeof(string));
            Global.CASE_DT.Columns.Add("model", typeof(string));
            Global.CASE_DT.Columns.Add("formFactor", typeof(string));
            Global.CASE_DT.Columns.Add("MBFormFactor", typeof(string));
            Global.CASE_DT.Columns.Add("color", typeof(string));
            Global.CASE_DT.Columns.Add("price", typeof(int));
            Global.CASE_DT.Columns.Add("link", typeof(string));

            Global.CASE_DT.Rows.Add("CASE001", "CASE", "NZXT", "H9", "Elite", "Mid-Tower", "ATX", "black", 8790, "https://www.bnn.in.th/th/p/nzxt-computer-case-h9-elite-black-cm-h91eb-01-810074842518_z73l86?utm_source=notebookspec.com&utm_medium=referral&utm_campaign=ecom_notebookspec_PCcomponent_case_nzxt-h9-elite-black");
            Global.CASE_DT.Rows.Add("CASE001", "CASE", "NZXT", "H9", "Elite", "Mid-Tower", "ATX", "black", 8790, "https://www.bnn.in.th/th/p/nzxt-computer-case-h9-elite-black-cm-h91eb-01-810074842518_z73l86?utm_source=notebookspec.com&utm_medium=referral&utm_campaign=ecom_notebookspec_PCcomponent_case_nzxt-h9-elite-black");
            Global.CASE_DT.Rows.Add("CASE001", "CASE", "NZXT", "H9", "Elite", "Mid-Tower", "ATX", "black", 8790, "https://www.bnn.in.th/th/p/nzxt-computer-case-h9-elite-black-cm-h91eb-01-810074842518_z73l86?utm_source=notebookspec.com&utm_medium=referral&utm_campaign=ecom_notebookspec_PCcomponent_case_nzxt-h9-elite-black");

            Global.PcDT.Columns.Add("id", typeof(string));
            Global.PcDT.Columns.Add("author_id", typeof(string));
            Global.PcDT.Columns.Add("name", typeof(string));
            Global.PcDT.Columns.Add("cpu", typeof(string));
            Global.PcDT.Columns.Add("mb", typeof(string));
            Global.PcDT.Columns.Add("ram", typeof(string));
            Global.PcDT.Columns.Add("gpu", typeof(string));
            Global.PcDT.Columns.Add("ssd", typeof(string));
            Global.PcDT.Columns.Add("hdd", typeof(string));
            Global.PcDT.Columns.Add("psu", typeof(string));
            Global.PcDT.Columns.Add("cooler", typeof(string));
            Global.PcDT.Columns.Add("case", typeof(string));
            Global.PcDT.Columns.Add("price", typeof(uint));
            Global.PcDT.Columns.Add("efficient", typeof(uint));
            Global.PcDT.Columns.Add("cooling", typeof(uint));
            Global.PcDT.Columns.Add("wattage", typeof(uint));

            Global.PcDT.Rows.Add("PC001", "USER001", "Super PC1", "AMD Ryzen 9 9950X", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 100, 100, 750);
            Global.PcDT.Rows.Add("PC002", "USER001", "Mid PC2", "Intel Core i5 12100F", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 45000, 65, 100, 500);
            Global.PcDT.Rows.Add("PC003", "USER001", "Lowend PC3", "Intel Core 2 duo", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 10000, 10, 100, 300);
            Global.PcDT.Rows.Add("PC004", "USER001", "Super PC4", "AMD Ryzen 9 9950X", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 126000, 100, 100, 750);
            Global.PcDT.Rows.Add("PC005", "USER001", "Mid PC5", "Intel Core i5 12100F", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 55000, 65, 100, 500);
            Global.PcDT.Rows.Add("PC006", "USER001", "Lowend PC6", "Intel Core 2 duo", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 26000, 10, 100, 300);
            Global.PcDT.Rows.Add("PC007", "USER001", "Super PC7", "AMD Ryzen 9 9950X", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 100, 100, 750);
            Global.PcDT.Rows.Add("PC008", "USER001", "Mid PC8", "Intel Core i5 12100F", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 65, 100, 500);
            Global.PcDT.Rows.Add("PC009", "USER001", "Lowend PC9", "Intel Core 2 duo", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 10, 100, 300);
            Global.PcDT.Rows.Add("PC010", "USER001", "Super PC10", "AMD Ryzen 9 9950X", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 100, 100, 750);
            Global.PcDT.Rows.Add("PC011", "USER001", "Mid PC11", "Intel Core i5 12100F", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 65, 100, 500);
            Global.PcDT.Rows.Add("PC012", "USER001", "Lowend PC12", "Intel Core 2 duo", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 10, 100, 300);
            Global.PcDT.Rows.Add("PC013", "USER001", "Super PC13", "AMD Ryzen 9 9950X", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 100, 100, 750);
            Global.PcDT.Rows.Add("PC014", "USER001", "Mid PC14", "Intel Core i5 12100F", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 65, 100, 500);
            Global.PcDT.Rows.Add("PC015", "USER001", "Lowend PC15", "Intel Core 2 duo", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 10, 100, 300);
            Global.PcDT.Rows.Add("PC016", "USER001", "Super PC16", "AMD Ryzen 9 9950X", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 100, 100, 750);
            Global.PcDT.Rows.Add("PC017", "USER001", "Mid PC17", "Intel Core i5 12100F", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 65, 100, 500);
            Global.PcDT.Rows.Add("PC018", "USER001", "Lowend PC18", "Intel Core 2 duo", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 10, 100, 300);
            Global.PcDT.Rows.Add("PC019", "USER001", "Super PC19", "AMD Ryzen 9 9950X", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 100, 100, 750);
            Global.PcDT.Rows.Add("PC020", "USER001", "Mid PC20", "Intel Core i5 12100F", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 65, 100, 500);
            Global.PcDT.Rows.Add("PC021", "USER001", "Lowend PC21", "Intel Core 2 duo", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 10, 100, 300);
            Global.PcDT.Rows.Add("PC022", "USER001", "Super PC22", "AMD Ryzen 9 9950X", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 100, 100, 750);
            Global.PcDT.Rows.Add("PC023", "USER001", "Mid PC23", "Intel Core i5 12100F", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 65, 100, 500);
            Global.PcDT.Rows.Add("PC024", "USER001", "Lowend PC24", "Intel Core 2 duo", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 10, 100, 300);
            Global.PcDT.Rows.Add("PC025", "USER001", "Super PC25", "AMD Ryzen 9 9950X", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 100, 100, 750);
            Global.PcDT.Rows.Add("PC026", "USER001", "Mid PC26", "Intel Core i5 12100F", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 65, 100, 500);
            Global.PcDT.Rows.Add("PC027", "USER001", "Lowend PC27", "Intel Core 2 duo", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 10, 100, 300);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            LoginPage loginPage = new LoginPage();
            RegisterPage registerPage = new RegisterPage();

            landingPage.TopLevel = false;
            loginPage.TopLevel = false;
            registerPage.TopLevel = false;

            Global.LoginPage = loginPage;
            Global.RegisterPage = registerPage;

            ContainerPanel.Controls.Add(landingPage);
            landingPage.Show();
        }
    }
}
