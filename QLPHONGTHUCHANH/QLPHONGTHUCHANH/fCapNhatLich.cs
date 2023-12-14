using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using QLPHONGTHUCHANH.DAL;
using QLPHONGTHUCHANH.DTO;

namespace QLPHONGTHUCHANH
{
    public partial class fCapNhatLich : Form
    {
        private Lich lich;
        public fCapNhatLich(Lich lich)
        {
            InitializeComponent();
            this.lich = lich; // Lưu đối tượng Lich vào thành viên
        
        }

        private bool IsValidInput(Lich lich)
        {
            // id giảng viên
            // Kiểm tra giá trị trong TextBox
            if (string.IsNullOrWhiteSpace(txbIDPM.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị vào.", "Lỗi");
                return false;
            }

            if (!PhongDAL.Khoitao.timKiem(txbIDPM.Text))
            {
                MessageBox.Show("Không tìm thấy mã phòng: "+ txbIDPM.Text, "Lỗi");
                return false;
            }
            int idcath = lich.IdCaThucHanh;
            string idPhong = txbIDPM.Text;
            string nam = lich.NamHoc;
            int kiHoc = lich.KiHoc;
            string thu = lich.Thu;

            if (LichDAL.Khoitao.KiemTraIdPhongTrong(idcath, idPhong, nam, kiHoc, thu))
            {
                // Id lớp không tồn tại
                MessageBox.Show("Phòng đã có lớp học.", "Thông báo");
                return false;
            }
            // Giá trị nhập vào hợp lệ
            return true;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int id = lich.Id;
            string idPhong = txbIDPM.Text;

            if (IsValidInput(lich))
            {
                if (LichDAL.Khoitao.CapNhatPhong(id, idPhong))
                {
                    string thongBao = string.Format("Đổi phòng thành công! Phòng: {0}", idPhong);
                    MessageBox.Show(thongBao, "Thông báo");

                }
                else
                {
                    MessageBox.Show("Đổi phòng không thành công!", "Thông báo");
                }
            }

        }
    }
}
