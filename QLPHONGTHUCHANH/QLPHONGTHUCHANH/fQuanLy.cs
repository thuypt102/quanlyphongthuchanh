using QLPHONGTHUCHANH.DAL;
using QLPHONGTHUCHANH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

using OfficeOpenXml;
using System.IO;

namespace QLPHONGTHUCHANH
{
    public partial class fQuanLy : Form
    {
        public fQuanLy()
        {
            InitializeComponent();

            XemLop();
            XemPhong();
            XemGV();
            XemTB();

            showLuuTruLop();
            showLuuTruPhong();
            showLuuTruGV();
        }

        void XemLop()
        {
            dtaLop.DataSource = LopDAL.Khoitao.hienThiLop();

        }
        void XemPhong()
        {
            dtaPhong.DataSource = PhongDAL.Khoitao.hienThiPhong();
        }
        void XemGV()
        {
            dtaGV.DataSource = GVDALL.Khoitao.hienThiGV();
        }
        void XemTB()
        {
            dtaTB.DataSource = ThongBaoDAL.Khoitao.hienThiThongBao();

            // Điền ComboBox với các giá trị trạng thái
            /*cbxLoc.Items.Add("Tất cả");
            cbxLoc.Items.Add("Chưa xử lý");
            cbxLoc.Items.Add("Đã xử lý");*/

            // Thiết lập chỉ mục mặc định đã chọn
            cbxLoc.SelectedIndex = 0;
        }


        private void btnKhoLuuTruLop_Click(object sender, EventArgs e)
        {
            fKhoLuuTruLop f = new fKhoLuuTruLop();
            this.Hide();
            f.ShowDialog();
            this.Show();
            XemLop();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            fThemLop f = new fThemLop();
            this.Hide();
            f.ShowDialog();
            this.Show();
            XemLop();
        }


        private void btnTimKiemLop_Click(object sender, EventArgs e)
        {
            string malop = txbTimKiemLop.Text;
            if (malop == "")
            {
                loadLich();
            }
            else
            {
                loadDSLop(malop);
            }
        }

        void loadLich()
        {
            dtaLop.DataSource = LopDAL.Khoitao.hienThiLop();
        }
        void loadDSLop(string lop)
        {
            dtaLop.DataSource = LopDAL.Khoitao.ShowLopTheoMa(lop);
        }
        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            if (dtaLop.CurrentRow == null)
            {
                MessageBox.Show("Không có lớp nào trong danh sách", "Thông báo");
                return;
            }

            int i;
            i = dtaLop.CurrentRow.Index;

            string maLop = dtaLop.Rows[i].Cells[0].Value.ToString();
            string tenLop = dtaLop.Rows[i].Cells[1].Value.ToString();
            string tenKhoa = dtaLop.Rows[i].Cells[2].Value.ToString();
            string IDGV = dtaLop.Rows[i].Cells[3].Value.ToString();
            string caLT = dtaLop.Rows[i].Cells[4].Value.ToString();
            int SLSV = int.Parse(dtaLop.Rows[i].Cells[5].Value.ToString());
            string Loai = dtaLop.Rows[i].Cells[6].Value.ToString();

            Lop a = new Lop(maLop, tenLop, tenKhoa, IDGV, caLT, SLSV, Loai, false);

            fCapNhatLop f = new fCapNhatLop(a);
            this.Hide();
            f.ShowDialog();
            this.Show();
            XemLop();
        }






