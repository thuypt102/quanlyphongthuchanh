using QLPHONGTHUCHANH.DAL;
using QLPHONGTHUCHANH.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


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

            XemLop();
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

                if (LopDAL.Khoitao.xoaLop(maLop))
                {
                    MessageBox.Show("xóa thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("xóa không thành công!", "Thông báo");

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
            string  loaiThucHanh = dtaPhong.Rows[i].Cells[4].Value.ToString();
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
            //string luuTru = dtaGV.Rows[i].Cells[5].Value.ToString();
            int idtaikhoan = int.Parse(dtaGV.Rows[i].Cells[5].Value.ToString());


            GV a = new GV(maGV, tenGV, Khoa, sdt,email, idtaikhoan/*, false*/);

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

                if (PhongDAL.Khoitao.xoaPhong(maPhong))
                {
                    MessageBox.Show("xóa thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("xóa không thành công!", "Thông báo");

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
                    MessageBox.Show("xóa thành công!", "Thông báo");
                }
                else
                {
                    if (GVDALL.Khoitao.KTLienKet(maGV))
                    {
                        MessageBox.Show("Không thể xóa vì có liên quan đến các bảng khác.", "Thông báo");
                    }
                    else
                        MessageBox.Show("xóa không thành công!", "Thông báo");

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
        }

        private void btnKhoLuuTruGV_Click(object sender, EventArgs e)
        {
            fKhoLuuTruGiangVien f = new fKhoLuuTruGiangVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
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

        private void UpdateThongBaoData()
        {
            // Lấy trạng thái đã chọn từ ComboBox
            string selectedStatus = cbxLoc.SelectedItem.ToString();

            // Cập nhật DataGridView dựa trên trạng thái đã chọn
            if (selectedStatus == "Tất cả")
            {
                dtaTB.DataSource = ThongBaoDAL.Khoitao.hienThiThongBao();
            }
            else if(selectedStatus == "Đã xử lý")
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
    }
}
