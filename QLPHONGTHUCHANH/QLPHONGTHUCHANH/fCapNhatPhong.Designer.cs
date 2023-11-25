namespace QLPHONGTHUCHANH
{
    partial class fCapNhatPhong
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
            this.btnCapNhat = new QLPHONGTHUCHANH.VBButton();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.txbSLPM = new System.Windows.Forms.TextBox();
            this.txbKhuVuc = new System.Windows.Forms.TextBox();
            this.txbTenPhong = new System.Windows.Forms.TextBox();
            this.txbMaPhong = new System.Windows.Forms.TextBox();
            this.lbLoai = new System.Windows.Forms.Label();
            this.lbSLPM = new System.Windows.Forms.Label();
            this.lbKhuVuc = new System.Windows.Forms.Label();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Blue;
            this.btnCapNhat.BackgroundColor = System.Drawing.Color.Blue;
            this.btnCapNhat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhat.BorderRadius = 20;
            this.btnCapNhat.BorderSize = 0;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(467, 433);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(150, 40);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập Nhật Thông Tin Phòng";
            this.btnCapNhat.TextColor = System.Drawing.Color.White;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cmbLoai
            // 
            this.cmbLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLoai.DisplayMember = "Thực hành thông thường";
            this.cmbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "Thực hành thông thường",
            "Thực hành lắp ráp",
            "Thực hành mạng"});
            this.cmbLoai.Location = new System.Drawing.Point(522, 361);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(233, 24);
            this.cmbLoai.TabIndex = 5;
            // 
            // txbSLPM
            // 
            this.txbSLPM.Location = new System.Drawing.Point(522, 305);
            this.txbSLPM.Name = "txbSLPM";
            this.txbSLPM.Size = new System.Drawing.Size(233, 22);
            this.txbSLPM.TabIndex = 4;
            // 
            // txbKhuVuc
            // 
            this.txbKhuVuc.Location = new System.Drawing.Point(522, 254);
            this.txbKhuVuc.Name = "txbKhuVuc";
            this.txbKhuVuc.Size = new System.Drawing.Size(233, 22);
            this.txbKhuVuc.TabIndex = 3;
            // 
            // txbTenPhong
            // 
            this.txbTenPhong.Location = new System.Drawing.Point(522, 198);
            this.txbTenPhong.Name = "txbTenPhong";
            this.txbTenPhong.Size = new System.Drawing.Size(233, 22);
            this.txbTenPhong.TabIndex = 2;
            // 
            // txbMaPhong
            // 
            this.txbMaPhong.Location = new System.Drawing.Point(522, 147);
            this.txbMaPhong.MaxLength = 5;
            this.txbMaPhong.Name = "txbMaPhong";
            this.txbMaPhong.ReadOnly = true;
            this.txbMaPhong.Size = new System.Drawing.Size(233, 22);
            this.txbMaPhong.TabIndex = 1;
            // 
            // lbLoai
            // 
            this.lbLoai.AutoSize = true;
            this.lbLoai.Location = new System.Drawing.Point(311, 361);
            this.lbLoai.Name = "lbLoai";
            this.lbLoai.Size = new System.Drawing.Size(92, 16);
            this.lbLoai.TabIndex = 22;
            this.lbLoai.Text = "Loại thực hành";
            // 
            // lbSLPM
            // 
            this.lbSLPM.AutoSize = true;
            this.lbSLPM.Location = new System.Drawing.Point(311, 311);
            this.lbSLPM.Name = "lbSLPM";
            this.lbSLPM.Size = new System.Drawing.Size(130, 16);
            this.lbSLPM.TabIndex = 23;
            this.lbSLPM.Text = "Số lượng phòng máy";
            // 
            // lbKhuVuc
            // 
            this.lbKhuVuc.AutoSize = true;
            this.lbKhuVuc.Location = new System.Drawing.Point(311, 251);
            this.lbKhuVuc.Name = "lbKhuVuc";
            this.lbKhuVuc.Size = new System.Drawing.Size(79, 16);
            this.lbKhuVuc.TabIndex = 24;
            this.lbKhuVuc.Text = "Tên khu vực";
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.AutoSize = true;
            this.lbTenPhong.Location = new System.Drawing.Point(311, 201);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(72, 16);
            this.lbTenPhong.TabIndex = 25;
            this.lbTenPhong.Text = "Tên phòng";
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Location = new System.Drawing.Point(311, 153);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(67, 16);
            this.lbMaPhong.TabIndex = 26;
            this.lbMaPhong.Text = "Mã phòng";
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbTieuDe.Location = new System.Drawing.Point(424, 76);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(292, 32);
            this.lbTieuDe.TabIndex = 21;
            this.lbTieuDe.Text = "Thông tin phòng mới";
            // 
            // fCapNhatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLPHONGTHUCHANH.Properties.Resources.d46a39dac513124d4b02;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.cmbLoai);
            this.Controls.Add(this.txbSLPM);
            this.Controls.Add(this.txbKhuVuc);
            this.Controls.Add(this.txbTenPhong);
            this.Controls.Add(this.txbMaPhong);
            this.Controls.Add(this.lbLoai);
            this.Controls.Add(this.lbSLPM);
            this.Controls.Add(this.lbKhuVuc);
            this.Controls.Add(this.lbTenPhong);
            this.Controls.Add(this.lbMaPhong);
            this.Controls.Add(this.lbTieuDe);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fCapNhatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VBButton btnCapNhat;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.TextBox txbSLPM;
        private System.Windows.Forms.TextBox txbKhuVuc;
        private System.Windows.Forms.TextBox txbTenPhong;
        private System.Windows.Forms.TextBox txbMaPhong;
        private System.Windows.Forms.Label lbLoai;
        private System.Windows.Forms.Label lbSLPM;
        private System.Windows.Forms.Label lbKhuVuc;
        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.Label lbTieuDe;
    }
}