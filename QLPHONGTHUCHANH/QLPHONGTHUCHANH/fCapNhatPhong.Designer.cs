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
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCapNhat.BackColor = System.Drawing.Color.Blue;
            this.btnCapNhat.BackgroundColor = System.Drawing.Color.Blue;
            this.btnCapNhat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhat.BorderRadius = 20;
            this.btnCapNhat.BorderSize = 0;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(359, 463);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(252, 45);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập Nhật Thông Tin Phòng";
            this.btnCapNhat.TextColor = System.Drawing.Color.White;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cmbLoai
            // 
            this.cmbLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLoai.DisplayMember = "Thực hành thông thường";
            this.cmbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "Thực hành thông thường",
            "Thực hành lắp ráp",
            "Thực hành mạng"});
            this.cmbLoai.Location = new System.Drawing.Point(403, 388);
            this.cmbLoai.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(276, 24);
            this.cmbLoai.TabIndex = 5;
            // 
            // txbSLPM
            // 
            this.txbSLPM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbSLPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txbSLPM.Location = new System.Drawing.Point(403, 319);
            this.txbSLPM.Margin = new System.Windows.Forms.Padding(2);
            this.txbSLPM.Name = "txbSLPM";
            this.txbSLPM.Size = new System.Drawing.Size(276, 24);
            this.txbSLPM.TabIndex = 4;
            // 
            // txbKhuVuc
            // 
            this.txbKhuVuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txbKhuVuc.Location = new System.Drawing.Point(403, 258);
            this.txbKhuVuc.Margin = new System.Windows.Forms.Padding(2);
            this.txbKhuVuc.Name = "txbKhuVuc";
            this.txbKhuVuc.Size = new System.Drawing.Size(276, 24);
            this.txbKhuVuc.TabIndex = 3;
            // 
            // txbTenPhong
            // 
            this.txbTenPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txbTenPhong.Location = new System.Drawing.Point(403, 197);
            this.txbTenPhong.Margin = new System.Windows.Forms.Padding(2);
            this.txbTenPhong.Name = "txbTenPhong";
            this.txbTenPhong.Size = new System.Drawing.Size(276, 24);
            this.txbTenPhong.TabIndex = 2;
            // 
            // txbMaPhong
            // 
            this.txbMaPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txbMaPhong.Location = new System.Drawing.Point(403, 136);
            this.txbMaPhong.Margin = new System.Windows.Forms.Padding(2);
            this.txbMaPhong.MaxLength = 5;
            this.txbMaPhong.Name = "txbMaPhong";
            this.txbMaPhong.ReadOnly = true;
            this.txbMaPhong.Size = new System.Drawing.Size(276, 24);
            this.txbMaPhong.TabIndex = 1;
            // 
            // lbLoai
            // 
            this.lbLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLoai.AutoSize = true;
            this.lbLoai.BackColor = System.Drawing.Color.Transparent;
            this.lbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbLoai.Location = new System.Drawing.Point(190, 385);
            this.lbLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLoai.Name = "lbLoai";
            this.lbLoai.Size = new System.Drawing.Size(134, 24);
            this.lbLoai.TabIndex = 22;
            this.lbLoai.Text = "Loại thực hành";
            // 
            // lbSLPM
            // 
            this.lbSLPM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSLPM.AutoSize = true;
            this.lbSLPM.BackColor = System.Drawing.Color.Transparent;
            this.lbSLPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbSLPM.Location = new System.Drawing.Point(190, 319);
            this.lbSLPM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSLPM.Name = "lbSLPM";
            this.lbSLPM.Size = new System.Drawing.Size(126, 24);
            this.lbSLPM.TabIndex = 23;
            this.lbSLPM.Text = "Số lượng máy";
            // 
            // lbKhuVuc
            // 
            this.lbKhuVuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbKhuVuc.AutoSize = true;
            this.lbKhuVuc.BackColor = System.Drawing.Color.Transparent;
            this.lbKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbKhuVuc.Location = new System.Drawing.Point(190, 258);
            this.lbKhuVuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKhuVuc.Name = "lbKhuVuc";
            this.lbKhuVuc.Size = new System.Drawing.Size(115, 24);
            this.lbKhuVuc.TabIndex = 24;
            this.lbKhuVuc.Text = "Tên khu vực";
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTenPhong.AutoSize = true;
            this.lbTenPhong.BackColor = System.Drawing.Color.Transparent;
            this.lbTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbTenPhong.Location = new System.Drawing.Point(190, 197);
            this.lbTenPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(104, 24);
            this.lbTenPhong.TabIndex = 25;
            this.lbTenPhong.Text = "Tên phòng";
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.BackColor = System.Drawing.Color.Transparent;
            this.lbMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbMaPhong.Location = new System.Drawing.Point(190, 136);
            this.lbMaPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(96, 24);
            this.lbMaPhong.TabIndex = 26;
            this.lbMaPhong.Text = "Mã phòng";
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lbTieuDe.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.lbTieuDe.Location = new System.Drawing.Point(254, 37);
            this.lbTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(371, 41);
            this.lbTieuDe.TabIndex = 21;
            this.lbTieuDe.Text = "Thông tin phòng mới";
            // 
            // fCapNhatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLPHONGTHUCHANH.Properties.Resources.d46a39dac513124d4b02;
            this.ClientSize = new System.Drawing.Size(863, 554);
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