namespace QLPHONGTHUCHANH
{
    partial class fThongBao
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
            this.pnChiTiet = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.txtNguoiGui = new System.Windows.Forms.TextBox();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.lbNguoiGui = new System.Windows.Forms.Label();
            this.lbTenTB = new System.Windows.Forms.Label();
            this.txbNoiDung = new System.Windows.Forms.TextBox();
            this.btnXuLy = new QLPHONGTHUCHANH.VBButton();
            this.pnChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lbTieuDe.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTieuDe.Location = new System.Drawing.Point(421, 37);
            this.lbTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(323, 41);
            this.lbTieuDe.TabIndex = 2;
            this.lbTieuDe.Text = "Chi tiết thông báo";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnChiTiet
            // 
            this.pnChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnChiTiet.BackColor = System.Drawing.Color.SkyBlue;
            this.pnChiTiet.Controls.Add(this.txtId);
            this.pnChiTiet.Controls.Add(this.lbId);
            this.pnChiTiet.Controls.Add(this.txtThoiGian);
            this.pnChiTiet.Controls.Add(this.txtNguoiGui);
            this.pnChiTiet.Controls.Add(this.txtTieuDe);
            this.pnChiTiet.Controls.Add(this.lbThoiGian);
            this.pnChiTiet.Controls.Add(this.lbNguoiGui);
            this.pnChiTiet.Controls.Add(this.lbTenTB);
            this.pnChiTiet.Controls.Add(this.txbNoiDung);
            this.pnChiTiet.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnChiTiet.Location = new System.Drawing.Point(111, 107);
            this.pnChiTiet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnChiTiet.Name = "pnChiTiet";
            this.pnChiTiet.Size = new System.Drawing.Size(929, 320);
            this.pnChiTiet.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(105, 20);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(320, 26);
            this.txtId.TabIndex = 9;
            // 
            // lbId
            // 
            this.lbId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.White;
            this.lbId.Location = new System.Drawing.Point(15, 22);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(33, 24);
            this.lbId.TabIndex = 8;
            this.lbId.Text = "Id:";
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThoiGian.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGian.Location = new System.Drawing.Point(573, 55);
            this.txtThoiGian.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.ReadOnly = true;
            this.txtThoiGian.Size = new System.Drawing.Size(320, 26);
            this.txtThoiGian.TabIndex = 7;
            // 
            // txtNguoiGui
            // 
            this.txtNguoiGui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNguoiGui.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiGui.Location = new System.Drawing.Point(572, 20);
            this.txtNguoiGui.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNguoiGui.Name = "txtNguoiGui";
            this.txtNguoiGui.ReadOnly = true;
            this.txtNguoiGui.Size = new System.Drawing.Size(320, 26);
            this.txtNguoiGui.TabIndex = 6;
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTieuDe.Location = new System.Drawing.Point(105, 56);
            this.txtTieuDe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.ReadOnly = true;
            this.txtTieuDe.Size = new System.Drawing.Size(320, 26);
            this.txtTieuDe.TabIndex = 5;
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGian.ForeColor = System.Drawing.Color.White;
            this.lbThoiGian.Location = new System.Drawing.Point(443, 58);
            this.lbThoiGian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(50, 24);
            this.lbThoiGian.TabIndex = 4;
            this.lbThoiGian.Text = "Lúc:";
            // 
            // lbNguoiGui
            // 
            this.lbNguoiGui.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNguoiGui.AutoSize = true;
            this.lbNguoiGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiGui.ForeColor = System.Drawing.Color.White;
            this.lbNguoiGui.Location = new System.Drawing.Point(443, 23);
            this.lbNguoiGui.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNguoiGui.Name = "lbNguoiGui";
            this.lbNguoiGui.Size = new System.Drawing.Size(129, 24);
            this.lbNguoiGui.TabIndex = 3;
            this.lbNguoiGui.Text = "Được gửi từ: ";
            // 
            // lbTenTB
            // 
            this.lbTenTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTenTB.AutoSize = true;
            this.lbTenTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTB.ForeColor = System.Drawing.Color.White;
            this.lbTenTB.Location = new System.Drawing.Point(15, 57);
            this.lbTenTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenTB.Name = "lbTenTB";
            this.lbTenTB.Size = new System.Drawing.Size(95, 24);
            this.lbTenTB.TabIndex = 2;
            this.lbTenTB.Text = "Tiêu đề: ";
            // 
            // txbNoiDung
            // 
            this.txbNoiDung.AcceptsReturn = true;
            this.txbNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNoiDung.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNoiDung.Location = new System.Drawing.Point(19, 130);
            this.txbNoiDung.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbNoiDung.Multiline = true;
            this.txbNoiDung.Name = "txbNoiDung";
            this.txbNoiDung.ReadOnly = true;
            this.txbNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbNoiDung.Size = new System.Drawing.Size(891, 169);
            this.txbNoiDung.TabIndex = 1;
            // 
            // btnXuLy
            // 
            this.btnXuLy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnXuLy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.btnXuLy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXuLy.BorderRadius = 20;
            this.btnXuLy.BorderSize = 0;
            this.btnXuLy.FlatAppearance.BorderSize = 0;
            this.btnXuLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLy.ForeColor = System.Drawing.Color.White;
            this.btnXuLy.Location = new System.Drawing.Point(455, 472);
            this.btnXuLy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(244, 46);
            this.btnXuLy.TabIndex = 12;
            this.btnXuLy.Text = "Đã xử lý";
            this.btnXuLy.TextColor = System.Drawing.Color.White;
            this.btnXuLy.UseVisualStyleBackColor = false;
            this.btnXuLy.Click += new System.EventHandler(this.btnXuLy_Click);
            // 
            // fThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLPHONGTHUCHANH.Properties.Resources.d46a39dac513124d4b022;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1148, 554);
            this.Controls.Add(this.btnXuLy);
            this.Controls.Add(this.pnChiTiet);
            this.Controls.Add(this.lbTieuDe);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "fThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông báo";
            this.pnChiTiet.ResumeLayout(false);
            this.pnChiTiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Panel pnChiTiet;
        private VBButton btnXuLy;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.Label lbNguoiGui;
        private System.Windows.Forms.Label lbTenTB;
        private System.Windows.Forms.TextBox txbNoiDung;
        private System.Windows.Forms.TextBox txtThoiGian;
        private System.Windows.Forms.TextBox txtNguoiGui;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbId;
    }
}