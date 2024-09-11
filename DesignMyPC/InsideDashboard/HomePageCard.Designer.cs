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
            this.SuspendLayout();
            // 
            // PcName
            // 
            this.PcName.AutoSize = true;
            this.PcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PcName.ForeColor = System.Drawing.Color.White;
            this.PcName.Location = new System.Drawing.Point(42, 9);
            this.PcName.Name = "PcName";
            this.PcName.Size = new System.Drawing.Size(75, 20);
            this.PcName.TabIndex = 0;
            this.PcName.Text = "PcName";
            // 
            // HomePageCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(160, 250);
            this.Controls.Add(this.PcName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePageCard";
            this.Text = "HomePageCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PcName;
    }
}