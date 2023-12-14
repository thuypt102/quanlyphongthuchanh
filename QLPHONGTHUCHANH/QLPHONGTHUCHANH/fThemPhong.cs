using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPHONGTHUCHANH.DAL;

namespace QLPHONGTHUCHANH
{
    public partial class fThemPhong : Form
    {
        public fThemPhong()
        {
            InitializeComponent();
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbMaPhong.Text) || string.IsNullOrEmpty(txbTenPhong.Text) || string.IsNullOrEmpty(txbKhuVuc.Text) || string.IsNullOrEmpty(cmbLoai.Text) || string.IsNullOrEmpty(txbSLPM.Text))
            {
                MessageBox.Show("Nhập đủ thông tin để tiếp tục!", "Thông báo");
            }

            else
            {
                string maPhong = txbMaPhong.Text;
                string tenPhong = txbTenPhong.Text;
                string tenKhuVuc = txbKhuVuc.Text;
                //int soLuongMay = int.Parse(txbSLPM.Text);

                string soLuongMayText = txbSLPM.Text;
                int soLuongMay;

                if (!int.TryParse(soLuongMayText, out soLuongMay))
                {
                    // Xử lý khi chuỗi không phải là số
                    MessageBox.Show("Số lượng máy không hợp lệ!", "Lỗi");
                }
                else
                {
                    //string loaiThucHanh = cmbLoai.SelectedItem.ToString();
                    string loaiThucHanh = cmbLoai.Text;
                    /*
                    if (loaiThucHanh == "")
                    {
                        loaiThucHanh = "Thực hành thông thường";
                    }
                    */
                    if (PhongDAL.Khoitao.timKiem(maPhong))
                    {
                        MessageBox.Show("Mã phòng đã tồn tại. Vui lòng nhập mã khác.");
                    }
                    else
                    {
                        if (PhongDAL.Khoitao.themPhong(maPhong, tenPhong, tenKhuVuc, soLuongMay, loaiThucHanh))
                        {
                            MessageBox.Show("Thêm phòng máy thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Thêm phòng máy không thành công!", "Thông báo");

                        }
                    }
                }
            }
        }
    }
}
