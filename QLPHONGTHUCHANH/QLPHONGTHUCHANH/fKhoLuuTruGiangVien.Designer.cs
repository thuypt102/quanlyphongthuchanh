namespace QLPHONGTHUCHANH
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
            ((System.ComponentModel.ISupportInitialize)(this.dtaGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.BackColor = System.Drawing.Color.White;
            this.lbTieuDe.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Image = global::QLPHONGTHUCHANH.Properties.Resources.d46a39dac513124d4b021;
            this.lbTieuDe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTieuDe.Location = new System.Drawing.Point(275, 22);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(449, 33);
            this.lbTieuDe.TabIndex = 1;
            this.lbTieuDe.Text = "Kho lưu trữ thông tin giảng viên";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtaGiangVien
            // 
            this.dtaGiangVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtaGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGiangVien.Location = new System.Drawing.Point(76, 137);
            this.dtaGiangVien.Name = "dtaGiangVien";
            this.dtaGiangVien.Size = new System.Drawing.Size(766, 273);
            this.dtaGiangVien.TabIndex = 3;
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.Blue;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(395, 428);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(131, 40);
            this.btnKhoiPhuc.TabIndex = 4;
            this.btnKhoiPhuc.Text = "Khôi Phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            // 
            // fKhoLuuTruGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLPHONGTHUCHANH.Properties.Resources.d46a39dac513124d4b022;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(918, 480);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.dtaGiangVien);
            this.Controls.Add(this.lbTieuDe);
            this.Name = "fKhoLuuTruGiangVien";
            this.Text = "Kho lưu trữ";
            ((System.ComponentModel.ISupportInitialize)(this.dtaGiangVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.DataGridView dtaGiangVien;
        private System.Windows.Forms.Button btnKhoiPhuc;
    }
}