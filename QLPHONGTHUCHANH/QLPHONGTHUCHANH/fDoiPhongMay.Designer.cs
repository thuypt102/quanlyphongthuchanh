namespace QLPHONGTHUCHANH
{
    partial class fDoiPhongMay
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
            this.lbDoiPM = new System.Windows.Forms.Label();
            this.grbDoiPM = new System.Windows.Forms.GroupBox();
            this.dtaDoiPM = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCaThucHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapNhat = new QLPHONGTHUCHANH.VBButton();
            this.grbDoiPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaDoiPM)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDoiPM
            // 
            this.lbDoiPM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDoiPM.AutoSize = true;
            this.lbDoiPM.BackColor = System.Drawing.Color.Transparent;
            this.lbDoiPM.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.lbDoiPM.Location = new System.Drawing.Point(362, 34);
            this.lbDoiPM.Name = "lbDoiPM";
            this.lbDoiPM.Size = new System.Drawing.Size(274, 41);
            this.lbDoiPM.TabIndex = 0;
            this.lbDoiPM.Text = "Đổi phòng máy";
            // 
            // grbDoiPM
            // 
            this.grbDoiPM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDoiPM.BackColor = System.Drawing.Color.Transparent;
            this.grbDoiPM.Controls.Add(this.dtaDoiPM);
            this.grbDoiPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDoiPM.Location = new System.Drawing.Point(12, 90);
            this.grbDoiPM.Name = "grbDoiPM";
            this.grbDoiPM.Size = new System.Drawing.Size(960, 293);
            this.grbDoiPM.TabIndex = 1;
            this.grbDoiPM.TabStop = false;
            this.grbDoiPM.Text = "Thông tin";
            // 
            // dtaDoiPM
            // 
            this.dtaDoiPM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaDoiPM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaDoiPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaDoiPM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idCaThucHanh,
            this.idLop,
            this.idPhong,
            this.idGiangVien,
            this.namHoc,
            this.kiHoc,
            this.thu});
            this.dtaDoiPM.Location = new System.Drawing.Point(21, 19);
            this.dtaDoiPM.Name = "dtaDoiPM";
            this.dtaDoiPM.ReadOnly = true;
            this.dtaDoiPM.RowHeadersWidth = 51;
            this.dtaDoiPM.Size = new System.Drawing.Size(919, 252);
            this.dtaDoiPM.TabIndex = 0;
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
            this.idCaThucHanh.HeaderText = "Mã Ca Thực Hành";
            this.idCaThucHanh.MinimumWidth = 6;
            this.idCaThucHanh.Name = "idCaThucHanh";
            this.idCaThucHanh.ReadOnly = true;
            // 
            // idLop
            // 
            this.idLop.DataPropertyName = "idLop";
            this.idLop.HeaderText = "Mã Lớp";
            this.idLop.MinimumWidth = 6;
            this.idLop.Name = "idLop";
            this.idLop.ReadOnly = true;
            // 
            // idPhong
            // 
            this.idPhong.DataPropertyName = "idPhong";
            this.idPhong.HeaderText = "Mã Phòng";
            this.idPhong.MinimumWidth = 6;
            this.idPhong.Name = "idPhong";
            this.idPhong.ReadOnly = true;
            // 
            // idGiangVien
            // 
            this.idGiangVien.DataPropertyName = "idGiangVien";
            this.idGiangVien.HeaderText = "Mã Giảng Viên";
            this.idGiangVien.MinimumWidth = 6;
            this.idGiangVien.Name = "idGiangVien";
            this.idGiangVien.ReadOnly = true;
            // 
            // namHoc
            // 
            this.namHoc.DataPropertyName = "namHoc";
            this.namHoc.HeaderText = "Năm Học";
            this.namHoc.MinimumWidth = 6;
            this.namHoc.Name = "namHoc";
            this.namHoc.ReadOnly = true;
            // 
            // kiHoc
            // 
            this.kiHoc.DataPropertyName = "kiHoc";
            this.kiHoc.HeaderText = "Kì Học";
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
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCapNhat.BackColor = System.Drawing.Color.Blue;
            this.btnCapNhat.BackgroundColor = System.Drawing.Color.Blue;
            this.btnCapNhat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhat.BorderRadius = 20;
            this.btnCapNhat.BorderSize = 0;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(398, 410);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(188, 40);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextColor = System.Drawing.Color.White;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // fDoiPhongMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLPHONGTHUCHANH.Properties.Resources.d46a39dac513124d4b022;
            this.ClientSize = new System.Drawing.Size(984, 480);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.grbDoiPM);
            this.Controls.Add(this.lbDoiPM);
            this.Name = "fDoiPhongMay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi phòng máy";
            this.grbDoiPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtaDoiPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDoiPM;
        private System.Windows.Forms.GroupBox grbDoiPM;
        private System.Windows.Forms.DataGridView dtaDoiPM;
        private VBButton btnCapNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCaThucHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn namHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn thu;
    }
}