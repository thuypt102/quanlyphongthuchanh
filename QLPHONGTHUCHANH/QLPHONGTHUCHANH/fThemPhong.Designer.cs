﻿namespace QLPHONGTHUCHANH
{
    partial class fThemPhong
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
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.txbSlSV = new System.Windows.Forms.TextBox();
            this.txbCaLT = new System.Windows.Forms.TextBox();
            this.txbIDGV = new System.Windows.Forms.TextBox();
            this.txbKhoa = new System.Windows.Forms.TextBox();
            this.txbTenLop = new System.Windows.Forms.TextBox();
            this.txbMaLop = new System.Windows.Forms.TextBox();
            this.lbLoai = new System.Windows.Forms.Label();
            this.lbSlSV = new System.Windows.Forms.Label();
            this.lbCaLT = new System.Windows.Forms.Label();
            this.lbIDGV = new System.Windows.Forms.Label();
            this.lbKhoa = new System.Windows.Forms.Label();
            this.lbTenLop = new System.Windows.Forms.Label();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.btnThem = new QLPHONGTHUCHANH.VBButton();
            this.SuspendLayout();
            // 
            // cmbLoai
            // 
            this.cmbLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbLoai.Location = new System.Drawing.Point(522, 454);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(233, 24);
            this.cmbLoai.TabIndex = 19;
            // 
            // txbSlSV
            // 
            this.txbSlSV.Location = new System.Drawing.Point(522, 398);
            this.txbSlSV.Name = "txbSlSV";
            this.txbSlSV.Size = new System.Drawing.Size(233, 22);
            this.txbSlSV.TabIndex = 13;
            // 
            // txbCaLT
            // 
            this.txbCaLT.Location = new System.Drawing.Point(522, 347);
            this.txbCaLT.Name = "txbCaLT";
            this.txbCaLT.Size = new System.Drawing.Size(233, 22);
            this.txbCaLT.TabIndex = 14;
            // 
            // txbIDGV
            // 
            this.txbIDGV.Location = new System.Drawing.Point(522, 302);
            this.txbIDGV.Name = "txbIDGV";
            this.txbIDGV.Size = new System.Drawing.Size(233, 22);
            this.txbIDGV.TabIndex = 15;
            // 
            // txbKhoa
            // 
            this.txbKhoa.Location = new System.Drawing.Point(522, 251);
            this.txbKhoa.Name = "txbKhoa";
            this.txbKhoa.Size = new System.Drawing.Size(233, 22);
            this.txbKhoa.TabIndex = 16;
            // 
            // txbTenLop
            // 
            this.txbTenLop.Location = new System.Drawing.Point(522, 195);
            this.txbTenLop.Name = "txbTenLop";
            this.txbTenLop.Size = new System.Drawing.Size(233, 22);
            this.txbTenLop.TabIndex = 17;
            // 
            // txbMaLop
            // 
            this.txbMaLop.Location = new System.Drawing.Point(522, 144);
            this.txbMaLop.Name = "txbMaLop";
            this.txbMaLop.Size = new System.Drawing.Size(233, 22);
            this.txbMaLop.TabIndex = 18;
            // 
            // lbLoai
            // 
            this.lbLoai.AutoSize = true;
            this.lbLoai.Location = new System.Drawing.Point(311, 462);
            this.lbLoai.Name = "lbLoai";
            this.lbLoai.Size = new System.Drawing.Size(92, 16);
            this.lbLoai.TabIndex = 6;
            this.lbLoai.Text = "Loại thực hành";
            // 
            // lbSlSV
            // 
            this.lbSlSV.AutoSize = true;
            this.lbSlSV.Location = new System.Drawing.Point(311, 404);
            this.lbSlSV.Name = "lbSlSV";
            this.lbSlSV.Size = new System.Drawing.Size(90, 16);
            this.lbSlSV.TabIndex = 7;
            this.lbSlSV.Text = "Số lượng sinh ";
            // 
            // lbCaLT
            // 
            this.lbCaLT.AutoSize = true;
            this.lbCaLT.Location = new System.Drawing.Point(311, 358);
            this.lbCaLT.Name = "lbCaLT";
            this.lbCaLT.Size = new System.Drawing.Size(75, 16);
            this.lbCaLT.TabIndex = 8;
            this.lbCaLT.Text = "Ca lý thuyết";
            // 
            // lbIDGV
            // 
            this.lbIDGV.AutoSize = true;
            this.lbIDGV.Location = new System.Drawing.Point(311, 308);
            this.lbIDGV.Name = "lbIDGV";
            this.lbIDGV.Size = new System.Drawing.Size(111, 16);
            this.lbIDGV.TabIndex = 9;
            this.lbIDGV.Text = "ID giảng viên dạy";
            // 
            // lbKhoa
            // 
            this.lbKhoa.AutoSize = true;
            this.lbKhoa.Location = new System.Drawing.Point(311, 248);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(64, 16);
            this.lbKhoa.TabIndex = 10;
            this.lbKhoa.Text = "Tên khoa";
            // 
            // lbTenLop
            // 
            this.lbTenLop.AutoSize = true;
            this.lbTenLop.Location = new System.Drawing.Point(311, 198);
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.Size = new System.Drawing.Size(53, 16);
            this.lbTenLop.TabIndex = 11;
            this.lbTenLop.Text = "Tên lớp";
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Location = new System.Drawing.Point(311, 150);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(48, 16);
            this.lbMaLop.TabIndex = 12;
            this.lbMaLop.Text = "Mã lớp";
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Location = new System.Drawing.Point(579, 77);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(128, 16);
            this.lbTieuDe.TabIndex = 5;
            this.lbTieuDe.Text = "Thông tin phòng mới";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Blue;
            this.btnThem.BackgroundColor = System.Drawing.Color.Blue;
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 20;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(582, 502);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 40);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm phòng";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // fThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLPHONGTHUCHANH.Properties.Resources.d46a39dac513124d4b02;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cmbLoai);
            this.Controls.Add(this.txbSlSV);
            this.Controls.Add(this.txbCaLT);
            this.Controls.Add(this.txbIDGV);
            this.Controls.Add(this.txbKhoa);
            this.Controls.Add(this.txbTenLop);
            this.Controls.Add(this.txbMaLop);
            this.Controls.Add(this.lbLoai);
            this.Controls.Add(this.lbSlSV);
            this.Controls.Add(this.lbCaLT);
            this.Controls.Add(this.lbIDGV);
            this.Controls.Add(this.lbKhoa);
            this.Controls.Add(this.lbTenLop);
            this.Controls.Add(this.lbMaLop);
            this.Controls.Add(this.lbTieuDe);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fThemPhong";
            this.Text = "Thêm thông tin phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.TextBox txbSlSV;
        private System.Windows.Forms.TextBox txbCaLT;
        private System.Windows.Forms.TextBox txbIDGV;
        private System.Windows.Forms.TextBox txbKhoa;
        private System.Windows.Forms.TextBox txbTenLop;
        private System.Windows.Forms.TextBox txbMaLop;
        private System.Windows.Forms.Label lbLoai;
        private System.Windows.Forms.Label lbSlSV;
        private System.Windows.Forms.Label lbCaLT;
        private System.Windows.Forms.Label lbIDGV;
        private System.Windows.Forms.Label lbKhoa;
        private System.Windows.Forms.Label lbTenLop;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.Label lbTieuDe;
        private VBButton btnThem;
    }
}