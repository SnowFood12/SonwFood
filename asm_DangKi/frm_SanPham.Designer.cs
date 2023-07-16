namespace asm_DangKi
{
    partial class frm_SanPham
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_tinhTrang = new System.Windows.Forms.Label();
            this.cbo_tinhTrang = new System.Windows.Forms.ComboBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.lbl_dsSanPham = new System.Windows.Forms.Label();
            this.lstv_sanPham = new System.Windows.Forms.ListView();
            this.clo_ma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clo_tenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clo_soLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clo_gia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clo_ngayNhapKho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clo_ngaySanXuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clo_hanSuDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clo_tinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clo_ghiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_reset = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1122, 617);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_reset);
            this.tabPage1.Controls.Add(this.lbl_tinhTrang);
            this.tabPage1.Controls.Add(this.cbo_tinhTrang);
            this.tabPage1.Controls.Add(this.btn_tim);
            this.tabPage1.Controls.Add(this.lbl_dsSanPham);
            this.tabPage1.Controls.Add(this.lstv_sanPham);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1114, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách sản phẩm";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lbl_tinhTrang
            // 
            this.lbl_tinhTrang.AutoSize = true;
            this.lbl_tinhTrang.Location = new System.Drawing.Point(542, 130);
            this.lbl_tinhTrang.Name = "lbl_tinhTrang";
            this.lbl_tinhTrang.Size = new System.Drawing.Size(114, 26);
            this.lbl_tinhTrang.TabIndex = 4;
            this.lbl_tinhTrang.Text = "Tình trạng:";
            // 
            // cbo_tinhTrang
            // 
            this.cbo_tinhTrang.FormattingEnabled = true;
            this.cbo_tinhTrang.Location = new System.Drawing.Point(681, 127);
            this.cbo_tinhTrang.Name = "cbo_tinhTrang";
            this.cbo_tinhTrang.Size = new System.Drawing.Size(139, 34);
            this.cbo_tinhTrang.TabIndex = 3;
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(858, 124);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(110, 33);
            this.btn_tim.TabIndex = 2;
            this.btn_tim.Text = "Tìm kiếm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // lbl_dsSanPham
            // 
            this.lbl_dsSanPham.AutoSize = true;
            this.lbl_dsSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dsSanPham.Location = new System.Drawing.Point(459, 23);
            this.lbl_dsSanPham.Name = "lbl_dsSanPham";
            this.lbl_dsSanPham.Size = new System.Drawing.Size(172, 39);
            this.lbl_dsSanPham.TabIndex = 1;
            this.lbl_dsSanPham.Text = "Sản phẩm";
            // 
            // lstv_sanPham
            // 
            this.lstv_sanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clo_ma,
            this.clo_tenSP,
            this.clo_soLuong,
            this.clo_gia,
            this.clo_ngayNhapKho,
            this.clo_ngaySanXuat,
            this.clo_hanSuDung,
            this.clo_tinhTrang,
            this.clo_ghiChu});
            this.lstv_sanPham.GridLines = true;
            this.lstv_sanPham.HideSelection = false;
            this.lstv_sanPham.Location = new System.Drawing.Point(8, 188);
            this.lstv_sanPham.Name = "lstv_sanPham";
            this.lstv_sanPham.Size = new System.Drawing.Size(1098, 382);
            this.lstv_sanPham.TabIndex = 0;
            this.lstv_sanPham.UseCompatibleStateImageBehavior = false;
            this.lstv_sanPham.View = System.Windows.Forms.View.Details;
            // 
            // clo_ma
            // 
            this.clo_ma.Text = "Mã SP";
            this.clo_ma.Width = 70;
            // 
            // clo_tenSP
            // 
            this.clo_tenSP.Text = "Tên sản phẩm";
            this.clo_tenSP.Width = 200;
            // 
            // clo_soLuong
            // 
            this.clo_soLuong.Text = "Số lượng";
            this.clo_soLuong.Width = 100;
            // 
            // clo_gia
            // 
            this.clo_gia.Text = "Giá";
            this.clo_gia.Width = 70;
            // 
            // clo_ngayNhapKho
            // 
            this.clo_ngayNhapKho.Text = "Ngày nhập kho";
            this.clo_ngayNhapKho.Width = 130;
            // 
            // clo_ngaySanXuat
            // 
            this.clo_ngaySanXuat.Text = "Ngày sản xuất";
            this.clo_ngaySanXuat.Width = 130;
            // 
            // clo_hanSuDung
            // 
            this.clo_hanSuDung.Text = "Hạn sử dụng";
            this.clo_hanSuDung.Width = 130;
            // 
            // clo_tinhTrang
            // 
            this.clo_tinhTrang.Text = "Tình trạng";
            this.clo_tinhTrang.Width = 110;
            // 
            // clo_ghiChu
            // 
            this.clo_ghiChu.Text = "Ghi chú";
            this.clo_ghiChu.Width = 200;
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1114, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thêm sản phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1114, 584);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sửa sản phẩm";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1114, 584);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Xoá sản phẩm";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(1012, 124);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(83, 33);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 617);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_SanPham";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_SanPham_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView lstv_sanPham;
        private System.Windows.Forms.Label lbl_tinhTrang;
        private System.Windows.Forms.ComboBox cbo_tinhTrang;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Label lbl_dsSanPham;
        private System.Windows.Forms.ColumnHeader clo_ma;
        private System.Windows.Forms.ColumnHeader clo_tenSP;
        private System.Windows.Forms.ColumnHeader clo_soLuong;
        private System.Windows.Forms.ColumnHeader clo_gia;
        private System.Windows.Forms.ColumnHeader clo_ngayNhapKho;
        private System.Windows.Forms.ColumnHeader clo_hanSuDung;
        private System.Windows.Forms.ColumnHeader clo_tinhTrang;
        private System.Windows.Forms.ColumnHeader clo_ghiChu;
        private System.Windows.Forms.ColumnHeader clo_ngaySanXuat;
        private System.Windows.Forms.Button btn_reset;
    }
}