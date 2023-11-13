namespace QLPHONGTHUCHANH
{
    partial class fCapNhatGV
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
            this.btnThem = new QLPHONGTHUCHANH.VBButton();
            this.txbIDTaiKhoan = new System.Windows.Forms.TextBox();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.txbKhoa = new System.Windows.Forms.TextBox();
            this.txbTenGV = new System.Windows.Forms.TextBox();
            this.txbMaGV = new System.Windows.Forms.TextBox();
            this.lbIDTaiKhoan = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbKhoa = new System.Windows.Forms.Label();
            this.lbTenGV = new System.Windows.Forms.Label();
            this.lbMaGV = new System.Windows.Forms.Label();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnThem.Location = new System.Drawing.Point(578, 413);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 40);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Cập nhật thông tin giảng viên";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txbIDTaiKhoan
            // 
            this.txbIDTaiKhoan.Location = new System.Drawing.Point(522, 357);
            this.txbIDTaiKhoan.Name = "txbIDTaiKhoan";
            this.txbIDTaiKhoan.Size = new System.Drawing.Size(233, 22);
            this.txbIDTaiKhoan.TabIndex = 5;
            // 
            // txbSDT
            // 
            this.txbSDT.Location = new System.Drawing.Point(522, 293);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(233, 22);
            this.txbSDT.TabIndex = 4;
            // 
            // txbKhoa
            // 
            this.txbKhoa.Location = new System.Drawing.Point(522, 242);
            this.txbKhoa.Name = "txbKhoa";
            this.txbKhoa.Size = new System.Drawing.Size(233, 22);
            this.txbKhoa.TabIndex = 3;
            // 
            // txbTenGV
            // 
            this.txbTenGV.Location = new System.Drawing.Point(522, 186);
            this.txbTenGV.Name = "txbTenGV";
            this.txbTenGV.Size = new System.Drawing.Size(233, 22);
            this.txbTenGV.TabIndex = 2;
            // 
            // txbMaGV
            // 
            this.txbMaGV.Location = new System.Drawing.Point(522, 135);
            this.txbMaGV.Name = "txbMaGV";
            this.txbMaGV.ReadOnly = true;
            this.txbMaGV.Size = new System.Drawing.Size(233, 22);
            this.txbMaGV.TabIndex = 1;
            // 
            // lbIDTaiKhoan
            // 
            this.lbIDTaiKhoan.AutoSize = true;
            this.lbIDTaiKhoan.Location = new System.Drawing.Point(311, 357);
            this.lbIDTaiKhoan.Name = "lbIDTaiKhoan";
            this.lbIDTaiKhoan.Size = new System.Drawing.Size(76, 16);
            this.lbIDTaiKhoan.TabIndex = 21;
            this.lbIDTaiKhoan.Text = "IdTaiKhoan";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(311, 299);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(85, 16);
            this.lbSDT.TabIndex = 23;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // lbKhoa
            // 
            this.lbKhoa.AutoSize = true;
            this.lbKhoa.Location = new System.Drawing.Point(311, 239);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(38, 16);
            this.lbKhoa.TabIndex = 24;
            this.lbKhoa.Text = "Khoa";
            // 
            // lbTenGV
            // 
            this.lbTenGV.AutoSize = true;
            this.lbTenGV.Location = new System.Drawing.Point(311, 189);
            this.lbTenGV.Name = "lbTenGV";
            this.lbTenGV.Size = new System.Drawing.Size(96, 16);
            this.lbTenGV.TabIndex = 25;
            this.lbTenGV.Text = "Tên giảng viên";
            // 
            // lbMaGV
            // 
            this.lbMaGV.AutoSize = true;
            this.lbMaGV.Location = new System.Drawing.Point(311, 141);
            this.lbMaGV.Name = "lbMaGV";
            this.lbMaGV.Size = new System.Drawing.Size(91, 16);
            this.lbMaGV.TabIndex = 26;
            this.lbMaGV.Text = "Mã giảng viên";
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbTieuDe.Location = new System.Drawing.Point(323, 44);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(470, 32);
            this.lbTieuDe.TabIndex = 20;
            this.lbTieuDe.Text = "Cập nhật thông tin giảng viên mới";
            // 
            // fCapNhatGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLPHONGTHUCHANH.Properties.Resources.d46a39dac513124d4b02;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txbIDTaiKhoan);
            this.Controls.Add(this.txbSDT);
            this.Controls.Add(this.txbKhoa);
            this.Controls.Add(this.txbTenGV);
            this.Controls.Add(this.txbMaGV);
            this.Controls.Add(this.lbIDTaiKhoan);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbKhoa);
            this.Controls.Add(this.lbTenGV);
            this.Controls.Add(this.lbMaGV);
            this.Controls.Add(this.lbTieuDe);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fCapNhatGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thông tin giảng viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VBButton btnThem;
        private System.Windows.Forms.TextBox txbIDTaiKhoan;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.TextBox txbKhoa;
        private System.Windows.Forms.TextBox txbTenGV;
        private System.Windows.Forms.TextBox txbMaGV;
        private System.Windows.Forms.Label lbIDTaiKhoan;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbKhoa;
        private System.Windows.Forms.Label lbTenGV;
        private System.Windows.Forms.Label lbMaGV;
        private System.Windows.Forms.Label lbTieuDe;
    }
}