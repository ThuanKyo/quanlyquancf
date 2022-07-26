namespace QuanLyCafe
{
    partial class frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbquyen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MNT_BANAN = new System.Windows.Forms.ToolStripMenuItem();
            this.MNT_QUANLY = new System.Windows.Forms.ToolStripMenuItem();
            this.MNT_DANGXUAT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNT_BANAN,
            this.MNT_QUANLY,
            this.MNT_DANGXUAT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1239, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbquyen
            // 
            this.lbquyen.AutoSize = true;
            this.lbquyen.BackColor = System.Drawing.Color.Transparent;
            this.lbquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbquyen.ForeColor = System.Drawing.Color.Red;
            this.lbquyen.Location = new System.Drawing.Point(1379, 5);
            this.lbquyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbquyen.Name = "lbquyen";
            this.lbquyen.Size = new System.Drawing.Size(74, 20);
            this.lbquyen.TabIndex = 3;
            this.lbquyen.Text = "Quyền :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyCafe.Properties.Resources.cong_cu_quan_ly_quan_ca_phe;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1239, 714);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MNT_BANAN
            // 
            this.MNT_BANAN.Image = global::QuanLyCafe.Properties.Resources.Archigraphs_Oldies_Coffee_Cup;
            this.MNT_BANAN.Name = "MNT_BANAN";
            this.MNT_BANAN.Size = new System.Drawing.Size(114, 27);
            this.MNT_BANAN.Text = "Đặt món";
            this.MNT_BANAN.Click += new System.EventHandler(this.MNT_BANAN_Click);
            // 
            // MNT_QUANLY
            // 
            this.MNT_QUANLY.Image = global::QuanLyCafe.Properties.Resources.Hopstarter_Soft_Scraps_Text_Edit;
            this.MNT_QUANLY.Name = "MNT_QUANLY";
            this.MNT_QUANLY.Size = new System.Drawing.Size(105, 27);
            this.MNT_QUANLY.Text = "Quản lý";
            this.MNT_QUANLY.Click += new System.EventHandler(this.MNT_QUANLY_Click);
            // 
            // MNT_DANGXUAT
            // 
            this.MNT_DANGXUAT.Image = global::QuanLyCafe.Properties.Resources.Visualpharm_Must_Have_Log_Out;
            this.MNT_DANGXUAT.Name = "MNT_DANGXUAT";
            this.MNT_DANGXUAT.Size = new System.Drawing.Size(127, 27);
            this.MNT_DANGXUAT.Text = "Đăng xuất";
            this.MNT_DANGXUAT.Click += new System.EventHandler(this.MNT_DANGXUAT_Click);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1239, 745);
            this.Controls.Add(this.lbquyen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MNT_BANAN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbquyen;
        private System.Windows.Forms.ToolStripMenuItem MNT_DANGXUAT;
        private System.Windows.Forms.ToolStripMenuItem MNT_QUANLY;
    }
}