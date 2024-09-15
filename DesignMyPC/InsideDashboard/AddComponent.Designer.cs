namespace DesignMyPC.InsideDashboard
{
    partial class AddComponent
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
            this.DesignButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DesignButton
            // 
            this.DesignButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.DesignButton.FlatAppearance.BorderSize = 0;
            this.DesignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DesignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesignButton.ForeColor = System.Drawing.Color.White;
            this.DesignButton.Location = new System.Drawing.Point(0, 0);
            this.DesignButton.Name = "DesignButton";
            this.DesignButton.Size = new System.Drawing.Size(160, 220);
            this.DesignButton.TabIndex = 2;
            this.DesignButton.Text = "กดเพื่อเพิ่ม";
            this.DesignButton.UseVisualStyleBackColor = false;
            // 
            // AddComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(160, 220);
            this.Controls.Add(this.DesignButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddComponent";
            this.Text = "AddComponent";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DesignButton;
    }
}