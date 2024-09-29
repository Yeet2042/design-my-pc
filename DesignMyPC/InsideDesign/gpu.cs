using DesignMyPC.InsideDashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignMyPC.InsideDesign
{
    public partial class gpu : Form
    {
        int CurrentPage = 1;
        int TotalPages;

        int CardPerPage = 6;
        public gpu()
        {
            InitializeComponent();

            PreviousPageButton.Left = ((this.Width - PreviousPageButton.Width) / 2) - 32;
            NextPageButton.Left = ((this.Width - NextPageButton.Width) / 2) + 32;
            PageNumber.Left = ((this.Width - PageNumber.Width) / 2);

            PreviousPageButton.Visible = false;
            PageNumber.Text = CurrentPage.ToString();

            TotalPage();
        }

        private void TotalPage()
        {
            double rows = Global.CPU_DT.Rows.Count;
            double rowsPerPage = 10;
            double pages = rows / rowsPerPage;

            TotalPages = Convert.ToInt32(Math.Ceiling(pages));
        }
        private string CardName(int index)
        {
            string prefix = "CardPanel";
            string n = Convert.ToString(index);
            return prefix + n;
        }
        private void ClearCard()
        {
            for (int i = 1; i < 7; i++)
            {
                string cardName = CardName(i);
                Panel panel = this.Controls.Find(cardName, true).FirstOrDefault() as Panel;
                panel.Controls.Clear();
            }
        }

        private void LoadCard()
        {
            ClearCard();

            int startIndex = CurrentPage == 1 ? 0 : (CardPerPage - 1) + (CurrentPage - 2) * CardPerPage;
            int endIndex = Math.Min(startIndex + CardPerPage, Global.GPU_DT.Rows.Count);
            int startOnCard = 1;

            for (int i = startIndex; i < endIndex; i++)
            {
                string cardName = CardName(startOnCard);
                Panel panel = this.Controls.Find(cardName, true).FirstOrDefault() as Panel;
                startOnCard++;

                if (panel != null)
                {
                    ComponentCard card;

                    card = new ComponentCard(
                            Global.GPU_DT.Rows[i]["id"].ToString(),
                            Global.GPU_DT.Rows[i]["type"].ToString(),
                            Global.GPU_DT.Rows[i]["subBrand"].ToString(),
                            Global.GPU_DT.Rows[i]["serie"].ToString(),
                            Global.GPU_DT.Rows[i]["model"].ToString(),

                            //cpu
                            "",
                            "",
                            "",
                            "",
                            "",

                            //mb
                            "",
                            "",
                            "",
                            "",

                            //ram
                            "",
                            "",
                            "",

                            //gpu
                            Global.GPU_DT.Rows[i]["bClock"].ToString(),
                            Global.GPU_DT.Rows[i]["tClock"].ToString(),
                            Global.GPU_DT.Rows[i]["ramType"].ToString(),
                            Global.GPU_DT.Rows[i]["ramSize"].ToString(),

                            //ssd
                            "",
                            "",
                            "",
                            "",
                            "",

                            //hdd
                            "",
                            "",
                            "",

                            //psu
                            "",
                            "",
                            "",

                            //cooler
                            "",
                            "",
                            "",

                            //case
                            "",
                            "",
                            "",

                            Global.GPU_DT.Rows[i]["price"].ToString()
                        );
                    card.TopLevel = false;

                    panel.Controls.Add(card);
                    card.Show();
                }
            }
        }

        private void setButtonVisibility()
        {
            if (CurrentPage == 1)
            {
                PreviousPageButton.Visible = false;
                NextPageButton.Visible = true;
            }
            else if (CurrentPage == TotalPages)
            {
                PreviousPageButton.Visible = true;
                NextPageButton.Visible = false;
            }
            else
            {
                PreviousPageButton.Visible = true;
                NextPageButton.Visible = true;
            }
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            PageNumber.Text = CurrentPage.ToString();
            LoadCard();
            setButtonVisibility();
        }
        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            PageNumber.Text = CurrentPage.ToString();
            LoadCard();
            setButtonVisibility();
        }

        private void gpu_Load(object sender, EventArgs e)
        {
            LoadCard();
        }
    }
}
