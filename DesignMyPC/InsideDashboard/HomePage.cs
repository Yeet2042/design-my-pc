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
        int CurrentPage = 0;
        int TotalPages;

        Form DesignButton;
        public HomePage()
        {
            InitializeComponent();

            PreviousPageButton.Left = ((this.Width - PreviousPageButton.Width) / 2) - 32;
            NextPageButton.Left = ((this.Width - NextPageButton.Width) / 2) + 32;
            PageNumber.Left = ((this.Width - PageNumber.Width) / 2);

            PreviousPageButton.Visible = false;
            PageNumber.Text = CurrentPage.ToString();

            DesignCard designCard = new DesignCard();
            designCard.TopLevel = false;
            DesignButton = designCard;

            double rows = Global.PcDT.Rows.Count;
            double rowsPerPage = 10;
            double pages = rows / rowsPerPage;

            TotalPages = Convert.ToInt32(Math.Ceiling(pages)) - 1;
        }

        private string CardName(int index)
        {
            string prefix = "CardPanel";
            string n = Convert.ToString(index);
            return prefix + n;
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

            if (CurrentPage == 0)
            {
                int startOnCard = 1;
                CardPanel0.Controls.Add(DesignButton);
                DesignButton.Show();

                for (int i = 0; i < 10; i++)
                {
                    string cardName = CardName(startOnCard);
                    Panel panel = this.Controls.Find(cardName, true).FirstOrDefault() as Panel;
                    startOnCard++;

                    if (panel != null)
                    {
                        HomePageCard card = new HomePageCard(Global.PcDT.Rows[i]["name"].ToString(),
                        Global.PcDT.Rows[i]["cpu"].ToString(),
                        Global.PcDT.Rows[i]["efficient"].ToString(),
                        Global.PcDT.Rows[i]["price"].ToString());
                        card.TopLevel = false;

                        panel.Controls.Add(card);
                        card.Show();
                    }
                }
            }
            else
            {
                int rowsPerPage = 10;
                int startIndex = CurrentPage * rowsPerPage - 1;
                int endIndex = Math.Min(startIndex + rowsPerPage, Global.PcDT.Rows.Count);

                int startOnCard = 0;

                for (int i = startIndex; i < endIndex; i++)
                {
                    string cardName = CardName(startOnCard);
                    Panel panel = this.Controls.Find(cardName, true).FirstOrDefault() as Panel;
                    startOnCard++;

                    if (panel != null)
                    {
                        HomePageCard card = new HomePageCard(Global.PcDT.Rows[i]["name"].ToString(),
                        Global.PcDT.Rows[i]["cpu"].ToString(),
                        Global.PcDT.Rows[i]["efficient"].ToString(),
                        Global.PcDT.Rows[i]["price"].ToString());
                        card.TopLevel = false;

                        panel.Controls.Add(card);
                        card.Show();
                    }
                }
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            LoadCard();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            CurrentPage ++;
            PageNumber.Text = (CurrentPage + 1).ToString();
            LoadCard();

            if (CurrentPage != 0)
            {
                PreviousPageButton.Visible = true;
            } 
            else
            {
                PreviousPageButton.Visible = false;
                
            }

            if (CurrentPage != TotalPages)
            {
                NextPageButton.Visible = true;
            }
            else
            {
                NextPageButton.Visible = false;
            }
        }

        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            CurrentPage --;
            PageNumber.Text = (CurrentPage + 1).ToString();
            LoadCard();

            if (CurrentPage != 0)
            {
                PreviousPageButton.Visible = true;
            }
            else
            {
                PreviousPageButton.Visible = false;
                NextPageButton.Visible = true;
            }

            if (CurrentPage != TotalPages)
            {
                NextPageButton.Visible = true;
            }
            else
            {
                NextPageButton.Visible = false;
            }
        }
    }
}
