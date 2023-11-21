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
    public partial class fGiangVien : Form
    {
       
        public fGiangVien()
        {
            InitializeComponent();
            loadCa();
        }

        void loadCa()
        {
            List<CaThucHanh> ca = CaDAL.Khoitao.loadCa();
            cbxCaThucHanh.DataSource = ca;
            cbxCaThucHanh.DisplayMember = "tenCaThucHanh";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPThongTin)
            {
                // Sử dụng thông tin đăng nhập đã lưu trữ từ form fLogin
                string loggedInUsername = fLogin.LoggedInUsername;
                string loggedInPassword = fLogin.LoggedInPassword;

                // Thực hiện truy vấn cơ sở dữ liệu để lấy thông tin giảng viên dựa trên thông tin đăng nhập
                TaiKhoanDAL taiKhoanDAL = TaiKhoanDAL.Khoitao;
                DataTable giangVienInfo = taiKhoanDAL.getGiangVienInfo(loggedInUsername, loggedInPassword);
                if (giangVienInfo.Rows.Count > 0)
                {
                    // Hiển thị thông tin giảng viên lên các TextBox trên tabPThongTin
                    txbMaGV.Text = giangVienInfo.Rows[0]["id"].ToString();
                    txbTenGV.Text = giangVienInfo.Rows[0]["tenGiangVien"].ToString();
                    txbKhoa.Text = giangVienInfo.Rows[0]["khoa"].ToString();
                    txbSDT.Text = giangVienInfo.Rows[0]["sdt"].ToString();
                    txbEmail.Text = giangVienInfo.Rows[0]["email"].ToString();
                }
            }
        }

        private void btnDangKyLBS_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ giao diện người dùng
            string loaiPhong = cbxLoaiPhong.SelectedItem.ToString();
            string caThucHanh = cbxCaThucHanh.SelectedItem.ToString();
            string tenLop = txbTenLop.Text;

            
        }

        private void txtBCSC_Click(object sender, EventArgs e)
        {
            //txtBCSC.Clear();
        }

        private void btnGuiBaoCao_Click(object sender, EventArgs e)
        {
            // Lấy nội dung từ TextBox trên tabPBCSC
            string noiDung = txtBCSC.Text;

            // Kiểm tra nếu người dùng đã nhập nội dung
            if (!string.IsNullOrEmpty(noiDung))
            {
                // Lấy idGiangVien tương ứng với id trong bảng dbo.TAIKHOAN đăng nhập hiện tại
                string loggedInUsername = fLogin.LoggedInUsername;
                string loggedInPassword = fLogin.LoggedInPassword;
                TaiKhoanDAL taiKhoanDAL = TaiKhoanDAL.Khoitao;
                DataTable giangVienInfo = taiKhoanDAL.getGiangVienInfo(loggedInUsername, loggedInPassword);

                if (giangVienInfo.Rows.Count > 0)
                {
                    int idGiangVien = Convert.ToInt32(giangVienInfo.Rows[0]["id"]);
                    DateTime thoiGianGui = DateTime.Now;
                    string tieuDe = "Báo cáo sự cố";
                    

                    // Thêm thông báo vào bảng dbo.THONGBAO
                    string query = "INSERT INTO THONGBAO (tieuDe, noiDung, idGiangVien, thoiGianGui, trangThai) " +
                                   "VALUES (N'" + tieuDe + "', N'" + noiDung + "', " + idGiangVien + ", '" + thoiGianGui + "', " + 0 + ")";

                    // Thực hiện truy vấn để thêm thông báo
                    int result = DataProvider.Khoitao.ExecuteNonQuery(query);

                    if (result > 0)
                    {
                        // Hiển thị thông báo đã gửi thành công
                        MessageBox.Show("Đã xác nhận báo cáo sự cố", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Đặt lại nội dung của TextBox thành chuỗi rỗng
                        txtBCSC.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Không thể gửi thông báo sự cố. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Hiển thị thông báo yêu cầu người dùng nhập nội dung
                MessageBox.Show("Vui lòng nhập nội dung báo cáo sự cố trước khi gửi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
