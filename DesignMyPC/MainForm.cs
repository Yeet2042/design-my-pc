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

            Global.UserDT.Rows.Add("001", "admin", "admin", "admin", "11/11/1991", "admin@admin.com", "admin", "admin");
            Global.UserDT.Rows.Add("002", "user", "user", "user", "22/22/2000", "user@user.com", "user", "user");

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

            Global.PcDT.Rows.Add("001", "001", "Super PC1", "AMD Ryzen 9 9950X", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 100, 100, 750);
            Global.PcDT.Rows.Add("002", "001", "Mid PC2", "Intel Core i5 12100F", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 65, 100, 500);
            Global.PcDT.Rows.Add("003", "001", "Lowend PC3", "Intel Core 2 duo", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 10, 100, 300);
            Global.PcDT.Rows.Add("001", "001", "Super PC4", "AMD Ryzen 9 9950X", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 100, 100, 750);
            Global.PcDT.Rows.Add("002", "001", "Mid PC5", "Intel Core i5 12100F", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 65, 100, 500);
            Global.PcDT.Rows.Add("003", "001", "Lowend PC6", "Intel Core 2 duo", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 10, 100, 300);
            Global.PcDT.Rows.Add("001", "001", "Super PC7", "AMD Ryzen 9 9950X", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 100, 100, 750);
            Global.PcDT.Rows.Add("002", "001", "Mid PC8", "Intel Core i5 12100F", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 65, 100, 500);
            Global.PcDT.Rows.Add("003", "001", "Lowend PC9", "Intel Core 2 duo", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 10, 100, 300);
            Global.PcDT.Rows.Add("001", "001", "Super PC10", "AMD Ryzen 9 9950X", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 100, 100, 750);
            Global.PcDT.Rows.Add("002", "001", "Mid PC11", "Intel Core i5 12100F", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 65, 100, 500);
            Global.PcDT.Rows.Add("003", "001", "Lowend PC12", "Intel Core 2 duo", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 10, 100, 300);
            Global.PcDT.Rows.Add("001", "001", "Super PC13", "AMD Ryzen 9 9950X", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 100, 100, 750);
            Global.PcDT.Rows.Add("002", "001", "Mid PC14", "Intel Core i5 12100F", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 65, 100, 500);
            Global.PcDT.Rows.Add("003", "001", "Lowend PC15", "Intel Core 2 duo", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 10, 100, 300);
            Global.PcDT.Rows.Add("001", "001", "Super PC16", "AMD Ryzen 9 9950X", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 100, 100, 750);
            Global.PcDT.Rows.Add("002", "001", "Mid PC17", "Intel Core i5 12100F", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 65, 100, 500);
            Global.PcDT.Rows.Add("003", "001", "Lowend PC18", "Intel Core 2 duo", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 10, 100, 300);
            Global.PcDT.Rows.Add("001", "001", "Super PC19", "AMD Ryzen 9 9950X", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 100, 100, 750);
            Global.PcDT.Rows.Add("002", "001", "Mid PC20", "Intel Core i5 12100F", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 65, 100, 500);
            Global.PcDT.Rows.Add("003", "001", "Lowend PC21", "Intel Core 2 duo", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 10, 100, 300);
            Global.PcDT.Rows.Add("001", "001", "Super PC22", "AMD Ryzen 9 9950X", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 100, 100, 750);
            Global.PcDT.Rows.Add("002", "001", "Mid PC23", "Intel Core i5 12100F", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 65, 100, 500);
            Global.PcDT.Rows.Add("003", "001", "Lowend PC24", "Intel Core 2 duo", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 10, 100, 300);
            Global.PcDT.Rows.Add("001", "001", "Super PC25", "AMD Ryzen 9 9950X", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 100, 100, 750);
            Global.PcDT.Rows.Add("002", "001", "Mid PC26", "Intel Core i5 12100F", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 65, 100, 500);
            Global.PcDT.Rows.Add("003", "001", "Lowend PC27", "Intel Core 2 duo", "ASUS ROG STRIX X670E-E", "64GB", "ASUS ROG STRIX RTX4090", "2TB", "", "ASUS THOR 1000W", "ROG RUIJIN III AIO 350W", "NZXT H9 Elite", 199000, 10, 100, 300);
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
