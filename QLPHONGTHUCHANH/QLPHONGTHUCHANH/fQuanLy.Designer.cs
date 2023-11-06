namespace QLPHONGTHUCHANH
{
    partial class fQuanLy
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
            this.tc = new System.Windows.Forms.TabControl();
            this.tabQLLop = new System.Windows.Forms.TabPage();
            this.lbDienLop = new System.Windows.Forms.Label();
            this.txbTimKiemLop = new System.Windows.Forms.TextBox();
            this.btnKhoLuuTruLop = new QLPHONGTHUCHANH.VBButton();
            this.btnXoaLop = new QLPHONGTHUCHANH.VBButton();
            this.btnTimKiemLop = new QLPHONGTHUCHANH.VBButton();
            this.btnTaiLenLop = new QLPHONGTHUCHANH.VBButton();
            this.btnLuuTruLop = new QLPHONGTHUCHANH.VBButton();
            this.btnSuaLop = new QLPHONGTHUCHANH.VBButton();
            this.btnThemLop = new QLPHONGTHUCHANH.VBButton();
            this.dtaLop = new System.Windows.Forms.DataGridView();
            this.tabQLPhong = new System.Windows.Forms.TabPage();
            this.tabQLGV = new System.Windows.Forms.TabPage();
            this.tabThongBao = new System.Windows.Forms.TabPage();
            this.tabThongTin = new System.Windows.Forms.TabPage();
            this.tc.SuspendLayout();
            this.tabQLLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaLop)).BeginInit();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tabQLLop);
            this.tc.Controls.Add(this.tabQLPhong);
            this.tc.Controls.Add(this.tabQLGV);
            this.tc.Controls.Add(this.tabThongBao);
            this.tc.Controls.Add(this.tabThongTin);
            this.tc.Location = new System.Drawing.Point(0, 0);
            this.tc.Margin = new System.Windows.Forms.Padding(2);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(1375, 754);
            this.tc.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tc.TabIndex = 0;
            // 
            // tabQLLop
            // 
            this.tabQLLop.Controls.Add(this.lbDienLop);
            this.tabQLLop.Controls.Add(this.txbTimKiemLop);
            this.tabQLLop.Controls.Add(this.btnKhoLuuTruLop);
            this.tabQLLop.Controls.Add(this.btnXoaLop);
            this.tabQLLop.Controls.Add(this.btnTimKiemLop);
            this.tabQLLop.Controls.Add(this.btnTaiLenLop);
            this.tabQLLop.Controls.Add(this.btnLuuTruLop);
            this.tabQLLop.Controls.Add(this.btnSuaLop);
            this.tabQLLop.Controls.Add(this.btnThemLop);
            this.tabQLLop.Controls.Add(this.dtaLop);
            this.tabQLLop.Location = new System.Drawing.Point(4, 22);
            this.tabQLLop.Margin = new System.Windows.Forms.Padding(2);
            this.tabQLLop.Name = "tabQLLop";
            this.tabQLLop.Padding = new System.Windows.Forms.Padding(2);
            this.tabQLLop.Size = new System.Drawing.Size(1367, 728);
            this.tabQLLop.TabIndex = 1;
            this.tabQLLop.Text = "Quản lý lớp";
            this.tabQLLop.UseVisualStyleBackColor = true;
            // 
            // lbDienLop
            // 
            this.lbDienLop.AutoSize = true;
            this.lbDienLop.ForeColor = System.Drawing.Color.Red;
            this.lbDienLop.Location = new System.Drawing.Point(756, 613);
            this.lbDienLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDienLop.Name = "lbDienLop";
            this.lbDienLop.Size = new System.Drawing.Size(107, 13);
            this.lbDienLop.TabIndex = 13;
            this.lbDienLop.Text = "*Vui lòng điền mã lớp";
            // 
            // txbTimKiemLop
            // 
            this.txbTimKiemLop.Location = new System.Drawing.Point(630, 637);
            this.txbTimKiemLop.Margin = new System.Windows.Forms.Padding(2);
            this.txbTimKiemLop.Name = "txbTimKiemLop";
            this.txbTimKiemLop.Size = new System.Drawing.Size(234, 20);
            this.txbTimKiemLop.TabIndex = 12;
            // 
            // btnKhoLuuTruLop
            // 
            this.btnKhoLuuTruLop.BackColor = System.Drawing.Color.Blue;
            this.btnKhoLuuTruLop.BackgroundColor = System.Drawing.Color.Blue;
            this.btnKhoLuuTruLop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnKhoLuuTruLop.BorderRadius = 8;
            this.btnKhoLuuTruLop.BorderSize = 0;
            this.btnKhoLuuTruLop.FlatAppearance.BorderSize = 0;
            this.btnKhoLuuTruLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoLuuTruLop.ForeColor = System.Drawing.Color.White;
            this.btnKhoLuuTruLop.Location = new System.Drawing.Point(230, 689);
            this.btnKhoLuuTruLop.Margin = new System.Windows.Forms.Padding(2);
            this.btnKhoLuuTruLop.Name = "btnKhoLuuTruLop";
            this.btnKhoLuuTruLop.Size = new System.Drawing.Size(112, 32);
            this.btnKhoLuuTruLop.TabIndex = 5;
            this.btnKhoLuuTruLop.Text = "Kho Lưu Trữ";
            this.btnKhoLuuTruLop.TextColor = System.Drawing.Color.White;
            this.btnKhoLuuTruLop.UseVisualStyleBackColor = false;
            this.btnKhoLuuTruLop.Click += new System.EventHandler(this.btnKhoLuuTruLop_Click);
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.BackColor = System.Drawing.Color.Blue;
            this.btnXoaLop.BackgroundColor = System.Drawing.Color.Blue;
            this.btnXoaLop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoaLop.BorderRadius = 8;
            this.btnXoaLop.BorderSize = 0;
            this.btnXoaLop.FlatAppearance.BorderSize = 0;
            this.btnXoaLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLop.ForeColor = System.Drawing.Color.White;
            this.btnXoaLop.Location = new System.Drawing.Point(41, 689);
            this.btnXoaLop.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(112, 32);
            this.btnXoaLop.TabIndex = 6;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.TextColor = System.Drawing.Color.White;
            this.btnXoaLop.UseVisualStyleBackColor = false;
            // 
            // btnTimKiemLop
            // 
            this.btnTimKiemLop.BackColor = System.Drawing.Color.Blue;
            this.btnTimKiemLop.BackgroundColor = System.Drawing.Color.Blue;
            this.btnTimKiemLop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiemLop.BorderRadius = 8;
            this.btnTimKiemLop.BorderSize = 0;
            this.btnTimKiemLop.FlatAppearance.BorderSize = 0;
            this.btnTimKiemLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemLop.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemLop.Location = new System.Drawing.Point(884, 630);
            this.btnTimKiemLop.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemLop.Name = "btnTimKiemLop";
            this.btnTimKiemLop.Size = new System.Drawing.Size(112, 32);
            this.btnTimKiemLop.TabIndex = 7;
            this.btnTimKiemLop.Text = "Tìm Kiếm";
            this.btnTimKiemLop.TextColor = System.Drawing.Color.White;
            this.btnTimKiemLop.UseVisualStyleBackColor = false;
            this.btnTimKiemLop.Click += new System.EventHandler(this.btnTimKiemLop_Click);
            // 
            // btnTaiLenLop
            // 
            this.btnTaiLenLop.BackColor = System.Drawing.Color.Blue;
            this.btnTaiLenLop.BackgroundColor = System.Drawing.Color.Blue;
            this.btnTaiLenLop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTaiLenLop.BorderRadius = 8;
            this.btnTaiLenLop.BorderSize = 0;
            this.btnTaiLenLop.FlatAppearance.BorderSize = 0;
            this.btnTaiLenLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiLenLop.ForeColor = System.Drawing.Color.White;
            this.btnTaiLenLop.Location = new System.Drawing.Point(230, 630);
            this.btnTaiLenLop.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaiLenLop.Name = "btnTaiLenLop";
            this.btnTaiLenLop.Size = new System.Drawing.Size(112, 32);
            this.btnTaiLenLop.TabIndex = 8;
            this.btnTaiLenLop.Text = "Tải Lên";
            this.btnTaiLenLop.TextColor = System.Drawing.Color.White;
            this.btnTaiLenLop.UseVisualStyleBackColor = false;
            // 
            // btnLuuTruLop
            // 
            this.btnLuuTruLop.BackColor = System.Drawing.Color.Blue;
            this.btnLuuTruLop.BackgroundColor = System.Drawing.Color.Blue;
            this.btnLuuTruLop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuuTruLop.BorderRadius = 8;
            this.btnLuuTruLop.BorderSize = 0;
            this.btnLuuTruLop.FlatAppearance.BorderSize = 0;
            this.btnLuuTruLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuTruLop.ForeColor = System.Drawing.Color.White;
            this.btnLuuTruLop.Location = new System.Drawing.Point(230, 573);
            this.btnLuuTruLop.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuTruLop.Name = "btnLuuTruLop";
            this.btnLuuTruLop.Size = new System.Drawing.Size(112, 32);
            this.btnLuuTruLop.TabIndex = 9;
            this.btnLuuTruLop.Text = "Lưu Trữ";
            this.btnLuuTruLop.TextColor = System.Drawing.Color.White;
            this.btnLuuTruLop.UseVisualStyleBackColor = false;
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.BackColor = System.Drawing.Color.Blue;
            this.btnSuaLop.BackgroundColor = System.Drawing.Color.Blue;
            this.btnSuaLop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSuaLop.BorderRadius = 8;
            this.btnSuaLop.BorderSize = 0;
            this.btnSuaLop.FlatAppearance.BorderSize = 0;
            this.btnSuaLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaLop.ForeColor = System.Drawing.Color.White;
            this.btnSuaLop.Location = new System.Drawing.Point(41, 630);
            this.btnSuaLop.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(112, 32);
            this.btnSuaLop.TabIndex = 10;
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.TextColor = System.Drawing.Color.White;
            this.btnSuaLop.UseVisualStyleBackColor = false;
            // 
            // btnThemLop
            // 
            this.btnThemLop.BackColor = System.Drawing.Color.Blue;
            this.btnThemLop.BackgroundColor = System.Drawing.Color.Blue;
            this.btnThemLop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemLop.BorderRadius = 8;
            this.btnThemLop.BorderSize = 0;
            this.btnThemLop.FlatAppearance.BorderSize = 0;
            this.btnThemLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLop.ForeColor = System.Drawing.Color.White;
            this.btnThemLop.Location = new System.Drawing.Point(41, 573);
            this.btnThemLop.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(112, 32);
            this.btnThemLop.TabIndex = 11;
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.TextColor = System.Drawing.Color.White;
            this.btnThemLop.UseVisualStyleBackColor = false;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // dtaLop
            // 
            this.dtaLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaLop.Location = new System.Drawing.Point(-22, 0);
            this.dtaLop.Margin = new System.Windows.Forms.Padding(2);
            this.dtaLop.Name = "dtaLop";
            this.dtaLop.RowHeadersWidth = 51;
            this.dtaLop.RowTemplate.Height = 24;
            this.dtaLop.Size = new System.Drawing.Size(1385, 552);
            this.dtaLop.TabIndex = 4;
            // 
            // tabQLPhong
            // 
            this.tabQLPhong.Location = new System.Drawing.Point(4, 22);
            this.tabQLPhong.Margin = new System.Windows.Forms.Padding(2);
            this.tabQLPhong.Name = "tabQLPhong";
            this.tabQLPhong.Padding = new System.Windows.Forms.Padding(2);
            this.tabQLPhong.Size = new System.Drawing.Size(1057, 763);
            this.tabQLPhong.TabIndex = 2;
            this.tabQLPhong.Text = "Quản lý phòng";
            this.tabQLPhong.UseVisualStyleBackColor = true;
            // 
            // tabQLGV
            // 
            this.tabQLGV.Location = new System.Drawing.Point(4, 22);
            this.tabQLGV.Margin = new System.Windows.Forms.Padding(2);
            this.tabQLGV.Name = "tabQLGV";
            this.tabQLGV.Padding = new System.Windows.Forms.Padding(2);
            this.tabQLGV.Size = new System.Drawing.Size(1057, 763);
            this.tabQLGV.TabIndex = 3;
            this.tabQLGV.Text = "Quản lý giảng viên";
            this.tabQLGV.UseVisualStyleBackColor = true;
            // 
            // tabThongBao
            // 
            this.tabThongBao.Location = new System.Drawing.Point(4, 22);
            this.tabThongBao.Margin = new System.Windows.Forms.Padding(2);
            this.tabThongBao.Name = "tabThongBao";
            this.tabThongBao.Padding = new System.Windows.Forms.Padding(2);
            this.tabThongBao.Size = new System.Drawing.Size(1057, 763);
            this.tabThongBao.TabIndex = 4;
            this.tabThongBao.Text = "Thông báo";
            this.tabThongBao.UseVisualStyleBackColor = true;
            // 
            // tabThongTin
            // 
            this.tabThongTin.Location = new System.Drawing.Point(4, 22);
            this.tabThongTin.Margin = new System.Windows.Forms.Padding(2);
            this.tabThongTin.Name = "tabThongTin";
            this.tabThongTin.Padding = new System.Windows.Forms.Padding(2);
            this.tabThongTin.Size = new System.Drawing.Size(1057, 763);
            this.tabThongTin.TabIndex = 5;
            this.tabThongTin.Text = "Thông tin";
            this.tabThongTin.UseVisualStyleBackColor = true;
            // 
            // fQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tc);
            this.Name = "fQuanLy";
            this.Text = "Hệ thống quản lý phòng thực hành tin ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tc.ResumeLayout(false);
            this.tabQLLop.ResumeLayout(false);
            this.tabQLLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tabQLLop;
        private System.Windows.Forms.TabPage tabQLPhong;
        private System.Windows.Forms.TabPage tabQLGV;
        private System.Windows.Forms.TabPage tabThongBao;
        private System.Windows.Forms.TabPage tabThongTin;
        private System.Windows.Forms.Label lbDienLop;
        private System.Windows.Forms.TextBox txbTimKiemLop;
        private VBButton btnKhoLuuTruLop;
        private VBButton btnXoaLop;
        private VBButton btnTimKiemLop;
        private VBButton btnTaiLenLop;
        private VBButton btnLuuTruLop;
        private VBButton btnSuaLop;
        private VBButton btnThemLop;
        private System.Windows.Forms.DataGridView dtaLop;
    }
}