        private void btnXoaLop_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);

            // Kiểm tra kết quả từ người dùng
            if (result == DialogResult.Yes)
            {
                int i;
                i = dtaLop.CurrentRow.Index;

                string maLop = dtaLop.Rows[i].Cells[0].Value.ToString();
                string maGV = dtaLop.Rows[i].Cells[3].Value.ToString();

                try
                {
                    if (LopDAL.Khoitao.xoaLop(maLop))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể xoá lớp này vì sẽ mất thông tin! " +
                        "\nHãy lưu trữ nếu không muốn chia lịch lớp này nữa.", "Thông báo");
                }
            }
            else if (result == DialogResult.No)
            {
                // Người dùng đã chọn "Không"
                Console.WriteLine("Không xóa!");
            }

            XemLop();

        }


        private void btnThemGV_Click(object sender, EventArgs e)
        {
            fThemGiangVien f = new fThemGiangVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
            XemGV();
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            fThemPhong f = new fThemPhong();
            this.Hide();
            f.ShowDialog();
            this.Show();
            XemPhong();
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {

            if (dtaPhong.CurrentRow == null)
            {
                MessageBox.Show("Không có phòng nào trong danh sách", "Thông báo");
                return;
            }

            int i = dtaPhong.CurrentRow.Index;

            string maPhong = dtaPhong.Rows[i].Cells[0].Value.ToString();
            string tenPhong = dtaPhong.Rows[i].Cells[1].Value.ToString();
            string tenKhuVuc = dtaPhong.Rows[i].Cells[2].Value.ToString();
            int soLuongMay = int.Parse(dtaPhong.Rows[i].Cells[3].Value.ToString());
            string loaiThucHanh = dtaPhong.Rows[i].Cells[4].Value.ToString();
            //bool luuTru = bool.Parse(dtaPhong.Rows[i].Cells[5].Value.ToString());

            Phong Phong = new Phong(maPhong, tenPhong, tenKhuVuc, soLuongMay, loaiThucHanh/*, luuTru*/);

            fCapNhatPhong f = new fCapNhatPhong(Phong);
            this.Hide();
            f.ShowDialog();
            this.Show();
            XemPhong();
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            if (dtaGV.CurrentRow == null)
            {
                MessageBox.Show("Không có giảng viên nào trong danh sách", "Thông báo");
                return;
            }

            int i;
            i = dtaGV.CurrentRow.Index;

            string maGV = dtaGV.Rows[i].Cells[0].Value.ToString();
            string tenGV = dtaGV.Rows[i].Cells[1].Value.ToString();
            string Khoa = dtaGV.Rows[i].Cells[2].Value.ToString();
            string sdt = dtaGV.Rows[i].Cells[3].Value.ToString();
            string email = dtaGV.Rows[i].Cells[4].Value.ToString();
            int? idtaikhoan;
            if (dtaGV.Rows[i].Cells[5].Value == null)
            {
                idtaikhoan = null;
            }
            else
            {
                string cellValue = dtaGV.Rows[i].Cells[5].Value.ToString();
                if (int.TryParse(cellValue, out int parsedValue))
                {
                    idtaikhoan = parsedValue;
                }
                else
                {
                    idtaikhoan = null; // Gán null nếu không thể chuyển đổi thành công
                }
            }

            GV a = new GV(maGV, tenGV, Khoa, sdt, email, idtaikhoan);

            fCapNhatGV f = new fCapNhatGV(a);
            this.Hide();
            f.ShowDialog();
            this.Show();
            XemGV();
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);

            // Kiểm tra kết quả từ người dùng
            if (result == DialogResult.Yes)
            {
                int i;
                i = dtaPhong.CurrentRow.Index;

                string maPhong = dtaPhong.Rows[i].Cells[0].Value.ToString();
                try
                {
                    if (PhongDAL.Khoitao.xoaPhong(maPhong))
                    {
                        MessageBox.Show("Xóa phòng thành công!", "Thông báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể xoá phòng này vì sẽ mất thông tin! " +
                        "\nHãy lưu trữ nếu không muốn chia lịch phòng này nữa.", "Thông báo");
                }
            }
            else if (result == DialogResult.No)
            {
                // Người dùng đã chọn "Không"
                Console.WriteLine("Không xóa!");
            }

            XemPhong();
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);

            // Kiểm tra kết quả từ người dùng
            if (result == DialogResult.Yes)
            {
                int i;
                i = dtaGV.CurrentRow.Index;

                string maGV = dtaGV.Rows[i].Cells[0].Value.ToString();

                if (GVDALL.Khoitao.xoaGV(maGV))
                {
                    MessageBox.Show("Xóa giảng viên thành công!", "Thông báo");
                    GVDALL.Khoitao.xoaTK(maGV);
                }
                else
                {
                    if (GVDALL.Khoitao.KTLienKet(maGV))
                    {
                        //MessageBox.Show("Không thể xóa vì có liên quan đến các bảng khác.", "Thông báo");
                        MessageBox.Show("Không thể xoá giáo viên này vì sẽ mất thông tin! " +
                        "\nHãy lưu trữ nếu không muốn chia lịch giáo viên này nữa.", "Thông báo");
                    }
                    else
                        MessageBox.Show("Xóa không thành công!", "Thông báo");

                }

            }
            else if (result == DialogResult.No)
            {
                // Người dùng đã chọn "Không"
                Console.WriteLine("Không xóa!");
            }
            XemGV();
        }

        private void btnKhoLuuTruPhong_Click(object sender, EventArgs e)
        {
            fKhoLuuTruPhong f = new fKhoLuuTruPhong();
            this.Hide();
            f.ShowDialog();
            this.Show();
            XemPhong();
        }

        private void btnKhoLuuTruGV_Click(object sender, EventArgs e)
        {
            fKhoLuuTruGiangVien f = new fKhoLuuTruGiangVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
            loadDSAllGV();
        }

        public void showLuuTruLop()
        {
            if (dtaLop.Rows.Count == 1)
            {
                btnLuuTruLop.Enabled = false;
            }
        }

        public void showLuuTruPhong()
        {
            if (dtaPhong.Rows.Count == 1)
            {
                btnLuuTruPhong.Enabled = false;
            }
        }

        public void showLuuTruGV()
        {
            if (dtaGV.Rows.Count == 1)
            {
                btnLuuTruGV.Enabled = false;
            }
        }
        private void btnLuuTruLop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn lưu trữ lớp?", "Thông báo",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                int i;
                i = dtaLop.CurrentRow.Index;

                string maL = dtaLop.Rows[i].Cells[0].Value.ToString();

                if (LopDAL.Khoitao.luuTruLop(maL))
                {
                    MessageBox.Show("Lưu trữ lớp thành công!", "Thông báo");
                    XemLop();
                    showLuuTruLop();
                }
                else
                {
                    MessageBox.Show("Lưu trữ lớp không thành công!", "Thông báo");
                }
            }
        }

        private void btnLuuTruPhong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn lưu trữ phòng?", "Thông báo",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                int i;
                i = dtaPhong.CurrentRow.Index;

                string maP = dtaPhong.Rows[i].Cells[0].Value.ToString();

                if (PhongDAL.Khoitao.luuTruPhong(maP))
                {
                    MessageBox.Show("Lưu trữ phòng thành công!", "Thông báo");
                    XemPhong();
                    showLuuTruPhong();
                }
                else
                {
                    MessageBox.Show("Lưu trữ lớp không thành công!", "Thông báo");
                }
            }
        }

        private void btnLuuTruGV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn lưu trữ giảng viên?", "Thông báo",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                int i;
                i = dtaGV.CurrentRow.Index;

                string maGV = dtaGV.Rows[i].Cells[0].Value.ToString();

                if (GVDALL.Khoitao.luuTruGiangVien(maGV))
                {
                    MessageBox.Show("Lưu trữ giảng viên thành công!", "Thông báo");
                    XemGV();
                    showLuuTruGV();
                }
                else
                {
                    MessageBox.Show("Lưu trữ giảng viên không thành công!", "Thông báo");
                }
            }
        }

        private void txbTimKiemLop_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnTimKiemGV_Click(object sender, EventArgs e)
        {
            string magv = txbTimKiemGV.Text;
            if (magv == "")
            {
                loadDSAllGV();
            }
            else
            {
                loadDSGV(magv);
            }
        }
        void loadDSAllGV()
        {
            dtaGV.DataSource = GVDALL.Khoitao.hienThiGV();
        }
        void loadDSGV(string magv)
        {
            dtaGV.DataSource = GVDALL.Khoitao.ShowGVTheoMa(magv);
        }

        private void btnTimKiemPhong_Click(object sender, EventArgs e)
        {
            string loaiphong = cbLoaiPhong.Text;
            string maphong = txbTimKiemPhong.Text;
            if (maphong == "" && loaiphong == "")// hiển thị tất cả
            {
                loadAllPhong();
            }
            if (maphong != "" && loaiphong == "")// tìm kiếm theo mã phòng
            {
                loadTheoMa(maphong);
            }
            if (maphong == "" && loaiphong != "")//tìm kiếm theo loại phòng
            {
                loadTheoLoai(loaiphong);
            }
            if (maphong != "" && loaiphong != "")//tìm kiếm theo loại phòng
            {
                loadTheoMaVaLoai(maphong, loaiphong);
            }
        }

        void loadAllPhong()
        {
            dtaPhong.DataSource = PhongDAL.Khoitao.hienThiPhong();
        }

        void loadTheoMa(string maphong)
        {
            dtaPhong.DataSource = PhongDAL.Khoitao.loadTheoMa(maphong);
        }
        void loadTheoLoai(string loai)
        {
            dtaPhong.DataSource = PhongDAL.Khoitao.loadTheoLoai(loai);
        }
        void loadTheoMaVaLoai(string lop, string loai)
        {
            dtaPhong.DataSource = PhongDAL.Khoitao.loadTheoMaVaLoai(lop, loai);
        }


        private void UpdateThongBaoData()
        {
            // Lấy trạng thái đã chọn từ ComboBox
            string selectedStatus = cbxLoc.SelectedItem.ToString();

            // Cập nhật DataGridView dựa trên trạng thái đã chọn
            if (selectedStatus == "Tất cả")
            {
                dtaTB.DataSource = ThongBaoDAL.Khoitao.hienThiThongBao();
            }
            else if (selectedStatus == "Đã xử lý")
            {
                dtaTB.DataSource = ThongBaoDAL.Khoitao.hienThiThongBao_daxuly();
            }
            else
                dtaTB.DataSource = ThongBaoDAL.Khoitao.hienThiThongBao_chuaxuly();

        }
        private void cbxLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Gọi phương thức để cập nhật DataGridView dựa trên trạng thái đã chọn
            UpdateThongBaoData();
        }

        private void btnXemChiTiet_Click_1(object sender, EventArgs e)
        {
            if (dtaTB.CurrentRow == null)
            {
                MessageBox.Show("Không có thông báo nào trong danh sách", "Thông báo");
                return;
            }

            int i;
            i = dtaTB.CurrentRow.Index;

            string id = dtaTB.Rows[i].Cells[0].Value.ToString();
            string tieude = dtaTB.Rows[i].Cells[1].Value.ToString();
            string noidung = dtaTB.Rows[i].Cells[2].Value.ToString();
            string idgv = dtaTB.Rows[i].Cells[3].Value.ToString();
            string thoigiangui = dtaTB.Rows[i].Cells[4].Value.ToString();
            //string trangthai = dtaTB.Rows[i].Cells[5].Value.ToString();

            ThongBao a = new ThongBao(id, tieude, noidung, idgv, thoigiangui);

            fThongBao ftb = new fThongBao(a);
            this.Hide();
            ftb.ShowDialog();
            this.Show();
            XemTB();
        }

        private void btnTaiLenPhong_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các tùy chọn cho hộp thoại mở file
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            openFileDialog.Title = "Chọn file Excel";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Gọi phương thức taiLenPhong từ PhongDAL để cập nhật dữ liệu vào CSDL
                PhongDAL.Khoitao.taiLenPhong(filePath);

                MessageBox.Show("Tải lên danh sách phòng thành công! \nLưu ý: Các phòng trùng ID sẽ bị bỏ qua.", "Thông báo");

                XemPhong();
            }
        }

        private void btnTaiLenGV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các tùy chọn cho hộp thoại mở file
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            openFileDialog.Title = "Chọn file Excel";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Gọi phương thức taiLenPhong từ PhongDAL để cập nhật dữ liệu vào CSDL
                GVDALL.Khoitao.taiLenGV(filePath);

                MessageBox.Show("Tải lên danh sách giảng viên thành công! \nLưu ý: Các ID trùng sẽ bị bỏ qua.", "Thông báo");

                XemGV();
            }
        }

        private void btnTaiLenLop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng đảm bảo đã thêm đầy đủ thông tin giảng viên để tránh xảy ra lỗi.", "Thông báo");

            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các tùy chọn cho hộp thoại mở file
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            openFileDialog.Title = "Chọn file Excel";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Gọi phương thức taiLenPhong từ PhongDAL để cập nhật dữ liệu vào CSDL
                LopDAL.Khoitao.taiLenLop(filePath);

                MessageBox.Show("Tải lên danh sách lớp thành công! \nLưu ý: Các ID trùng sẽ bị bỏ qua.", "Thông báo");

                MessageBox.Show("Các lớp có thông tin không hợp lệ đã bị bỏ qua. \nVui lòng chỉnh sửa và thêm lại nếu cần thiết.", "Thông báo");

                XemLop();
            }
        }

        public void TaiXuongTatCaTaiKhoan()
        {
            // Set the LicenseContext before using the EPPlus library
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            DataTable dtTaiKhoan = TaiKhoanDAL.Khoitao.dsTaiKhoanGV();

            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Danh sách tài khoản");

                // Tạo tiêu đề cho danh sách tài khoản
                worksheet.Cells[1, 1].Value = "Tên đăng nhập";
                worksheet.Cells[1, 2].Value = "Mật khẩu";

                int rowIndex = 2;

                foreach (DataRow row in dtTaiKhoan.Rows)
                {
                    string tenDangNhap = row["tenDangNhap"].ToString();
                    string matKhau = row["matKhau"].ToString();

                    // Thêm tài khoản vào danh sách Excel
                    worksheet.Cells[rowIndex, 1].Value = tenDangNhap;
                    worksheet.Cells[rowIndex, 2].Value = matKhau;

                    rowIndex++;
                }

                // Hiển thị hộp thoại lưu tệp Excel
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Chọn vị trí lưu tệp Excel";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Lưu tệp Excel vào đường dẫn do người dùng chọn
                    File.WriteAllBytes(filePath, excelPackage.GetAsByteArray());

                    // Mở thư mục chứa tệp Excel sau khi lưu thành công
                    System.Diagnostics.Process.Start("explorer.exe", "/select, " + filePath);
                }
            }
        }
        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn tạo tài khoản cho giảng viên không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Duyệt qua danh sách giảng viên
                DataTable dtGiangVien = GVDALL.Khoitao.hienThiGV();
                int idTaiKhoanMoi = 0;
                foreach (DataRow row in dtGiangVien.Rows)
                {
                    string idGiangVien = row["id"].ToString();
                    int? idTaiKhoan = row["idTaiKhoan"] as int?;

                    // Nếu giảng viên chưa có tài khoản
                    if (!idTaiKhoan.HasValue)
                    {
                        // Tạo tài khoản ngẫu nhiên
                        string tenDangNhap = idGiangVien;
                        string matKhau = GenerateRandomPassword();
                        int loaiTaiKhoan = 0; // Giảng viên

                        // Thêm vào bảng dbo.TAIKHOAN
                        idTaiKhoanMoi = TaiKhoanDAL.Khoitao.themTaiKhoan(tenDangNhap, matKhau, loaiTaiKhoan);

                        // Cập nhật idTaiKhoan cho giảng viên trong bảng dbo.GIANGVIEN
                        GVDALL.Khoitao.capNhatIdTaiKhoan(idGiangVien,idTaiKhoanMoi);
                    }
                }

                MessageBox.Show("Đã tạo tài khoản cho tất cả giảng viên chưa có tài khoản!", "Thông báo");
                //Tải xuống tất cả tài khoản
                TaiXuongTatCaTaiKhoan();
                MessageBox.Show("Đã tải xuống thông tin tài khoản giảng viên!", "Thông báo");
                // Cập nhật lại danh sách giảng viên sau khi tạo tài khoản
                XemGV();
            }
        }
        // Hàm tạo mật khẩu ngẫu nhiên
        private string GenerateRandomPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
