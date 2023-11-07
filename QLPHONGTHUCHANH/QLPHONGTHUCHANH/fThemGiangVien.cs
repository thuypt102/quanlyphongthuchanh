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

namespace QLPHONGTHUCHANH
{
    public partial class fThemGiangVien : Form
    {
        public fThemGiangVien()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maGV = txbMaGV.Text;
            string tenGV = txbTenGV.Text;
            string Khoa = txbKhoa.Text;
            string SDT = txbSDT.Text;
            int IDTaiKhoan = int.Parse(txbIDTaiKhoan.Text);
            

            if (GVDALL.Khoitao.themGV(maGV, tenGV, Khoa , SDT , IDTaiKhoan))
            {
                MessageBox.Show("thêm thành công!", "Thông báo");
            }
            else
                MessageBox.Show("thêm không thành công!", "Thông báo");

        }
=======
        
>>>>>>> e13c9cb09764832ec7b94430f23bca1cafd3a438
    }
}
