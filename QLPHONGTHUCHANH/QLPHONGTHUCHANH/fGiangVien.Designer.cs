namespace QLPHONGTHUCHANH
{
    partial class fGiangVien
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
            this.tabPDKLBS = new System.Windows.Forms.TabPage();
            this.tabPBCSC = new System.Windows.Forms.TabPage();
            this.tabPThongTin = new System.Windows.Forms.TabPage();
            this.lbTieuĐeangKyLBS = new System.Windows.Forms.Label();
            this.txbTenLop = new System.Windows.Forms.TextBox();
            this.cbxCaThucHanh = new System.Windows.Forms.ComboBox();
            this.cbxLoaiPhong = new System.Windows.Forms.ComboBox();
            this.btnDangKyLBS = new QLPHONGTHUCHANH.VBButton();
            this.lbTenLop = new System.Windows.Forms.Label();
            this.lbCaThucHanh = new System.Windows.Forms.Label();
            this.lbLoaiPhong = new System.Windows.Forms.Label();
            this.lbTieuDeThongTinGV = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.txbKhoa = new System.Windows.Forms.TextBox();
            this.txbTenGV = new System.Windows.Forms.TextBox();
            this.txbMaGV = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbKhoa = new System.Windows.Forms.Label();
            this.lbTenGV = new System.Windows.Forms.Label();
            this.lbMaGV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbBCSC = new System.Windows.Forms.GroupBox();
            this.txtBCSC = new System.Windows.Forms.TextBox();
            this.btnGuiBaoCao = new QLPHONGTHUCHANH.VBButton();
            this.tabControl1.SuspendLayout();
            this.tabPDKLBS.SuspendLayout();
            this.tabPBCSC.SuspendLayout();
            this.tabPThongTin.SuspendLayout();
            this.grbBCSC.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPDKLBS);
            this.tabControl1.Controls.Add(this.tabPBCSC);
            this.tabControl1.Controls.Add(this.tabPThongTin);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1373, 750);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPDKLBS
            // 
            this.tabPDKLBS.BackgroundImage = global::QLPHONGTHUCHANH.Properties.Resources.d46a39dac513124d4b022;
            this.tabPDKLBS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPDKLBS.Controls.Add(this.txbTenLop);
            this.tabPDKLBS.Controls.Add(this.cbxCaThucHanh);
            this.tabPDKLBS.Controls.Add(this.cbxLoaiPhong);
            this.tabPDKLBS.Controls.Add(this.btnDangKyLBS);
            this.tabPDKLBS.Controls.Add(this.lbTenLop);
            this.tabPDKLBS.Controls.Add(this.lbCaThucHanh);
            this.tabPDKLBS.Controls.Add(this.lbLoaiPhong);
            this.tabPDKLBS.Controls.Add(this.lbTieuĐeangKyLBS);
            this.tabPDKLBS.Location = new System.Drawing.Point(4, 29);
            this.tabPDKLBS.Name = "tabPDKLBS";
            this.tabPDKLBS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPDKLBS.Size = new System.Drawing.Size(1365, 717);
            this.tabPDKLBS.TabIndex = 0;
            this.tabPDKLBS.Text = "Đăng ký lịch bổ sung";
            this.tabPDKLBS.UseVisualStyleBackColor = true;
            // 
            // tabPBCSC
            // 
            this.tabPBCSC.BackgroundImage = global::QLPHONGTHUCHANH.Properties.Resources.d46a39dac513124d4b022;
            this.tabPBCSC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPBCSC.Controls.Add(this.btnGuiBaoCao);
            this.tabPBCSC.Controls.Add(this.grbBCSC);
            this.tabPBCSC.Controls.Add(this.label1);
            this.tabPBCSC.Location = new System.Drawing.Point(4, 29);
            this.tabPBCSC.Name = "tabPBCSC";
            this.tabPBCSC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPBCSC.Size = new System.Drawing.Size(1365, 717);
            this.tabPBCSC.TabIndex = 1;
            this.tabPBCSC.Text = "Báo cáo sự cố";
            this.tabPBCSC.UseVisualStyleBackColor = true;
            // 
            // tabPThongTin
            // 
            this.tabPThongTin.BackgroundImage = global::QLPHONGTHUCHANH.Properties.Resources.d46a39dac513124d4b022;
            this.tabPThongTin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPThongTin.Controls.Add(this.txbEmail);
            this.tabPThongTin.Controls.Add(this.txbSDT);
            this.tabPThongTin.Controls.Add(this.txbKhoa);
            this.tabPThongTin.Controls.Add(this.txbTenGV);
            this.tabPThongTin.Controls.Add(this.txbMaGV);
            this.tabPThongTin.Controls.Add(this.lbEmail);
            this.tabPThongTin.Controls.Add(this.lbSDT);
            this.tabPThongTin.Controls.Add(this.lbKhoa);
            this.tabPThongTin.Controls.Add(this.lbTenGV);
            this.tabPThongTin.Controls.Add(this.lbMaGV);
            this.tabPThongTin.Controls.Add(this.lbTieuDeThongTinGV);
            this.tabPThongTin.Location = new System.Drawing.Point(4, 29);
            this.tabPThongTin.Name = "tabPThongTin";
            this.tabPThongTin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPThongTin.Size = new System.Drawing.Size(1365, 717);
            this.tabPThongTin.TabIndex = 2;
            this.tabPThongTin.Text = "Thông tin";
            this.tabPThongTin.UseVisualStyleBackColor = true;
            // 
            // lbTieuĐeangKyLBS
            // 
            this.lbTieuĐeangKyLBS.AutoSize = true;
            this.lbTieuĐeangKyLBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuĐeangKyLBS.Location = new System.Drawing.Point(494, 51);
            this.lbTieuĐeangKyLBS.Name = "lbTieuĐeangKyLBS";
            this.lbTieuĐeangKyLBS.Size = new System.Drawing.Size(392, 39);
            this.lbTieuĐeangKyLBS.TabIndex = 1;
            this.lbTieuĐeangKyLBS.Text = "Nhập thông tin đăng ký";
            this.lbTieuĐeangKyLBS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbTenLop
            // 
            this.txbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenLop.Location = new System.Drawing.Point(593, 353);
            this.txbTenLop.Name = "txbTenLop";
            this.txbTenLop.Size = new System.Drawing.Size(328, 31);
            this.txbTenLop.TabIndex = 14;
            this.txbTenLop.TextChanged += new System.EventHandler(this.txbTenLop_TextChanged);
            // 
            // cbxCaThucHanh
            // 
            this.cbxCaThucHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCaThucHanh.FormattingEnabled = true;
            this.cbxCaThucHanh.Location = new System.Drawing.Point(593, 256);
            this.cbxCaThucHanh.Name = "cbxCaThucHanh";
            this.cbxCaThucHanh.Size = new System.Drawing.Size(328, 33);
            this.cbxCaThucHanh.TabIndex = 13;
            // 
            // cbxLoaiPhong
            // 
            this.cbxLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoaiPhong.FormattingEnabled = true;
            this.cbxLoaiPhong.Location = new System.Drawing.Point(593, 162);
            this.cbxLoaiPhong.Name = "cbxLoaiPhong";
            this.cbxLoaiPhong.Size = new System.Drawing.Size(328, 33);
            this.cbxLoaiPhong.TabIndex = 12;
            // 
            // btnDangKyLBS
            // 
            this.btnDangKyLBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnDangKyLBS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnDangKyLBS.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDangKyLBS.BorderRadius = 20;
            this.btnDangKyLBS.BorderSize = 0;
            this.btnDangKyLBS.FlatAppearance.BorderSize = 0;
            this.btnDangKyLBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKyLBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKyLBS.ForeColor = System.Drawing.Color.White;
            this.btnDangKyLBS.Location = new System.Drawing.Point(649, 431);
            this.btnDangKyLBS.Name = "btnDangKyLBS";
            this.btnDangKyLBS.Size = new System.Drawing.Size(209, 40);
            this.btnDangKyLBS.TabIndex = 11;
            this.btnDangKyLBS.Text = "Đăng ký";
            this.btnDangKyLBS.TextColor = System.Drawing.Color.White;
            this.btnDangKyLBS.UseVisualStyleBackColor = false;
            // 
            // lbTenLop
            // 
            this.lbTenLop.AutoSize = true;
            this.lbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLop.Location = new System.Drawing.Point(408, 355);
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.Size = new System.Drawing.Size(96, 29);
            this.lbTenLop.TabIndex = 10;
            this.lbTenLop.Text = "Tên lớp";
            // 
            // lbCaThucHanh
            // 
            this.lbCaThucHanh.AutoSize = true;
            this.lbCaThucHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCaThucHanh.Location = new System.Drawing.Point(408, 260);
            this.lbCaThucHanh.Name = "lbCaThucHanh";
            this.lbCaThucHanh.Size = new System.Drawing.Size(151, 29);
            this.lbCaThucHanh.TabIndex = 9;
            this.lbCaThucHanh.Text = "Ca thực hành";
            // 
            // lbLoaiPhong
            // 
            this.lbLoaiPhong.AutoSize = true;
            this.lbLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiPhong.Location = new System.Drawing.Point(408, 166);
            this.lbLoaiPhong.Name = "lbLoaiPhong";
            this.lbLoaiPhong.Size = new System.Drawing.Size(133, 29);
            this.lbLoaiPhong.TabIndex = 8;
            this.lbLoaiPhong.Text = "Loại phòng";
            // 
            // lbTieuDeThongTinGV
            // 
            this.lbTieuDeThongTinGV.AutoSize = true;
            this.lbTieuDeThongTinGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbTieuDeThongTinGV.Location = new System.Drawing.Point(502, 72);
            this.lbTieuDeThongTinGV.Name = "lbTieuDeThongTinGV";
            this.lbTieuDeThongTinGV.Size = new System.Drawing.Size(346, 39);
            this.lbTieuDeThongTinGV.TabIndex = 1;
            this.lbTieuDeThongTinGV.Text = "Thông tin giảng viên";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txbEmail.Location = new System.Drawing.Point(640, 471);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.ReadOnly = true;
            this.txbEmail.Size = new System.Drawing.Size(327, 31);
            this.txbEmail.TabIndex = 20;
            // 
            // txbSDT
            // 
            this.txbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txbSDT.Location = new System.Drawing.Point(640, 397);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.ReadOnly = true;
            this.txbSDT.Size = new System.Drawing.Size(327, 31);
            this.txbSDT.TabIndex = 19;
            // 
            // txbKhoa
            // 
            this.txbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txbKhoa.Location = new System.Drawing.Point(640, 324);
            this.txbKhoa.Name = "txbKhoa";
            this.txbKhoa.ReadOnly = true;
            this.txbKhoa.Size = new System.Drawing.Size(327, 31);
            this.txbKhoa.TabIndex = 18;
            this.txbKhoa.TextChanged += new System.EventHandler(this.txbKhoa_TextChanged);
            // 
            // txbTenGV
            // 
            this.txbTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txbTenGV.Location = new System.Drawing.Point(640, 247);
            this.txbTenGV.Name = "txbTenGV";
            this.txbTenGV.ReadOnly = true;
            this.txbTenGV.Size = new System.Drawing.Size(327, 31);
            this.txbTenGV.TabIndex = 17;
            this.txbTenGV.TextChanged += new System.EventHandler(this.txbTenGV_TextChanged);
            // 
            // txbMaGV
            // 
            this.txbMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txbMaGV.Location = new System.Drawing.Point(640, 175);
            this.txbMaGV.Name = "txbMaGV";
            this.txbMaGV.ReadOnly = true;
            this.txbMaGV.Size = new System.Drawing.Size(327, 31);
            this.txbMaGV.TabIndex = 16;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbEmail.Location = new System.Drawing.Point(398, 473);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(74, 29);
            this.lbEmail.TabIndex = 15;
            this.lbEmail.Text = "Email";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbSDT.Location = new System.Drawing.Point(398, 399);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(154, 29);
            this.lbSDT.TabIndex = 14;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // lbKhoa
            // 
            this.lbKhoa.AutoSize = true;
            this.lbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbKhoa.Location = new System.Drawing.Point(398, 326);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(75, 29);
            this.lbKhoa.TabIndex = 13;
            this.lbKhoa.Text = "Khoa ";
            // 
            // lbTenGV
            // 
            this.lbTenGV.AutoSize = true;
            this.lbTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbTenGV.Location = new System.Drawing.Point(398, 249);
            this.lbTenGV.Name = "lbTenGV";
            this.lbTenGV.Size = new System.Drawing.Size(172, 29);
            this.lbTenGV.TabIndex = 12;
            this.lbTenGV.Text = "Tên giảng viên";
            // 
            // lbMaGV
            // 
            this.lbMaGV.AutoSize = true;
            this.lbMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbMaGV.Location = new System.Drawing.Point(398, 177);
            this.lbMaGV.Name = "lbMaGV";
            this.lbMaGV.Size = new System.Drawing.Size(162, 29);
            this.lbMaGV.TabIndex = 11;
            this.lbMaGV.Text = "Mã giảng viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(494, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Báo cáo sự cố ";
            // 
            // grbBCSC
            // 
            this.grbBCSC.Controls.Add(this.txtBCSC);
            this.grbBCSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBCSC.Location = new System.Drawing.Point(290, 158);
            this.grbBCSC.Name = "grbBCSC";
            this.grbBCSC.Size = new System.Drawing.Size(746, 366);
            this.grbBCSC.TabIndex = 2;
            this.grbBCSC.TabStop = false;
            this.grbBCSC.Text = "Nhập thông tin chi tiết về sự cố";
            // 
            // txtBCSC
            // 
            this.txtBCSC.AcceptsReturn = true;
            this.txtBCSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBCSC.Location = new System.Drawing.Point(38, 56);
            this.txtBCSC.Multiline = true;
            this.txtBCSC.Name = "txtBCSC";
            this.txtBCSC.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBCSC.Size = new System.Drawing.Size(686, 284);
            this.txtBCSC.TabIndex = 0;
            this.txtBCSC.Text = "Vui lòng nhập thông tin sự cố!";
            // 
            // btnGuiBaoCao
            // 
            this.btnGuiBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnGuiBaoCao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnGuiBaoCao.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuiBaoCao.BorderRadius = 20;
            this.btnGuiBaoCao.BorderSize = 0;
            this.btnGuiBaoCao.FlatAppearance.BorderSize = 0;
            this.btnGuiBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnGuiBaoCao.Location = new System.Drawing.Point(586, 555);
            this.btnGuiBaoCao.Name = "btnGuiBaoCao";
            this.btnGuiBaoCao.Size = new System.Drawing.Size(213, 46);
            this.btnGuiBaoCao.TabIndex = 3;
            this.btnGuiBaoCao.Text = "Gửi";
            this.btnGuiBaoCao.TextColor = System.Drawing.Color.White;
            this.btnGuiBaoCao.UseVisualStyleBackColor = false;
            // 
            // fGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLPHONGTHUCHANH.Properties.Resources.d46a39dac513124d4b022;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tabControl1);
            this.Name = "fGiangVien";
            this.Text = "Màn hình chính giảng viên";
            this.tabControl1.ResumeLayout(false);
            this.tabPDKLBS.ResumeLayout(false);
            this.tabPDKLBS.PerformLayout();
            this.tabPBCSC.ResumeLayout(false);
            this.tabPBCSC.PerformLayout();
            this.tabPThongTin.ResumeLayout(false);
            this.tabPThongTin.PerformLayout();
            this.grbBCSC.ResumeLayout(false);
            this.grbBCSC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPDKLBS;
        private System.Windows.Forms.TabPage tabPBCSC;
        private System.Windows.Forms.TabPage tabPThongTin;
        private System.Windows.Forms.TextBox txbTenLop;
        private System.Windows.Forms.ComboBox cbxCaThucHanh;
        private System.Windows.Forms.ComboBox cbxLoaiPhong;
        private VBButton btnDangKyLBS;
        private System.Windows.Forms.Label lbTenLop;
        private System.Windows.Forms.Label lbCaThucHanh;
        private System.Windows.Forms.Label lbLoaiPhong;
        private System.Windows.Forms.Label lbTieuĐeangKyLBS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.TextBox txbKhoa;
        private System.Windows.Forms.TextBox txbTenGV;
        private System.Windows.Forms.TextBox txbMaGV;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbKhoa;
        private System.Windows.Forms.Label lbTenGV;
        private System.Windows.Forms.Label lbMaGV;
        private System.Windows.Forms.Label lbTieuDeThongTinGV;
        private VBButton btnGuiBaoCao;
        private System.Windows.Forms.GroupBox grbBCSC;
        private System.Windows.Forms.TextBox txtBCSC;
    }
}