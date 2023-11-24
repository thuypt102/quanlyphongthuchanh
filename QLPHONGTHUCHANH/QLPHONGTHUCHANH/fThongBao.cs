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
    public partial class fThongBao : Form
    {
        public fThongBao(ThongBao thongBao)
        {
            InitializeComponent();
            hienThi(thongBao);
            // Thêm sự kiện cho nút btnDaXuLy
            //btnXuLy.Click += btnXuLy_Click;
            string tt = thongBao.Id;
            if (showKhoiPhuc(tt))
            {
                btnXuLy.Enabled = false;
            }
        }

        private void hienThi(ThongBao ThongBao)
        {
            txtId.Text = ThongBao.Id;
            txtTieuDe.Text = ThongBao.TieuDe;
            txtNguoiGui.Text = ThongBao.IdGiangVien.ToString();
            txtThoiGian.Text = ThongBao.ThoiGianGui;
            txbNoiDung.Text = ThongBao.NoiDung;
            
        }
        private ThongBao thongBao;
        public bool showKhoiPhuc(string id)
        {
            string query = "select * from THONGBAO where trangThai = 1 and id = '" + id + "'";
            DataTable result = DataProvider.Khoitao.ExecuteQuery(query);
            return result.Rows.Count > 0;
           
        }
        private void btnXuLy_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string query = string.Format("UPDATE THONGBAO SET trangThai = 1 WHERE id = " + id);
            int result = DataProvider.Khoitao.ExecuteNonQuery(query);

            if (result > 0)
            {
                MessageBox.Show("Đã xử lý thông báo thành công!", "Thông báo");
                //btnXuLy.Enabled = false; // Vô hiệu hóa nút khi đã xử lý thành công
                this.Close(); // Đóng form hiện tại sau khi xử lý thành công
            }
            else
            {
                MessageBox.Show("Không thể cập nhật trạng thái của thông báo. Vui lòng thử lại.", "Lỗi");
            }
        }

    }
}
