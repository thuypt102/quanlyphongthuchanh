﻿namespace QLPHONGTHUCHANH
{
    partial class fKhoLuuTruGiangVien
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
            this.dtaGiangVien = new System.Windows.Forms.DataGridView();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGiangVien)).BeginInit();
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
            this.lbTieuDe.Location = new System.Drawing.Point(282, 20);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(449, 33);
            this.lbTieuDe.TabIndex = 1;
            this.lbTieuDe.Text = "Kho lưu trữ thông tin giảng viên";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtaGiangVien
            // 
            this.dtaGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaGiangVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tenGiangVien,
            this.khoa,
            this.sdt,
            this.email,
            this.idTaiKhoan});
            this.dtaGiangVien.Location = new System.Drawing.Point(56, 68);
            this.dtaGiangVien.Name = "dtaGiangVien";
            this.dtaGiangVien.Size = new System.Drawing.Size(881, 311);
            this.dtaGiangVien.TabIndex = 3;
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.Blue;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(432, 410);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(131, 40);
            this.btnKhoiPhuc.TabIndex = 4;
            this.btnKhoiPhuc.Text = "Khôi Phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã giảng viên";
            this.id.Name = "id";
            // 
            // tenGiangVien
            // 
            this.tenGiangVien.DataPropertyName = "tenGiangVien";
            this.tenGiangVien.HeaderText = "Tên giảng viên";
            this.tenGiangVien.Name = "tenGiangVien";
            // 
            // khoa
            // 
            this.khoa.DataPropertyName = "khoa";
            this.khoa.HeaderText = "Khoa";
            this.khoa.Name = "khoa";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // idTaiKhoan
            // 
            this.idTaiKhoan.DataPropertyName = "idTaiKhoan";
            this.idTaiKhoan.HeaderText = "Mã tài khoản";
            this.idTaiKhoan.Name = "idTaiKhoan";
            // 
            // fKhoLuuTruGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLPHONGTHUCHANH.Properties.Resources.d46a39dac513124d4b022;
            this.ClientSize = new System.Drawing.Size(984, 480);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.dtaGiangVien);
            this.Controls.Add(this.lbTieuDe);
            this.Name = "fKhoLuuTruGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho lưu trữ";
            ((System.ComponentModel.ISupportInitialize)(this.dtaGiangVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.DataGridView dtaGiangVien;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTaiKhoan;
    }
}