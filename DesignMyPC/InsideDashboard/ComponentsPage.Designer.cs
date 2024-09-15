namespace DesignMyPC.InsideDashboard
{
    partial class ComponentsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BrandFilter = new System.Windows.Forms.ComboBox();
            this.TypeFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SeriesFilter = new System.Windows.Forms.ComboBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Sortby = new System.Windows.Forms.ComboBox();
            this.ModelFilter = new System.Windows.Forms.ComboBox();
            this.CardPanel9 = new System.Windows.Forms.Panel();
            this.CardPanel4 = new System.Windows.Forms.Panel();
            this.CardPanel8 = new System.Windows.Forms.Panel();
            this.CardPanel7 = new System.Windows.Forms.Panel();
            this.CardPanel3 = new System.Windows.Forms.Panel();
            this.CardPanel6 = new System.Windows.Forms.Panel();
            this.CardPanel2 = new System.Windows.Forms.Panel();
            this.CardPanel1 = new System.Windows.Forms.Panel();
            this.CardPanel5 = new System.Windows.Forms.Panel();
            this.CardPanel0 = new System.Windows.Forms.Panel();
            this.PageNumber = new System.Windows.Forms.Label();
            this.NextPageButton = new System.Windows.Forms.Button();
            this.PreviousPageButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BrandFilter
            // 
            this.BrandFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.BrandFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrandFilter.ForeColor = System.Drawing.Color.White;
            this.BrandFilter.Location = new System.Drawing.Point(148, 5);
            this.BrandFilter.Name = "BrandFilter";
            this.BrandFilter.Size = new System.Drawing.Size(100, 21);
            this.BrandFilter.TabIndex = 4;
            this.BrandFilter.Text = "Brand";
            // 
            // TypeFilter
            // 
            this.TypeFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.TypeFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeFilter.ForeColor = System.Drawing.Color.White;
            this.TypeFilter.Location = new System.Drawing.Point(42, 5);
            this.TypeFilter.Name = "TypeFilter";
            this.TypeFilter.Size = new System.Drawing.Size(100, 21);
            this.TypeFilter.TabIndex = 2;
            this.TypeFilter.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FIlter";
            // 
            // SeriesFilter
            // 
            this.SeriesFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.SeriesFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeriesFilter.ForeColor = System.Drawing.Color.White;
            this.SeriesFilter.Location = new System.Drawing.Point(254, 5);
            this.SeriesFilter.Name = "SeriesFilter";
            this.SeriesFilter.Size = new System.Drawing.Size(100, 21);
            this.SeriesFilter.TabIndex = 5;
            this.SeriesFilter.Text = "Series";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(182)))), ((int)(((byte)(194)))));
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubmitButton.Location = new System.Drawing.Point(859, 0);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(69, 32);
            this.SubmitButton.TabIndex = 28;
            this.SubmitButton.Text = "ค้นหา";
            this.SubmitButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Location = new System.Drawing.Point(648, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 32);
            this.panel1.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DesignMyPC.Properties.Resources.magnify_icon_20px;
            this.pictureBox1.Location = new System.Drawing.Point(9, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.White;
            this.SearchBox.Location = new System.Drawing.Point(37, 6);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(10);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(153, 19);
            this.SearchBox.TabIndex = 3;
            // 
            // Sortby
            // 
            this.Sortby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.Sortby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sortby.ForeColor = System.Drawing.Color.White;
            this.Sortby.Location = new System.Drawing.Point(521, 5);
            this.Sortby.Name = "Sortby";
            this.Sortby.Size = new System.Drawing.Size(121, 21);
            this.Sortby.TabIndex = 26;
            this.Sortby.Text = "Sort by";
            // 
            // ModelFilter
            // 
            this.ModelFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ModelFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModelFilter.ForeColor = System.Drawing.Color.White;
            this.ModelFilter.Location = new System.Drawing.Point(360, 5);
            this.ModelFilter.Name = "ModelFilter";
            this.ModelFilter.Size = new System.Drawing.Size(100, 21);
            this.ModelFilter.TabIndex = 6;
            this.ModelFilter.Text = "Model";
            // 
            // CardPanel9
            // 
            this.CardPanel9.Location = new System.Drawing.Point(768, 298);
            this.CardPanel9.Name = "CardPanel9";
            this.CardPanel9.Size = new System.Drawing.Size(160, 220);
            this.CardPanel9.TabIndex = 36;
            // 
            // CardPanel4
            // 
            this.CardPanel4.Location = new System.Drawing.Point(768, 46);
            this.CardPanel4.Name = "CardPanel4";
            this.CardPanel4.Size = new System.Drawing.Size(160, 220);
            this.CardPanel4.TabIndex = 32;
            // 
            // CardPanel8
            // 
            this.CardPanel8.Location = new System.Drawing.Point(576, 298);
            this.CardPanel8.Name = "CardPanel8";
            this.CardPanel8.Size = new System.Drawing.Size(160, 220);
            this.CardPanel8.TabIndex = 37;
            // 
            // CardPanel7
            // 
            this.CardPanel7.Location = new System.Drawing.Point(384, 298);
            this.CardPanel7.Name = "CardPanel7";
            this.CardPanel7.Size = new System.Drawing.Size(160, 220);
            this.CardPanel7.TabIndex = 38;
            // 
            // CardPanel3
            // 
            this.CardPanel3.Location = new System.Drawing.Point(576, 46);
            this.CardPanel3.Name = "CardPanel3";
            this.CardPanel3.Size = new System.Drawing.Size(160, 220);
            this.CardPanel3.TabIndex = 33;
            // 
            // CardPanel6
            // 
            this.CardPanel6.Location = new System.Drawing.Point(192, 298);
            this.CardPanel6.Name = "CardPanel6";
            this.CardPanel6.Size = new System.Drawing.Size(160, 220);
            this.CardPanel6.TabIndex = 35;
            // 
            // CardPanel2
            // 
            this.CardPanel2.Location = new System.Drawing.Point(384, 46);
            this.CardPanel2.Name = "CardPanel2";
            this.CardPanel2.Size = new System.Drawing.Size(160, 220);
            this.CardPanel2.TabIndex = 34;
            // 
            // CardPanel1
            // 
            this.CardPanel1.Location = new System.Drawing.Point(192, 46);
            this.CardPanel1.Name = "CardPanel1";
            this.CardPanel1.Size = new System.Drawing.Size(160, 220);
            this.CardPanel1.TabIndex = 30;
            // 
            // CardPanel5
            // 
            this.CardPanel5.Location = new System.Drawing.Point(0, 298);
            this.CardPanel5.Name = "CardPanel5";
            this.CardPanel5.Size = new System.Drawing.Size(160, 220);
            this.CardPanel5.TabIndex = 31;
            // 
            // CardPanel0
            // 
            this.CardPanel0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.CardPanel0.Location = new System.Drawing.Point(0, 46);
            this.CardPanel0.Name = "CardPanel0";
            this.CardPanel0.Size = new System.Drawing.Size(160, 220);
            this.CardPanel0.TabIndex = 29;
            // 
            // PageNumber
            // 
            this.PageNumber.AutoSize = true;
            this.PageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageNumber.ForeColor = System.Drawing.Color.White;
            this.PageNumber.Location = new System.Drawing.Point(430, 535);
            this.PageNumber.Name = "PageNumber";
            this.PageNumber.Size = new System.Drawing.Size(15, 16);
            this.PageNumber.TabIndex = 41;
            this.PageNumber.Text = "1";
            // 
            // NextPageButton
            // 
            this.NextPageButton.FlatAppearance.BorderSize = 0;
            this.NextPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPageButton.Image = global::DesignMyPC.Properties.Resources.right_icon_24px;
            this.NextPageButton.Location = new System.Drawing.Point(496, 528);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(30, 30);
            this.NextPageButton.TabIndex = 40;
            this.NextPageButton.UseVisualStyleBackColor = true;
            // 
            // PreviousPageButton
            // 
            this.PreviousPageButton.FlatAppearance.BorderSize = 0;
            this.PreviousPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousPageButton.Image = global::DesignMyPC.Properties.Resources.left_icon_24px;
            this.PreviousPageButton.Location = new System.Drawing.Point(394, 528);
            this.PreviousPageButton.Name = "PreviousPageButton";
            this.PreviousPageButton.Size = new System.Drawing.Size(30, 30);
            this.PreviousPageButton.TabIndex = 39;
            this.PreviousPageButton.UseVisualStyleBackColor = true;
            // 
            // ComponentsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(928, 560);
            this.Controls.Add(this.PageNumber);
            this.Controls.Add(this.NextPageButton);
            this.Controls.Add(this.PreviousPageButton);
            this.Controls.Add(this.CardPanel9);
            this.Controls.Add(this.CardPanel4);
            this.Controls.Add(this.CardPanel8);
            this.Controls.Add(this.CardPanel7);
            this.Controls.Add(this.CardPanel3);
            this.Controls.Add(this.CardPanel6);
            this.Controls.Add(this.CardPanel2);
            this.Controls.Add(this.CardPanel1);
            this.Controls.Add(this.CardPanel5);
            this.Controls.Add(this.CardPanel0);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Sortby);
            this.Controls.Add(this.ModelFilter);
            this.Controls.Add(this.SeriesFilter);
            this.Controls.Add(this.BrandFilter);
            this.Controls.Add(this.TypeFilter);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComponentsPage";
            this.Text = "ComponentsPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BrandFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SeriesFilter;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ComboBox Sortby;
        private System.Windows.Forms.ComboBox TypeFilter;
        private System.Windows.Forms.ComboBox ModelFilter;
        private System.Windows.Forms.Panel CardPanel9;
        private System.Windows.Forms.Panel CardPanel4;
        private System.Windows.Forms.Panel CardPanel8;
        private System.Windows.Forms.Panel CardPanel7;
        private System.Windows.Forms.Panel CardPanel3;
        private System.Windows.Forms.Panel CardPanel6;
        private System.Windows.Forms.Panel CardPanel2;
        private System.Windows.Forms.Panel CardPanel1;
        private System.Windows.Forms.Panel CardPanel5;
        private System.Windows.Forms.Panel CardPanel0;
        private System.Windows.Forms.Label PageNumber;
        private System.Windows.Forms.Button NextPageButton;
        private System.Windows.Forms.Button PreviousPageButton;
    }
}