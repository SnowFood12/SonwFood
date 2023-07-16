namespace asm_DangKi
{
    partial class frm_DangKi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.lab_Thoat = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_XacNhanMK = new System.Windows.Forms.TextBox();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.chk_HienThiMK = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_DangKy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pictureBox1.Location = new System.Drawing.Point(656, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 563);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(624, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 89);
            this.label1.TabIndex = 1;
            this.label1.Text = "SnowFood";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(592, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "welcome to SnowFood !!!";
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DangNhap.Location = new System.Drawing.Point(739, 363);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(172, 50);
            this.btn_DangNhap.TabIndex = 3;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // lab_Thoat
            // 
            this.lab_Thoat.AutoSize = true;
            this.lab_Thoat.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lab_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Thoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_Thoat.Location = new System.Drawing.Point(958, 9);
            this.lab_Thoat.Name = "lab_Thoat";
            this.lab_Thoat.Size = new System.Drawing.Size(35, 33);
            this.lab_Thoat.TabIndex = 4;
            this.lab_Thoat.Text = "X";
            this.lab_Thoat.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lab_Thoat.Click += new System.EventHandler(this.lab_Thoat_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(106, 336);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(56, 20);
            this.lbl_email.TabIndex = 34;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten.Location = new System.Drawing.Point(106, 286);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(86, 20);
            this.lbl_ten.TabIndex = 33;
            this.lbl_ten.Text = "Họ và tên:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_email.Location = new System.Drawing.Point(294, 333);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(226, 26);
            this.txt_email.TabIndex = 31;
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_ten.Location = new System.Drawing.Point(294, 283);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(226, 26);
            this.txt_ten.TabIndex = 32;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SDT.Location = new System.Drawing.Point(294, 236);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(226, 26);
            this.txt_SDT.TabIndex = 30;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MatKhau.Location = new System.Drawing.Point(294, 136);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(226, 26);
            this.txt_MatKhau.TabIndex = 28;
            // 
            // txt_XacNhanMK
            // 
            this.txt_XacNhanMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_XacNhanMK.Location = new System.Drawing.Point(294, 186);
            this.txt_XacNhanMK.Name = "txt_XacNhanMK";
            this.txt_XacNhanMK.Size = new System.Drawing.Size(226, 26);
            this.txt_XacNhanMK.TabIndex = 29;
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenDangNhap.Location = new System.Drawing.Point(294, 89);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(226, 26);
            this.txt_TenDangNhap.TabIndex = 27;
            // 
            // chk_HienThiMK
            // 
            this.chk_HienThiMK.AutoSize = true;
            this.chk_HienThiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_HienThiMK.Location = new System.Drawing.Point(82, 426);
            this.chk_HienThiMK.Name = "chk_HienThiMK";
            this.chk_HienThiMK.Size = new System.Drawing.Size(204, 30);
            this.chk_HienThiMK.TabIndex = 26;
            this.chk_HienThiMK.Text = "Hiển thị mật khẩu";
            this.chk_HienThiMK.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(106, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Xác nhận mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(183, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 39);
            this.label6.TabIndex = 23;
            this.label6.Text = "Đăng kí tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tên đăng nhập";
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DangKy.Location = new System.Drawing.Point(367, 425);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(153, 36);
            this.btn_DangKy.TabIndex = 35;
            this.btn_DangKy.Text = "Đăng ký";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click_1);
            // 
            // frm_DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 519);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_ten);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_XacNhanMK);
            this.Controls.Add(this.txt_TenDangNhap);
            this.Controls.Add(this.chk_HienThiMK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DangKi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_DangKi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Label lab_Thoat;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_ten;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_XacNhanMK;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.CheckBox chk_HienThiMK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_DangKy;
    }
}

