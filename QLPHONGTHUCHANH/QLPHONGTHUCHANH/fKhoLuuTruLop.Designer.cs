namespace QLPHONGTHUCHANH
{
    partial class fKhoLuuTruLop
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
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.dtaLop = new System.Windows.Forms.DataGridView();
            this.maLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGiangVienPhuTrach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caLyThuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiThucHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtaLop)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.BackColor = System.Drawing.Color.White;
            this.lbTieuDe.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Image = global::QLPHONGTHUCHANH.Properties.Resources.d46a39dac513124d4b021;
            this.lbTieuDe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTieuDe.Location = new System.Drawing.Point(317, 24);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(351, 33);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "Kho lưu trữ thông tin lớp";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.Blue;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(419, 408);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(131, 40);
            this.btnKhoiPhuc.TabIndex = 1;
            this.btnKhoiPhuc.Text = "Khôi Phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // dtaLop
            // 
            this.dtaLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLop,
            this.tenLop,
            this.tenKhoa,
            this.idGiangVienPhuTrach,
            this.caLyThuyet,
            this.soLuongSinhVien,
            this.loaiThucHanh});
            this.dtaLop.Location = new System.Drawing.Point(51, 74);
            this.dtaLop.Name = "dtaLop";
            this.dtaLop.Size = new System.Drawing.Size(881, 306);
            this.dtaLop.TabIndex = 2;
            // 
            // maLop
            // 
            this.maLop.DataPropertyName = "id";
            this.maLop.HeaderText = "Mã lớp";
            this.maLop.Name = "maLop";
            // 
            // tenLop
            // 
            this.tenLop.DataPropertyName = "tenLop";
            this.tenLop.HeaderText = "Tên lớp";
            this.tenLop.Name = "tenLop";
            // 
            // tenKhoa
            // 
            this.tenKhoa.DataPropertyName = "tenKhoa";
            this.tenKhoa.HeaderText = "Khoa";
            this.tenKhoa.Name = "tenKhoa";
            // 
            // idGiangVienPhuTrach
            // 
            this.idGiangVienPhuTrach.DataPropertyName = "idGiangVienPhuTrach";
            this.idGiangVienPhuTrach.HeaderText = "Mã giảng viên phụ trách";
            this.idGiangVienPhuTrach.Name = "idGiangVienPhuTrach";
            // 
            // caLyThuyet
            // 
            this.caLyThuyet.DataPropertyName = "caLyThuyet";
            this.caLyThuyet.HeaderText = "Ca lý thuyết";
            this.caLyThuyet.Name = "caLyThuyet";
            // 
            // soLuongSinhVien
            // 
            this.soLuongSinhVien.DataPropertyName = "soLuongSinhVien";
            this.soLuongSinhVien.HeaderText = "Số lượng sinh viên";
            this.soLuongSinhVien.Name = "soLuongSinhVien";
            // 
            // loaiThucHanh
            // 
            this.loaiThucHanh.DataPropertyName = "loaiThucHanh";
            this.loaiThucHanh.HeaderText = "Loại thực hành";
            this.loaiThucHanh.Name = "loaiThucHanh";
            // 
            // fKhoLuuTruLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLPHONGTHUCHANH.Properties.Resources.d46a39dac513124d4b022;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 480);
            this.Controls.Add(this.dtaLop);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.lbTieuDe);
            this.Name = "fKhoLuuTruLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho lưu trữ";
            ((System.ComponentModel.ISupportInitialize)(this.dtaLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.DataGridView dtaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGiangVienPhuTrach;
        private System.Windows.Forms.DataGridViewTextBoxColumn caLyThuyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiThucHanh;
    }
}