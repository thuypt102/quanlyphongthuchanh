using QLPHONGTHUCHANH.DAL;
using QLPHONGTHUCHANH.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
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

        string loadNamHoc()
        {
            List<string> nam = LichDAL.Khoitao.loadNamHoc().Select(l => l.NamHoc).ToList();

            if (nam.Count > 0)
            {
                string maxNamHoc = nam.Max(); // Lấy năm học có giá trị lớn nhất

                nam.Clear(); // Xóa tất cả các năm học hiện có

                nam.Add(maxNamHoc);
            }

            return nam.First();
        }

        
        int loadHocKi()
        {
            List<int> ki = LichDAL.Khoitao.loadkiHoc().Select(l => l.KiHoc).ToList();

            if (ki.Count > 0)
            {
                int maxKi = ki.Max(); // Lấy học kì có giá trị lớn nhất

                ki.Clear(); // Xóa tất cả các học kì hiện có

                ki.Add(maxKi);
            }

            return ki.First();
        }
        private bool IsValidInput()
        {
            // id giảng viên
            // Kiểm tra giá trị trong TextBox
            if (string.IsNullOrWhiteSpace(tbThu.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị vào.", "Lỗi");
                return false;
            }

            // id ca thực hành
            // Kiểm tra giá trị trong TextBox
            if (string.IsNullOrWhiteSpace(cbxCaThucHanh.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị vào.", "Lỗi");
                return false;
            }

            // id lớp
            // Kiểm tra giá trị trong TextBox
            if (string.IsNullOrWhiteSpace(txbTenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị vào.", "Lỗi");
                return false;
            }

            string idlop = LopDAL.Khoitao.GetIdLop(txbTenLop.Text);

            if (idlop == null)
            {
                // Id lớp không tồn tại
                MessageBox.Show("Không tìm thấy lớp.");
                return false;
            }

            // Giá trị nhập vào hợp lệ
            return true;
        }
        private void btnDangKyLBS_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                // Lấy thông tin từ giao diện người dùng
                string loaiPhong = cbxLoaiPhong.SelectedItem.ToString();
                string tenCa = cbxCaThucHanh.SelectedItem.ToString();
                System.Data.DataTable result = CaDAL.Khoitao.GetCaId(tenCa);
                int caThucHanh = 1;
                if (result.Rows.Count > 0)
                {
                   caThucHanh = Convert.ToInt32(result.Rows[0]["id"]);
                    
                }


                //System.Data.DataTable idlop = LopDAL.Khoitao.GetCaId(txbTenLop.Text);

                string tenLop = LopDAL.Khoitao.GetIdLop(txbTenLop.Text);



                string thu = tbThu.Text;

                // Lấy idGiangVien tương ứng với id trong bảng dbo.TAIKHOAN đăng nhập hiện tại
                string loggedInUsername = fLogin.LoggedInUsername;
                string loggedInPassword = fLogin.LoggedInPassword;
                TaiKhoanDAL taiKhoanDAL = TaiKhoanDAL.Khoitao;
                DataTable giangVienInfo = taiKhoanDAL.getGiangVienInfo(loggedInUsername, loggedInPassword);

                string namHoc = loadNamHoc();
                int kiHoc = loadHocKi();

                if (giangVienInfo.Rows.Count > 0)
                {
                    string idGiangVien = giangVienInfo.Rows[0]["id"].ToString();
                    string idPhong;
                    List<string> danhSachPhong = LichDAL.Khoitao.GetPhongChuaCoTrongLichTH(caThucHanh, tenLop, idGiangVien, kiHoc, thu);
                    

                    if (danhSachPhong.Count > 0)
                    {
                        // Có phòng chưa có trong LICHTHUCHANH
                        idPhong = danhSachPhong.First();
                        
                        if (LichDAL.Khoitao.ThemLich(caThucHanh, tenLop, idPhong, idGiangVien, namHoc, kiHoc, thu))
                        {

                            MessageBox.Show("Đăng kí thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Đăng kí không thành công!", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã hết phòng trống!", "Thông báo");

                    }
                }
            }
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
                    //int idGiangVien = Convert.ToInt32(giangVienInfo.Rows[0]["id"]);
                    string idGiangVien = giangVienInfo.Rows[0]["id"].ToString();

                    DateTime thoiGianGui = DateTime.Now;
                    string tieuDe = "Báo cáo sự cố";
                    // định dạng lại kiểu datetime 
                    string formattedThoiGianGui = thoiGianGui.ToString("yyyy-MM-dd HH:mm:ss");

                    // sửa '" + idGiangVien + "', '" + formattedThoiGianGui +
                    // Thêm thông báo vào bảng dbo.THONGBAO
                    string query = "INSERT INTO THONGBAO (tieuDe, noiDung, idGiangVien, thoiGianGui, trangThai) " +
                                   "VALUES (N'" + tieuDe + "', N'" + noiDung + "', '" + idGiangVien + "', '" + formattedThoiGianGui + "', " + 0 + ")";

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
