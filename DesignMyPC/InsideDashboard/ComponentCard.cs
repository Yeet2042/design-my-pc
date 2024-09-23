using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DesignMyPC.InsideDashboard
{
    public partial class ComponentCard : Form
    {
        public ComponentCard(
            string type, 
            string brand , 
            string serie, 
            string model, 

            //cpu
            string core, 
            string thread, 
            string bClock, 
            string tClock, 
            string tdp, 

            //mb
            string socket,
            string chipset,
            string ramType,
            string FF,

            //ram
            string ramRamType,
            string size,
            string speed,

            //gpu
            string gpuBClock,
            string gpuTClock,
            string gpuRamType,
            string gpuRamSize,

            //ssd
            string ssdInterface,
            string protocal,
            string ssdSize,
            string ssdRead,
            string ssdWrite,

            //hdd
            string hddFF,
            string hddSize,
            string hddSpeed,

            //psu
            string psuFF,
            string psuPower,
            string psuCert,

            //cooler
            string coolerType,
            string coolerSize,
            string coolerTDP,

            //case
            string caseFF,
            string mbSize,
            string color,

            string price
        )
        {
            InitializeComponent();

            ComponentName.Text = brand + " " + serie + " " + model;

            if (type == "CPU")
            {
                label1.Text = "Cores";
                label2.Text = "TDP";
                label3.Text = "Speed";

                ComponentLabel1.Text = core + " / " + thread;
                ComponentLabel2.Text = tdp;
                ComponentLabel3.Text = bClock + " / " + tClock;
            }
            else if (type == "MB")
            {
                ComponentName.Text = brand + " " + serie + " " + model + " " + chipset;

                label1.Text = "Socket";
                label2.Text = "Ram";
                label3.Text = "Size";

                ComponentLabel1.Text = socket;
                ComponentLabel2.Text = ramType;
                ComponentLabel3.Text = FF;
            }else if (type == "RAM")
            {

                label1.Text = "Type";
                label2.Text = "Size";
                label3.Text = "Speed";

                ComponentLabel1.Text = ramRamType;
                ComponentLabel2.Text = size + " gb";
                ComponentLabel3.Text = speed + " Mhz";
            }else if (type == "GPU")
            {

                label1.Text = "Speed";
                label2.Text = "Ram";
                label3.Text = "Size";

                ComponentLabel1.Text = gpuBClock + " / " + gpuTClock;
                ComponentLabel2.Text = gpuRamType;
                ComponentLabel3.Text = gpuRamSize + " gb";
            }else if (type == "SSD")
            {

                label1.Text = "Type";
                label2.Text = "Size";
                label3.Text = "W/R (Mbps)";

                ComponentLabel1.Text = ssdInterface + " " + protocal;
                ComponentLabel2.Text = ssdSize + " tb";
                ComponentLabel3.Text = ssdRead + " / " + ssdWrite;
            }else if (type == "HDD")
            {

                label1.Text = "Type";
                label2.Text = "Size";
                label3.Text = "Speed";

                ComponentLabel1.Text = hddFF;
                ComponentLabel2.Text = hddSize + " tb";
                ComponentLabel3.Text = hddSpeed + " rpm";
            }else if (type == "PSU")
            {

                label1.Text = "Type";
                label2.Text = "Wattage";
                label3.Text = "Cert";

                ComponentLabel1.Text = psuFF;
                ComponentLabel2.Text = psuPower + " w";
                ComponentLabel3.Text = psuCert;
            }else if (type == "CL")
            {

                label1.Text = "Type";
                label2.Text = "Size";
                label3.Text = "TDP";

                ComponentLabel1.Text = coolerType;
                ComponentLabel2.Text = coolerSize;
                ComponentLabel3.Text = coolerTDP;
            }else if (type == "CASE")
            {

                label1.Text = "Size";
                label2.Text = "Max MB";
                label3.Text = "Color";

                ComponentLabel1.Text = caseFF;
                ComponentLabel2.Text = mbSize;
                ComponentLabel3.Text = color;
            }
            
            PriceLabel.Text = price + " ฿";

            int space = 10;
            int space2 = 10;

            int totalLabelWidth = label1.Width + label2.Width + label3.Width + 2 * space;
            int startLabel = (this.Width - totalLabelWidth) / 2;

            int totalComponentLabelWidth = ComponentLabel1.Width + ComponentLabel2.Width + ComponentLabel3.Width + 2 * space2;
            int startComponentLabel = (this.Width - totalComponentLabelWidth) / 2;

            ComponentName.Left = (this.Width - ComponentName.Width) / 2;
            PriceLabel.Left = (this.Width - PriceLabel.Width) / 2;
            label1.Left = startLabel;
            label2.Left = startLabel + label1.Width + space;
            label3.Left = startLabel + label1.Width + label2.Width + 2 * space;
            ComponentLabel1.Left = startComponentLabel;
            ComponentLabel2.Left = startComponentLabel + ComponentLabel1.Width + space2;
            ComponentLabel3.Left = startComponentLabel + ComponentLabel1.Width + ComponentLabel2.Width + 2 * space2;

        }
    }
}
