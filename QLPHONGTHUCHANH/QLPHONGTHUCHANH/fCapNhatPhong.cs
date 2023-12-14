using QLPHONGTHUCHANH.DAL;
using QLPHONGTHUCHANH.DTO;
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
    public partial class fCapNhatPhong : Form
    {
        public fCapNhatPhong(Phong Phong)
        {
            InitializeComponent();
            hienThi(Phong);
        }

        

        private void hienThi(Phong Phong)
        {
            txbMaPhong.Text = Phong.Id;
            txbTenPhong.Text = Phong.TenPhong;
            txbKhuVuc.Text = Phong.TenKhuVuc;
            txbSLPM.Text = Phong.SoLuongMay.ToString();
            cmbLoai.Text = Phong.LoaiThucHanh;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhong = txbMaPhong.Text;
            string tenPhong = txbTenPhong.Text;
            string tenKhuVuc = txbKhuVuc.Text;
            string soLuongMayText = txbSLPM.Text;
            int soLuongMay;

            if (!int.TryParse(soLuongMayText, out soLuongMay))
            {
                // Xử lý khi chuỗi không phải là số
                MessageBox.Show("Số lượng máy không hợp lệ!", "Lỗi");
            }
            else
            {
                string loaiThucHanh = cmbLoai.Text;
                if (loaiThucHanh == "")
                {
                    loaiThucHanh = "Thực hành thông thường";
                }
                if (PhongDAL.Khoitao.capNhatPhong(maPhong, tenPhong, tenKhuVuc, soLuongMay, loaiThucHanh))
                {
                    MessageBox.Show("Cập nhật phòng máy thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật phòng máy không thành công!", "Thông báo");
                }
            }
        }
        
    }
}
