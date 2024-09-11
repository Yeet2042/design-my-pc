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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private string CardName(int index)
        {
            string prefix = "CardPanel";
            string n = Convert.ToString(1 + index);
            return prefix + n;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Global.PcDT.Rows.Count; i++)
            {
                string cardName = CardName(i);
                Panel panel = this.Controls.Find(cardName, true).FirstOrDefault() as Panel;

                HomePageCard card = new HomePageCard(Global.PcDT.Rows[i]["name"].ToString());
                card.TopLevel = false;

                panel.Controls.Add(card);
                card.Show();
            }
        }
    }
}
