namespace QLPHONGTHUCHANH
{
    partial class fCapNhatLich
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
            this.lbCapNhat = new System.Windows.Forms.Label();
            this.lbNhapIDPM = new System.Windows.Forms.Label();
            this.txbIDPM = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new QLPHONGTHUCHANH.VBButton();
            this.SuspendLayout();
            // 
            // lbCapNhat
            // 
            this.lbCapNhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCapNhat.AutoSize = true;
            this.lbCapNhat.BackColor = System.Drawing.Color.Transparent;
            this.lbCapNhat.Font = new System.Drawing.Font("Tahoma", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapNhat.Location = new System.Drawing.Point(121, 31);
            this.lbCapNhat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCapNhat.Name = "lbCapNhat";
            this.lbCapNhat.Size = new System.Drawing.Size(205, 47);
            this.lbCapNhat.TabIndex = 1;
            this.lbCapNhat.Text = "Cập nhật ";
            // 
            // lbNhapIDPM
            // 
            this.lbNhapIDPM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNhapIDPM.AutoSize = true;
            this.lbNhapIDPM.BackColor = System.Drawing.Color.Transparent;
            this.lbNhapIDPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhapIDPM.Location = new System.Drawing.Point(23, 121);
            this.lbNhapIDPM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNhapIDPM.Name = "lbNhapIDPM";
            this.lbNhapIDPM.Size = new System.Drawing.Size(186, 25);
            this.lbNhapIDPM.TabIndex = 2;
            this.lbNhapIDPM.Text = "Nhập id phòng mới: ";
            // 
            // txbIDPM
            // 
            this.txbIDPM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbIDPM.Location = new System.Drawing.Point(49, 170);
            this.txbIDPM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbIDPM.Name = "txbIDPM";
            this.txbIDPM.Size = new System.Drawing.Size(361, 22);
            this.txbIDPM.TabIndex = 3;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXacNhan.BackColor = System.Drawing.Color.Blue;
            this.btnXacNhan.BackgroundColor = System.Drawing.Color.Blue;
            this.btnXacNhan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXacNhan.BorderRadius = 20;
            this.btnXacNhan.BorderSize = 0;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(131, 231);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(200, 49);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.TextColor = System.Drawing.Color.White;
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // fCapNhatLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLPHONGTHUCHANH.Properties.Resources.d46a39dac513124d4b022;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(469, 395);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txbIDPM);
            this.Controls.Add(this.lbNhapIDPM);
            this.Controls.Add(this.lbCapNhat);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fCapNhatLich";
            this.Text = "Cập nhật lịch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCapNhat;
        private System.Windows.Forms.Label lbNhapIDPM;
        private System.Windows.Forms.TextBox txbIDPM;
        private VBButton btnXacNhan;
    }
}