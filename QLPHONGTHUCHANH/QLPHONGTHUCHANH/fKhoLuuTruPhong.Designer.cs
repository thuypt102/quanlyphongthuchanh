namespace QLPHONGTHUCHANH
{
    partial class fKhoLuuTruPhong
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
            this.dtaPhongMay = new System.Windows.Forms.DataGridView();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiThucHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtaPhongMay)).BeginInit();
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
            this.lbTieuDe.Location = new System.Drawing.Point(289, 22);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(394, 33);
            this.lbTieuDe.TabIndex = 1;
            this.lbTieuDe.Text = "Kho lưu trữ thông tin phòng";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtaPhongMay
            // 
            this.dtaPhongMay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaPhongMay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaPhongMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaPhongMay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhong,
            this.tenPhong,
            this.tenKhuVuc,
            this.soLuongMay,
            this.loaiThucHanh});
            this.dtaPhongMay.Location = new System.Drawing.Point(44, 89);
            this.dtaPhongMay.Name = "dtaPhongMay";
            this.dtaPhongMay.Size = new System.Drawing.Size(896, 306);
            this.dtaPhongMay.TabIndex = 3;
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.Blue;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(430, 419);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(131, 40);
            this.btnKhoiPhuc.TabIndex = 4;
            this.btnKhoiPhuc.Text = "Khôi Phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // maPhong
            // 
            this.maPhong.DataPropertyName = "id";
            this.maPhong.HeaderText = "Mã phòng";
            this.maPhong.Name = "maPhong";
            // 
            // tenPhong
            // 
            this.tenPhong.DataPropertyName = "tenPhong";
            this.tenPhong.HeaderText = "Tên phòng";
            this.tenPhong.Name = "tenPhong";
            // 
            // tenKhuVuc
            // 
            this.tenKhuVuc.DataPropertyName = "tenKhuVuc";
            this.tenKhuVuc.HeaderText = "Tên khu vực";
            this.tenKhuVuc.Name = "tenKhuVuc";
            // 
            // soLuongMay
            // 
            this.soLuongMay.DataPropertyName = "soLuongMay";
            this.soLuongMay.HeaderText = "Số lượng máy";
            this.soLuongMay.Name = "soLuongMay";
            // 
            // loaiThucHanh
            // 
            this.loaiThucHanh.DataPropertyName = "loaiThucHanh";
            this.loaiThucHanh.HeaderText = "Loại thực hành";
            this.loaiThucHanh.Name = "loaiThucHanh";
            // 
            // fKhoLuuTruPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLPHONGTHUCHANH.Properties.Resources.d46a39dac513124d4b022;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 480);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.dtaPhongMay);
            this.Controls.Add(this.lbTieuDe);
            this.Name = "fKhoLuuTruPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho lưu trữ";
            ((System.ComponentModel.ISupportInitialize)(this.dtaPhongMay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.DataGridView dtaPhongMay;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiThucHanh;
    }
}