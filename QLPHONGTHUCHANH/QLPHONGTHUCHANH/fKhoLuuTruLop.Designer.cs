namespace QLPHONGTHUCHANH
{
    partial class fKhoLuuTruLop
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
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.dtaLop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtaLop)).BeginInit();
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
            this.lbTieuDe.Size = new System.Drawing.Size(351, 33);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "Kho lưu trữ thông tin lớp";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnKhoiPhuc.TabIndex = 1;
            this.btnKhoiPhuc.Text = "Khôi Phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            // 
            // dtaLop
            // 
            this.dtaLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtaLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaLop.Location = new System.Drawing.Point(76, 137);
            this.dtaLop.Name = "dtaLop";
            this.dtaLop.Size = new System.Drawing.Size(766, 273);
            this.dtaLop.TabIndex = 2;
            // 
            // fKhoLuuTruLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLPHONGTHUCHANH.Properties.Resources.d46a39dac513124d4b02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(918, 480);
            this.Controls.Add(this.dtaLop);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.lbTieuDe);
            this.Name = "fKhoLuuTruLop";
            this.Text = "Kho lưu trữ";
            ((System.ComponentModel.ISupportInitialize)(this.dtaLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.DataGridView dtaLop;
    }
}