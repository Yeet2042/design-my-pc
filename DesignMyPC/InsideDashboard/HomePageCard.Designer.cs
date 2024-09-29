namespace DesignMyPC.InsideDashboard
{
    partial class HomePageCard
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
            this.PcName = new System.Windows.Forms.Label();
            this.CPULabel = new System.Windows.Forms.Label();
            this.EfficientLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PcImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PcImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PcName
            // 
            this.PcName.AutoSize = true;
            this.PcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PcName.ForeColor = System.Drawing.Color.White;
            this.PcName.Location = new System.Drawing.Point(43, 9);
            this.PcName.Name = "PcName";
            this.PcName.Size = new System.Drawing.Size(75, 20);
            this.PcName.TabIndex = 0;
            this.PcName.Text = "PcName";
            // 
            // CPULabel
            // 
            this.CPULabel.AutoSize = true;
            this.CPULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPULabel.ForeColor = System.Drawing.Color.White;
            this.CPULabel.Location = new System.Drawing.Point(43, 140);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(50, 16);
            this.CPULabel.TabIndex = 2;
            this.CPULabel.Text = "label1";
            // 
            // EfficientLabel
            // 
            this.EfficientLabel.AutoSize = true;
            this.EfficientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EfficientLabel.ForeColor = System.Drawing.Color.White;
            this.EfficientLabel.Location = new System.Drawing.Point(43, 166);
            this.EfficientLabel.Name = "EfficientLabel";
            this.EfficientLabel.Size = new System.Drawing.Size(50, 16);
            this.EfficientLabel.TabIndex = 3;
            this.EfficientLabel.Text = "label2";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.Color.White;
            this.PriceLabel.Location = new System.Drawing.Point(44, 192);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(50, 16);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "label3";
            // 
            // PcImage
            // 
            this.PcImage.Location = new System.Drawing.Point(36, 39);
            this.PcImage.Name = "PcImage";
            this.PcImage.Size = new System.Drawing.Size(90, 90);
            this.PcImage.TabIndex = 1;
            this.PcImage.TabStop = false;
            // 
            // HomePageCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(160, 220);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.EfficientLabel);
            this.Controls.Add(this.CPULabel);
            this.Controls.Add(this.PcImage);
            this.Controls.Add(this.PcName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePageCard";
            this.Text = "HomePageCard";
            this.Click += new System.EventHandler(this.HomePageCard_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PcImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PcName;
        private System.Windows.Forms.PictureBox PcImage;
        private System.Windows.Forms.Label CPULabel;
        private System.Windows.Forms.Label EfficientLabel;
        private System.Windows.Forms.Label PriceLabel;
    }
}