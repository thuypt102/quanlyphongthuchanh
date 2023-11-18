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
            string maPhong = txbMaPhong.Text;
            string tenPhong = txbTenPhong.Text;
            string tenKhuVuc = txbKhuVuc.Text;
            int soLuongMay = int.Parse(txbSLPM.Text);
            //string loaiThucHanh = cmbLoai.SelectedItem.ToString();
            string loaiThucHanh = cmbLoai.Text;

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
