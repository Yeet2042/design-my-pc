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

        DataTable FilteredPcDT;
        DataTable SearchPcDT;

        string SelectedPerformance = "";
        string SelectedPrice = "";
        string SelectedSortby = "";

        public HomePage()
        {
            InitializeComponent();

            FilteredPcDT = Global.PcDT;

            PreviousPageButton.Left = ((this.Width - PreviousPageButton.Width) / 2) - 32;
            NextPageButton.Left = ((this.Width - NextPageButton.Width) / 2) + 32;
            PageNumber.Left = ((this.Width - PageNumber.Width) / 2);

            PreviousPageButton.Visible = false;
            PageNumber.Text = (CurrentPage + 1).ToString();

            PerformanceFilter.Items.Add("");
            PerformanceFilter.Items.Add("High");
            PerformanceFilter.Items.Add("Medium");
            PerformanceFilter.Items.Add("Low");

            PriceFilter.Items.Add("");
            PriceFilter.Items.Add("0 - 25,000");
            PriceFilter.Items.Add("25,001 - 50,000");
            PriceFilter.Items.Add("50,001 - 75,000");
            PriceFilter.Items.Add("75,001 - 100,000");
            PriceFilter.Items.Add("> 100,001");

            Sortby.Items.Add("");
            Sortby.Items.Add("Low -> High");
            Sortby.Items.Add("High -> Low");


            DesignCard designCard = new DesignCard();
            designCard.TopLevel = false;
            DesignButton = designCard;

            TotalPage();
        }

        private void TotalPage()
        {
            double rows = FilteredPcDT.Rows.Count;
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
            int startIndex = CurrentPage == 0 ? 0 : CurrentPage * rowsPerPage - 1;
            int endIndex = Math.Min(startIndex + rowsPerPage, FilteredPcDT.Rows.Count);
            int startOnCard = CurrentPage == 0 ? 1 : 0;

            if (CurrentPage == 0)
            {
                CardPanel0.Controls.Add(DesignButton);
                DesignButton.Show();
            }

            for (int i = startIndex; i < endIndex; i++)
            {
                string cardName = CardName(startOnCard);
                Panel panel = this.Controls.Find(cardName, true).FirstOrDefault() as Panel;
                startOnCard++;

                if (panel != null)
                {
                    HomePageCard card = new HomePageCard(FilteredPcDT.Rows[i]["name"].ToString(),
                    FilteredPcDT.Rows[i]["cpu"].ToString(),
                    FilteredPcDT.Rows[i]["efficient"].ToString(),
                    FilteredPcDT.Rows[i]["price"].ToString());
                    card.TopLevel = false;

                    panel.Controls.Add(card);
                    card.Show();
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

        private void FilterItem() 
        {
            DataView view = new DataView(Global.PcDT);

            string performanceFilter = "";
            string priceFilter = "";

            if (PerformanceFilter.SelectedItem != null)
            {
                if (PerformanceFilter.SelectedItem.ToString() == "High")
                {
                    performanceFilter = "efficient >= 67 AND efficient <= 100";
                }
                else if (PerformanceFilter.SelectedItem.ToString() == "Medium")
                {
                    performanceFilter = "efficient >= 34 AND efficient <= 66";
                }
                else if (PerformanceFilter.SelectedItem.ToString() == "Low")
                {
                    performanceFilter = "efficient >= 0 AND efficient <= 33";
                }
                else
                {
                    performanceFilter = "";
                }
            }

            if (PriceFilter.SelectedItem != null)
            {
                if (PriceFilter.SelectedItem.ToString() == "0 - 25,000")
                {
                    priceFilter = "price >= 0 AND price <= 25000";
                }
                else if (PriceFilter.SelectedItem.ToString() == "25,001 - 50,000")
                {
                    priceFilter = "price >= 25001 AND price <= 50000";
                }
                else if (PriceFilter.SelectedItem.ToString() == "50,001 - 75,000")
                {
                    priceFilter = "price >= 50001 AND price <= 75000";
                }
                else if (PriceFilter.SelectedItem.ToString() == "75,001 - 100,000")
                {
                    priceFilter = "price >= 75001 AND price <= 100000";
                }
                else if (PriceFilter.SelectedItem.ToString() == "> 100,001")
                {
                    priceFilter = "price >= 100001";
                }
                else
                {
                    priceFilter = "";
                }
            }

            if (performanceFilter != "" && priceFilter != "")
            {
                performanceFilter += " AND " + priceFilter;
            }
            else if (priceFilter != "")
            {
                performanceFilter = priceFilter;
            }

            view.RowFilter = performanceFilter;
            FilteredPcDT = view.ToTable();
        }

        private void PerformanceFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterItem();
            UpdatePage();
        }

        private void PriceFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterItem();
            UpdatePage();
        }

        private void SortbyItem()
        {
            DataView view = new DataView(FilteredPcDT);

            if (Sortby.SelectedItem != null)
            {
                if (Sortby.SelectedItem.ToString() == "Low -> High")
                {
                    view.Sort = "price ASC";
                }
                else if (Sortby.SelectedItem.ToString() == "High -> Low")
                {
                    view.Sort = "price DESC";
                }
                else
                {
                    FilteredPcDT = Global.PcDT;
                }
            }

            FilteredPcDT = view.ToTable();
        }

        private void Sortby_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortbyItem();
            UpdatePage();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string t = SearchBox.Text;

            if (t != "")
            {
                DataView view = new DataView(FilteredPcDT);
                view.RowFilter = $"name LIKE '%{t}%'";
                FilteredPcDT = view.ToTable();
            }
            else
            {
                FilterItem();
                SortbyItem();
                UpdatePage();
            }

            CurrentPage = 0;
            PageNumber.Text = (CurrentPage + 1).ToString();

            TotalPage();
            LoadCard();
        }
    }
}
