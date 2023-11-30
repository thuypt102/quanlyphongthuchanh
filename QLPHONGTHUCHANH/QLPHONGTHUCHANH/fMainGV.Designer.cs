namespace QLPHONGTHUCHANH
{
    partial class fMainGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainGV));
            this.mnsQuanLy = new System.Windows.Forms.MenuStrip();
            this.mniQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbNamHoc = new System.Windows.Forms.ComboBox();
            this.btnDoiPhong = new QLPHONGTHUCHANH.VBButton();
            this.btnTimKiem = new QLPHONGTHUCHANH.VBButton();
            this.btnXuatLich = new QLPHONGTHUCHANH.VBButton();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.lbLoai = new System.Windows.Forms.Label();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgLich = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCaThucHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.mnsQuanLy.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLich)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsQuanLy
            // 
            this.mnsQuanLy.BackColor = System.Drawing.Color.Transparent;
            this.mnsQuanLy.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsQuanLy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniQuanLy,
            this.mniThongTin,
            this.mniDangXuat});
            this.mnsQuanLy.Location = new System.Drawing.Point(0, 0);
            this.mnsQuanLy.Name = "mnsQuanLy";
            this.mnsQuanLy.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnsQuanLy.Size = new System.Drawing.Size(1370, 29);
            this.mnsQuanLy.TabIndex = 0;
            this.mnsQuanLy.Text = "menuStrip1";
            // 
            // mniQuanLy
            // 
            this.mniQuanLy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mniQuanLy.Name = "mniQuanLy";
            this.mniQuanLy.Size = new System.Drawing.Size(96, 25);
            this.mniQuanLy.Text = "Chức năng";
            this.mniQuanLy.Click += new System.EventHandler(this.mniQuanLy_Click);
            // 
            // mniThongTin
            // 
            this.mniThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mniThongTin.Name = "mniThongTin";
            this.mniThongTin.Size = new System.Drawing.Size(146, 25);
            this.mniThongTin.Text = "Thông tin cá nhân";
            this.mniThongTin.Click += new System.EventHandler(this.mniThongTin_Click);
            // 
            // mniDangXuat
            // 
            this.mniDangXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mniDangXuat.Name = "mniDangXuat";
            this.mniDangXuat.Size = new System.Drawing.Size(92, 25);
            this.mniDangXuat.Text = "Đăng xuất";
            this.mniDangXuat.Click += new System.EventHandler(this.mniDangXuat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cmbNamHoc);
            this.panel1.Controls.Add(this.btnDoiPhong);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnXuatLich);
            this.panel1.Controls.Add(this.cmbLoai);
            this.panel1.Controls.Add(this.lbLoai);
            this.panel1.Controls.Add(this.txbTimKiem);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 89);
            this.panel1.TabIndex = 1;
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.Location = new System.Drawing.Point(338, 28);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(166, 28);
            this.cmbNamHoc.TabIndex = 10;
            // 
            // btnDoiPhong
            // 
            this.btnDoiPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnDoiPhong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnDoiPhong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDoiPhong.BorderRadius = 8;
            this.btnDoiPhong.BorderSize = 0;
            this.btnDoiPhong.FlatAppearance.BorderSize = 0;
            this.btnDoiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiPhong.ForeColor = System.Drawing.Color.White;
            this.btnDoiPhong.Location = new System.Drawing.Point(1173, 23);
            this.btnDoiPhong.Name = "btnDoiPhong";
            this.btnDoiPhong.Size = new System.Drawing.Size(129, 38);
            this.btnDoiPhong.TabIndex = 9;
            this.btnDoiPhong.Text = "Đổi phòng máy";
            this.btnDoiPhong.TextColor = System.Drawing.Color.White;
            this.btnDoiPhong.UseVisualStyleBackColor = false;
            this.btnDoiPhong.Click += new System.EventHandler(this.btnDoiPhong_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiem.BorderRadius = 8;
            this.btnTimKiem.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(836, 23);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 38);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXuatLich
            // 
            this.btnXuatLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnXuatLich.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnXuatLich.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXuatLich.BorderRadius = 8;
            this.btnXuatLich.BorderSize = 0;
            this.btnXuatLich.FlatAppearance.BorderSize = 0;
            this.btnXuatLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatLich.ForeColor = System.Drawing.Color.White;
            this.btnXuatLich.Location = new System.Drawing.Point(1005, 23);
            this.btnXuatLich.Name = "btnXuatLich";
            this.btnXuatLich.Size = new System.Drawing.Size(115, 38);
            this.btnXuatLich.TabIndex = 8;
            this.btnXuatLich.Text = "Xuất lịch";
            this.btnXuatLich.TextColor = System.Drawing.Color.White;
            this.btnXuatLich.UseVisualStyleBackColor = false;
            this.btnXuatLich.Click += new System.EventHandler(this.btnXuatLich_Click);
            // 
            // cmbLoai
            // 
            this.cmbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "Tất cả",
            "Giảng viên",
            "Lớp",
            "Phòng"});
            this.cmbLoai.Location = new System.Drawing.Point(585, 23);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(191, 32);
            this.cmbLoai.TabIndex = 5;
            this.cmbLoai.Text = "Tất cả";
            this.cmbLoai.UseWaitCursor = true;
            // 
            // lbLoai
            // 
            this.lbLoai.AutoSize = true;
            this.lbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoai.Location = new System.Drawing.Point(529, 32);
            this.lbLoai.Name = "lbLoai";
            this.lbLoai.Size = new System.Drawing.Size(50, 24);
            this.lbLoai.TabIndex = 4;
            this.lbLoai.Text = "Loại:";
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTimKiem.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimKiem.Location = new System.Drawing.Point(51, 31);
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(258, 24);
            this.txbTimKiem.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 100);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.dtgLich);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbTieuDe);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1370, 631);
            this.panel3.TabIndex = 2;
            // 
            // dtgLich
            // 
            this.dtgLich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idCaThucHanh,
            this.idLop,
            this.idPhong,
            this.idGiangVien,
            this.namHoc,
            this.kiHoc,
            this.thu});
            this.dtgLich.Location = new System.Drawing.Point(5, 0);
            this.dtgLich.Name = "dtgLich";
            this.dtgLich.ReadOnly = true;
            this.dtgLich.RowHeadersWidth = 51;
            this.dtgLich.Size = new System.Drawing.Size(1353, 442);
            this.dtgLich.TabIndex = 6;
            this.dtgLich.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // idCaThucHanh
            // 
            this.idCaThucHanh.DataPropertyName = "idCaThucHanh";
            this.idCaThucHanh.HeaderText = "ID ca thực hành";
            this.idCaThucHanh.MinimumWidth = 6;
            this.idCaThucHanh.Name = "idCaThucHanh";
            this.idCaThucHanh.ReadOnly = true;
            // 
            // idLop
            // 
            this.idLop.DataPropertyName = "idLop";
            this.idLop.HeaderText = "ID lớp";
            this.idLop.MinimumWidth = 6;
            this.idLop.Name = "idLop";
            this.idLop.ReadOnly = true;
            // 
            // idPhong
            // 
            this.idPhong.DataPropertyName = "idPhong";
            this.idPhong.HeaderText = "ID phòng";
            this.idPhong.MinimumWidth = 6;
            this.idPhong.Name = "idPhong";
            this.idPhong.ReadOnly = true;
            // 
            // idGiangVien
            // 
            this.idGiangVien.DataPropertyName = "idGiangVien";
            this.idGiangVien.HeaderText = "ID giảng viên";
            this.idGiangVien.MinimumWidth = 6;
            this.idGiangVien.Name = "idGiangVien";
            this.idGiangVien.ReadOnly = true;
            // 
            // namHoc
            // 
            this.namHoc.DataPropertyName = "namHoc";
            this.namHoc.HeaderText = "Năm học";
            this.namHoc.MinimumWidth = 6;
            this.namHoc.Name = "namHoc";
            this.namHoc.ReadOnly = true;
            // 
            // kiHoc
            // 
            this.kiHoc.DataPropertyName = "kiHoc";
            this.kiHoc.HeaderText = "Kì học";
            this.kiHoc.MinimumWidth = 6;
            this.kiHoc.Name = "kiHoc";
            this.kiHoc.ReadOnly = true;
            // 
            // thu
            // 
            this.thu.DataPropertyName = "thu";
            this.thu.HeaderText = "Thứ";
            this.thu.MinimumWidth = 6;
            this.thu.Name = "thu";
            this.thu.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1370, 165);
            this.label2.TabIndex = 5;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lbTieuDe.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTieuDe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTieuDe.Location = new System.Drawing.Point(328, 61);
            this.lbTieuDe.Margin = new System.Windows.Forms.Padding(0, 800, 100, 0);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(732, 168);
            this.lbTieuDe.TabIndex = 4;
            this.lbTieuDe.Text = "HỆ THỐNG QUẢN LÝ PHÒNG \r\nTHỰC HÀNH TIN HỌC CỦA\r\nTRƯỜNG ĐẠI HỌC QUY NHƠN";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fMainGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnsQuanLy);
            this.MainMenuStrip = this.mnsQuanLy;
            this.Name = "fMainGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnsQuanLy.ResumeLayout(false);
            this.mnsQuanLy.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mniQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mniThongTin;
        private System.Windows.Forms.ToolStripMenuItem mniDangXuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbLoai;
        private System.Windows.Forms.ComboBox cmbLoai;
        private VBButton btnTimKiem;
        private VBButton btnXuatLich;
        private VBButton btnDoiPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTieuDe;
        public System.Windows.Forms.TextBox txbTimKiem;
        private System.Windows.Forms.DataGridView dtgLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCaThucHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn namHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn thu;
        private System.Windows.Forms.ComboBox cmbNamHoc;
    }
}