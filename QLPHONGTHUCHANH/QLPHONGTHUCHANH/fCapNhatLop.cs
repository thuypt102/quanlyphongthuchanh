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
using QLPHONGTHUCHANH.DTO;

namespace QLPHONGTHUCHANH
{
    public partial class fCapNhatLop : Form
    {
        public fCapNhatLop(Lop lop)
        {
            InitializeComponent();
            hienThi(lop);
        }

        private void hienThi(Lop lop)
        {
            txbMaLop.Text = lop.Id;
            txbTenLop.Text = lop.TenLop;
            txbKhoa.Text = lop.TenKhoa;
            txbIDGV.Text = lop.IdGiangVienPhuTrach;
            txbCaLT.Text = lop.CaLyThuyet;
            txbSlSV.Text = lop.SoLuongSinhVien.ToString();
            cmbLoai.Text = lop.LoaiThucHanh;
        }

        private bool IsValidInput()
        {
            // id giảng viên
            // Kiểm tra giá trị trong TextBox
            if (string.IsNullOrWhiteSpace(txbIDGV.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị vào .", "Lỗi");
                return false;
            }

            // Kiểm tra điều kiện khác (tuỳ theo yêu cầu của bạn)
            // Ví dụ: Kiểm tra giá trị có phải là số hay không

            /*if (!int.TryParse(txbIDGV.Text, out int IDGV))
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ.", "Lỗi");
                return false;
            }*/

            //ca lý thuyết
            // Kiểm tra giá trị trong TextBox
            if (string.IsNullOrWhiteSpace(txbCaLT.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị vào .", "Lỗi");
                return false;
            }

            // Kiểm tra điều kiện khác (tuỳ theo yêu cầu của bạn)
            // Ví dụ: Kiểm tra giá trị có phải là số hay không
            if (!int.TryParse(txbCaLT.Text, out int result))
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ.", "Lỗi");
                return false;
            }
            //số lượng sinh viên
            if (string.IsNullOrWhiteSpace(txbSlSV.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị vào .", "Lỗi");
                return false;
            }

            // Kiểm tra điều kiện khác (tuỳ theo yêu cầu của bạn)
            // Ví dụ: Kiểm tra giá trị có phải là số hay không
            if (!int.TryParse(txbSlSV.Text, out int SlSV))
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ.", "Lỗi");
                return false;
            }
            // Giá trị nhập vào hợp lệ
            return true;
        }

        private void vbButtonCapNhatLop(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                string maLop = txbMaLop.Text;
                string tenLop = txbTenLop.Text;
                string tenKhoa = txbKhoa.Text;
                string IDGV = txbIDGV.Text;
                string caLT = int.Parse(txbCaLT.Text).ToString();
                int SLSV = int.Parse(txbSlSV.Text);
                string Loai = cmbLoai.Text;

                if (GVDALL.Khoitao.timKiem(IDGV))
                {
                    if (LopDAL.Khoitao.capNhatLop(maLop, tenLop, tenKhoa, IDGV, caLT, SLSV, Loai))
                    {
                        MessageBox.Show("cập nhật thành công!", "Thông báo");
                    }
                    else
                        MessageBox.Show("cập nhật không thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Mã giảng viên không tồn tại. Vui lòng nhập mã khác.");
                }
                
            }
        }
    }
}
