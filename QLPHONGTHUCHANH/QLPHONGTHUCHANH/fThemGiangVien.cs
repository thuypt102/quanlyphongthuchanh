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

        /*private bool IsValidInput()
        {
            // Kiểm tra giá trị trong TextBox
            if (string.IsNullOrWhiteSpace(txbIDTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy giá trị vào ", "Lỗi");
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
        }*/

        private void btnThem_Click(object sender, EventArgs e)
        {
            int IDTaiKhoan = 0;
            string maGV = txbMaGV.Text;
            string tenGV = txbTenGV.Text;
            string Khoa = txbKhoa.Text;
            string SDT = txbSDT.Text;
            string Email = txbEmail.Text;

            if (GVDALL.Khoitao.timKiem(maGV))
            {
                MessageBox.Show("Mã giảng viên đã tồn tại. Vui lòng nhập mã khác.");

            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txbIDTaiKhoan.Text))
                {
                    if (int.TryParse(txbIDTaiKhoan.Text, out int result))
                    {
                        IDTaiKhoan = result; // Gán giá trị nhập vào cho biến IDTaiKhoan
                        if (!TaiKhoanDAL.Khoitao.kiemTraID(IDTaiKhoan))
                        {
                            MessageBox.Show("Mã tài khoản giảng viên không tồn tại. Vui lòng nhập mã khác.");
                        }
                        else
                        {
                            if (GVDALL.Khoitao.themGV(maGV, tenGV, Khoa, SDT, Email, IDTaiKhoan))
                            {
                                MessageBox.Show("thêm thành công!", "Thông báo");
                            }
                            else
                                MessageBox.Show("thêm không thành công!", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giá trị nhập vào không hợp lệ.", "Lỗi");
                    }
                }
                else
                {
                    IDTaiKhoan = 0;
                    if (GVDALL.Khoitao.themGV(maGV, tenGV, Khoa, SDT, Email, IDTaiKhoan))
                    {
                        MessageBox.Show("thêm thành công!", "Thông báo");
                    }
                    else
                        MessageBox.Show("thêm không thành công!", "Thông báo");
                }
            }
        }
    }
}
