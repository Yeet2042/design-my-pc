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
            string core, 
            string thread, 
            string bClock, 
            string tClock, 
            string tdp, 
            string price
        )
        {
            InitializeComponent();

            if (type == "CPU")
            {
                label1.Text = "Cores";
                label2.Text = "TDP";
                label3.Text = "Speed";

                ComponentLabel1.Text = core + " / " + thread;
                ComponentLabel2.Text = tdp;
                ComponentLabel3.Text = bClock + " / " + tClock;
            }

            ComponentName.Text = brand + " " + serie + " " + model;
            
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
