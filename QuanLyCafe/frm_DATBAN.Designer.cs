namespace QuanLyCafe
{
    partial class frm_DATBAN
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.grb_thucdon = new System.Windows.Forms.GroupBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.btn_inhoadon = new System.Windows.Forms.Button();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.grb_danhsachmon = new System.Windows.Forms.GroupBox();
            this.txt_TotalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lsvBILL = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_gopban = new System.Windows.Forms.Button();
            this.btn_chuyenban = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nbd_soluong = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_tenmon = new System.Windows.Forms.ComboBox();
            this.cb_danhmuc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grb_thucdon.SuspendLayout();
            this.grb_danhsachmon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbd_soluong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flpTable);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(1116, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 880);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH BÀN";
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(7, 28);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(862, 846);
            this.flpTable.TabIndex = 0;
            // 
            // grb_thucdon
            // 
            this.grb_thucdon.Controls.Add(this.txt_dongia);
            this.grb_thucdon.Controls.Add(this.btn_inhoadon);
            this.grb_thucdon.Controls.Add(this.btn_thanhtoan);
            this.grb_thucdon.Controls.Add(this.grb_danhsachmon);
            this.grb_thucdon.Controls.Add(this.btn_gopban);
            this.grb_thucdon.Controls.Add(this.btn_chuyenban);
            this.grb_thucdon.Controls.Add(this.btn_xoa);
            this.grb_thucdon.Controls.Add(this.btn_them);
            this.grb_thucdon.Controls.Add(this.label4);
            this.grb_thucdon.Controls.Add(this.nbd_soluong);
            this.grb_thucdon.Controls.Add(this.label3);
            this.grb_thucdon.Controls.Add(this.cb_tenmon);
            this.grb_thucdon.Controls.Add(this.cb_danhmuc);
            this.grb_thucdon.Controls.Add(this.label2);
            this.grb_thucdon.Controls.Add(this.label1);
            this.grb_thucdon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_thucdon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grb_thucdon.Location = new System.Drawing.Point(12, 12);
            this.grb_thucdon.Name = "grb_thucdon";
            this.grb_thucdon.Size = new System.Drawing.Size(1098, 880);
            this.grb_thucdon.TabIndex = 1;
            this.grb_thucdon.TabStop = false;
            this.grb_thucdon.Text = "THỰC ĐƠN";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Enabled = false;
            this.txt_dongia.Location = new System.Drawing.Point(549, 156);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(281, 28);
            this.txt_dongia.TabIndex = 15;
            // 
            // btn_inhoadon
            // 
            this.btn_inhoadon.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_inhoadon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_inhoadon.Image = global::QuanLyCafe.Properties.Resources.Aha_Soft_Universal_Shop_Print;
            this.btn_inhoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inhoadon.Location = new System.Drawing.Point(845, 414);
            this.btn_inhoadon.Name = "btn_inhoadon";
            this.btn_inhoadon.Size = new System.Drawing.Size(184, 72);
            this.btn_inhoadon.TabIndex = 14;
            this.btn_inhoadon.Text = "In hóa đơn";
            this.btn_inhoadon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inhoadon.UseVisualStyleBackColor = false;
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_thanhtoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thanhtoan.Image = global::QuanLyCafe.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Money;
            this.btn_thanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thanhtoan.Location = new System.Drawing.Point(845, 318);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(184, 72);
            this.btn_thanhtoan.TabIndex = 13;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thanhtoan.UseVisualStyleBackColor = false;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // grb_danhsachmon
            // 
            this.grb_danhsachmon.Controls.Add(this.txt_TotalPrice);
            this.grb_danhsachmon.Controls.Add(this.label5);
            this.grb_danhsachmon.Controls.Add(this.lsvBILL);
            this.grb_danhsachmon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grb_danhsachmon.Location = new System.Drawing.Point(25, 229);
            this.grb_danhsachmon.Name = "grb_danhsachmon";
            this.grb_danhsachmon.Size = new System.Drawing.Size(805, 624);
            this.grb_danhsachmon.TabIndex = 12;
            this.grb_danhsachmon.TabStop = false;
            this.grb_danhsachmon.Text = "Danh sách món";
            // 
            // txt_TotalPrice
            // 
            this.txt_TotalPrice.ForeColor = System.Drawing.Color.Red;
            this.txt_TotalPrice.Location = new System.Drawing.Point(554, 571);
            this.txt_TotalPrice.Multiline = true;
            this.txt_TotalPrice.Name = "txt_TotalPrice";
            this.txt_TotalPrice.ReadOnly = true;
            this.txt_TotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_TotalPrice.Size = new System.Drawing.Size(245, 39);
            this.txt_TotalPrice.TabIndex = 2;
            this.txt_TotalPrice.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 581);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng tiền";
            // 
            // lsvBILL
            // 
            this.lsvBILL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBILL.HideSelection = false;
            this.lsvBILL.Location = new System.Drawing.Point(6, 28);
            this.lsvBILL.Name = "lsvBILL";
            this.lsvBILL.Size = new System.Drawing.Size(793, 537);
            this.lsvBILL.TabIndex = 0;
            this.lsvBILL.UseCompatibleStateImageBehavior = false;
            this.lsvBILL.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 233;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 207;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 205;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 162;
            // 
            // btn_gopban
            // 
            this.btn_gopban.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_gopban.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_gopban.Image = global::QuanLyCafe.Properties.Resources.dining_table;
            this.btn_gopban.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gopban.Location = new System.Drawing.Point(845, 229);
            this.btn_gopban.Name = "btn_gopban";
            this.btn_gopban.Size = new System.Drawing.Size(184, 72);
            this.btn_gopban.TabIndex = 11;
            this.btn_gopban.Text = "Gộp bàn";
            this.btn_gopban.UseVisualStyleBackColor = false;
            // 
            // btn_chuyenban
            // 
            this.btn_chuyenban.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_chuyenban.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_chuyenban.Image = global::QuanLyCafe.Properties.Resources.Hopstarter_Soft_Scraps_Button_Refresh;
            this.btn_chuyenban.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_chuyenban.Location = new System.Drawing.Point(845, 133);
            this.btn_chuyenban.Name = "btn_chuyenban";
            this.btn_chuyenban.Size = new System.Drawing.Size(184, 79);
            this.btn_chuyenban.TabIndex = 10;
            this.btn_chuyenban.Text = "Chuyển bàn";
            this.btn_chuyenban.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_chuyenban.UseVisualStyleBackColor = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoa.Image = global::QuanLyCafe.Properties.Resources.Deleteico1;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(966, 45);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(115, 72);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_them.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_them.Image = global::QuanLyCafe.Properties.Resources.ICOADD;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(845, 45);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(115, 72);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(431, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn giá";
            // 
            // nbd_soluong
            // 
            this.nbd_soluong.Location = new System.Drawing.Point(132, 157);
            this.nbd_soluong.Name = "nbd_soluong";
            this.nbd_soluong.Size = new System.Drawing.Size(120, 28);
            this.nbd_soluong.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(21, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // cb_tenmon
            // 
            this.cb_tenmon.FormattingEnabled = true;
            this.cb_tenmon.Location = new System.Drawing.Point(549, 45);
            this.cb_tenmon.Name = "cb_tenmon";
            this.cb_tenmon.Size = new System.Drawing.Size(281, 30);
            this.cb_tenmon.TabIndex = 3;
            // 
            // cb_danhmuc
            // 
            this.cb_danhmuc.FormattingEnabled = true;
            this.cb_danhmuc.Location = new System.Drawing.Point(132, 45);
            this.cb_danhmuc.Name = "cb_danhmuc";
            this.cb_danhmuc.Size = new System.Drawing.Size(282, 30);
            this.cb_danhmuc.TabIndex = 2;
            this.cb_danhmuc.SelectedIndexChanged += new System.EventHandler(this.cb_danhmuc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(431, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên món";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục";
            // 
            // frm_DATBAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1924, 898);
            this.Controls.Add(this.grb_thucdon);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_DATBAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÀN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.grb_thucdon.ResumeLayout(false);
            this.grb_thucdon.PerformLayout();
            this.grb_danhsachmon.ResumeLayout(false);
            this.grb_danhsachmon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbd_soluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grb_thucdon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nbd_soluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_tenmon;
        private System.Windows.Forms.ComboBox cb_danhmuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_chuyenban;
        private System.Windows.Forms.Button btn_gopban;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.GroupBox grb_danhsachmon;
        private System.Windows.Forms.Button btn_inhoadon;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ListView lsvBILL;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txt_TotalPrice;
        private System.Windows.Forms.Label label5;
    }
}
