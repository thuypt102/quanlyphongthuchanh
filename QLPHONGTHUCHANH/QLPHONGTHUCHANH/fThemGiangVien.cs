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

        private bool IsValidInput()
        {
            // Kiểm tra giá trị trong TextBox
            if (string.IsNullOrWhiteSpace(txbIDTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị vào TextBox.", "Lỗi");
                return false;
            }

            // Kiểm tra điều kiện khác (tuỳ theo yêu cầu của bạn)
            // Ví dụ: Kiểm tra giá trị có phải là số hay không
            if (!int.TryParse(txbIDTaiKhoan.Text, out int result))
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ.", "Lỗi");
                return false;
            }

            // Giá trị nhập vào hợp lệ
            return true;
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
            //int IDTaiKhoan = 1;
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
        }
    }
}
