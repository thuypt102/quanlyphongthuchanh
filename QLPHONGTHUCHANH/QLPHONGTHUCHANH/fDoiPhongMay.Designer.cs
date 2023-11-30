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
            this.dtaDoiPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaDoiPM.Location = new System.Drawing.Point(21, 19);
            this.dtaDoiPM.Name = "dtaDoiPM";
            this.dtaDoiPM.Size = new System.Drawing.Size(919, 252);
            this.dtaDoiPM.TabIndex = 0;
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
    }
}