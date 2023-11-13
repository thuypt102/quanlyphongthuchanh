using QLPHONGTHUCHANH.DAL;
using QLPHONGTHUCHANH.DTO;
using System;
using System.Windows.Forms;


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
            int Loai = int.Parse(dtaLop.Rows[i].Cells[6].Value.ToString());

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
                    MessageBox.Show("xóa không thành công!", "Thông báo");

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
            int loaiThucHanh = int.Parse(dtaPhong.Rows[i].Cells[4].Value.ToString());
            bool luuTru = bool.Parse(dtaPhong.Rows[i].Cells[5].Value.ToString());

            Phong Phong = new Phong(maPhong, tenPhong, tenKhuVuc, soLuongMay, loaiThucHanh, luuTru);

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
            string luuTru = dtaGV.Rows[i].Cells[4].Value.ToString();
            int idtaikhoan = int.Parse(dtaGV.Rows[i].Cells[5].Value.ToString());


            GV a = new GV(maGV, tenGV, Khoa, sdt, idtaikhoan, false);

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
                    MessageBox.Show("xóa không thành công!", "Thông báo");

            }
            else if (result == DialogResult.No)
            {
                // Người dùng đã chọn "Không"
                Console.WriteLine("Không xóa!");
            }
            XemGV();
        }

        private void btnLuuTruLop_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuTruGV_Click(object sender, EventArgs e)
        {

        }

        
    }
}
