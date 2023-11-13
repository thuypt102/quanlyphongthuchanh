using QLPHONGTHUCHANH.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLPHONGTHUCHANH
{
    public partial class fThemLop : Form
    {
        public fThemLop()
        {
            InitializeComponent();
        }

        

        private void vbThemLop_Click(object sender, EventArgs e)
        {
            string maLop = txbMaLop.Text;
            string tenLop = txbTenLop.Text;
            string tenKhoa = txbKhoa.Text;
            string IDGV = txbIDGV.Text;
            string  caLT = txbCaLT.Text;
            int SLSV = int.Parse(txbSlSV.Text);
            int Loai = int.Parse(cmbLoai.SelectedItem.ToString());

            if (LopDAL.Khoitao.themLop(maLop, tenLop, tenKhoa, IDGV, caLT, SLSV, Loai))
            {
                MessageBox.Show("thêm thành công!", "Thông báo");
            }
            else
                MessageBox.Show("thêm không thành công!", "Thông báo");
            
        }

        
    }
}
