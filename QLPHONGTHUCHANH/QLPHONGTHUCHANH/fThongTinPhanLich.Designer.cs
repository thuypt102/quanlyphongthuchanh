namespace QLPHONGTHUCHANH
{
    partial class fThongTinPhanLich
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
            this.cmbNamHoc = new System.Windows.Forms.ComboBox();
            this.lbTieuĐeangKyLBS = new System.Windows.Forms.Label();
            this.lbTenLop = new System.Windows.Forms.Label();
            this.lbCaThucHanh = new System.Windows.Forms.Label();
            this.cmbKiHoc = new System.Windows.Forms.ComboBox();
            this.btnPhanLich = new QLPHONGTHUCHANH.VBButton();
            this.SuspendLayout();
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.Location = new System.Drawing.Point(328, 135);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(257, 33);
            this.cmbNamHoc.TabIndex = 28;
            // 
            // lbTieuĐeangKyLBS
            // 
            this.lbTieuĐeangKyLBS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTieuĐeangKyLBS.AutoSize = true;
            this.lbTieuĐeangKyLBS.BackColor = System.Drawing.Color.Transparent;
            this.lbTieuĐeangKyLBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuĐeangKyLBS.Location = new System.Drawing.Point(180, 47);
            this.lbTieuĐeangKyLBS.Name = "lbTieuĐeangKyLBS";
            this.lbTieuĐeangKyLBS.Size = new System.Drawing.Size(390, 37);
            this.lbTieuĐeangKyLBS.TabIndex = 27;
            this.lbTieuĐeangKyLBS.Text = "Nhập thông tin phân lịch";
            this.lbTieuĐeangKyLBS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTenLop
            // 
            this.lbTenLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTenLop.AutoSize = true;
            this.lbTenLop.BackColor = System.Drawing.Color.Transparent;
            this.lbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLop.Location = new System.Drawing.Point(161, 215);
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.Size = new System.Drawing.Size(80, 29);
            this.lbTenLop.TabIndex = 24;
            this.lbTenLop.Text = "Kì học";
            // 
            // lbCaThucHanh
            // 
            this.lbCaThucHanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCaThucHanh.AutoSize = true;
            this.lbCaThucHanh.BackColor = System.Drawing.Color.Transparent;
            this.lbCaThucHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCaThucHanh.Location = new System.Drawing.Point(157, 139);
            this.lbCaThucHanh.Name = "lbCaThucHanh";
            this.lbCaThucHanh.Size = new System.Drawing.Size(109, 29);
            this.lbCaThucHanh.TabIndex = 23;
            this.lbCaThucHanh.Text = "Năm học";
            // 
            // cmbKiHoc
            // 
            this.cmbKiHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbKiHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKiHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKiHoc.FormattingEnabled = true;
            this.cmbKiHoc.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbKiHoc.Location = new System.Drawing.Point(328, 211);
            this.cmbKiHoc.Name = "cmbKiHoc";
            this.cmbKiHoc.Size = new System.Drawing.Size(257, 33);
            this.cmbKiHoc.TabIndex = 29;
            // 
            // btnPhanLich
            // 
            this.btnPhanLich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPhanLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnPhanLich.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnPhanLich.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPhanLich.BorderRadius = 20;
            this.btnPhanLich.BorderSize = 0;
            this.btnPhanLich.FlatAppearance.BorderSize = 0;
            this.btnPhanLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanLich.ForeColor = System.Drawing.Color.White;
            this.btnPhanLich.Location = new System.Drawing.Point(301, 283);
            this.btnPhanLich.Name = "btnPhanLich";
            this.btnPhanLich.Size = new System.Drawing.Size(178, 40);
            this.btnPhanLich.TabIndex = 25;
            this.btnPhanLich.Text = "Phân lịch";
            this.btnPhanLich.TextColor = System.Drawing.Color.White;
            this.btnPhanLich.UseVisualStyleBackColor = false;
            // 
            // fThongTinPhanLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLPHONGTHUCHANH.Properties.Resources.d46a39dac513124d4b021;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 377);
            this.Controls.Add(this.cmbKiHoc);
            this.Controls.Add(this.cmbNamHoc);
            this.Controls.Add(this.lbTieuĐeangKyLBS);
            this.Controls.Add(this.btnPhanLich);
            this.Controls.Add(this.lbTenLop);
            this.Controls.Add(this.lbCaThucHanh);
            this.Name = "fThongTinPhanLich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fThongTinPhanLich";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNamHoc;
        private System.Windows.Forms.Label lbTieuĐeangKyLBS;
        private VBButton btnPhanLich;
        private System.Windows.Forms.Label lbTenLop;
        private System.Windows.Forms.Label lbCaThucHanh;
        private System.Windows.Forms.ComboBox cmbKiHoc;
    }
}