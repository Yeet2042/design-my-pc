namespace DesignMyPC
{
    partial class Dashboard
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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.DashboardLabel = new System.Windows.Forms.Label();
            this.DashboardContainer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PCsButton = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.ComponentsButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(80)))), ((int)(((byte)(70)))));
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(32, 644);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(270, 44);
            this.LogoutButton.TabIndex = 18;
            this.LogoutButton.Text = "ออกจากระบบ";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.SettingButton.FlatAppearance.BorderSize = 0;
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingButton.ForeColor = System.Drawing.Color.White;
            this.SettingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingButton.Location = new System.Drawing.Point(32, 594);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(270, 44);
            this.SettingButton.TabIndex = 19;
            this.SettingButton.Text = "ตั้งค่า";
            this.SettingButton.UseVisualStyleBackColor = false;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.AutoSize = true;
            this.DashboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardLabel.ForeColor = System.Drawing.Color.White;
            this.DashboardLabel.Location = new System.Drawing.Point(313, 75);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(89, 37);
            this.DashboardLabel.TabIndex = 20;
            this.DashboardLabel.Text = "label";
            // 
            // DashboardContainer
            // 
            this.DashboardContainer.Location = new System.Drawing.Point(320, 128);
            this.DashboardContainer.Name = "DashboardContainer";
            this.DashboardContainer.Size = new System.Drawing.Size(928, 560);
            this.DashboardContainer.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1083, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "สวัสดี,";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(1156, 81);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(69, 25);
            this.NameLabel.TabIndex = 24;
            this.NameLabel.Text = "name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DesignMyPC.Properties.Resources.avatar_icon_48px;
            this.pictureBox1.Location = new System.Drawing.Point(1022, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // PCsButton
            // 
            this.PCsButton.FlatAppearance.BorderSize = 0;
            this.PCsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PCsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCsButton.ForeColor = System.Drawing.Color.White;
            this.PCsButton.Image = global::DesignMyPC.Properties.Resources.pc_icon_24px;
            this.PCsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PCsButton.Location = new System.Drawing.Point(32, 258);
            this.PCsButton.Name = "PCsButton";
            this.PCsButton.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.PCsButton.Size = new System.Drawing.Size(270, 57);
            this.PCsButton.TabIndex = 17;
            this.PCsButton.Text = "     คอมพิวตอร์ทั้งหมด";
            this.PCsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PCsButton.UseVisualStyleBackColor = true;
            this.PCsButton.Click += new System.EventHandler(this.PCsButton_Click);
            // 
            // UsersButton
            // 
            this.UsersButton.FlatAppearance.BorderSize = 0;
            this.UsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersButton.ForeColor = System.Drawing.Color.White;
            this.UsersButton.Image = global::DesignMyPC.Properties.Resources.users_icon_24px;
            this.UsersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsersButton.Location = new System.Drawing.Point(32, 195);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.UsersButton.Size = new System.Drawing.Size(270, 57);
            this.UsersButton.TabIndex = 16;
            this.UsersButton.Text = "     ผู้ใช้ทั้งหมด";
            this.UsersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // ComponentsButton
            // 
            this.ComponentsButton.FlatAppearance.BorderSize = 0;
            this.ComponentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComponentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComponentsButton.ForeColor = System.Drawing.Color.White;
            this.ComponentsButton.Image = global::DesignMyPC.Properties.Resources.cpu_icon_24px;
            this.ComponentsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComponentsButton.Location = new System.Drawing.Point(32, 132);
            this.ComponentsButton.Name = "ComponentsButton";
            this.ComponentsButton.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ComponentsButton.Size = new System.Drawing.Size(270, 57);
            this.ComponentsButton.TabIndex = 15;
            this.ComponentsButton.Text = "     ชิ้นส่วนทั้งหมด";
            this.ComponentsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComponentsButton.UseVisualStyleBackColor = true;
            this.ComponentsButton.Click += new System.EventHandler(this.ComponentsButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = global::DesignMyPC.Properties.Resources.home_icon_24px;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(32, 69);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.HomeButton.Size = new System.Drawing.Size(270, 57);
            this.HomeButton.TabIndex = 14;
            this.HomeButton.Text = "     หน้าหลัก";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Image = global::DesignMyPC.Properties.Resources.minimize_icon_24px;
            this.MinimizeButton.Location = new System.Drawing.Point(1189, 18);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.TabIndex = 13;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = global::DesignMyPC.Properties.Resources.close_icon_24px;
            this.CloseButton.Location = new System.Drawing.Point(1232, 18);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::DesignMyPC.Properties.Resources.logo_24px;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "    DesignMyPC";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DashboardContainer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DashboardLabel);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.PCsButton);
            this.Controls.Add(this.UsersButton);
            this.Controls.Add(this.ComponentsButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button ComponentsButton;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button PCsButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Label DashboardLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel DashboardContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NameLabel;
    }
}