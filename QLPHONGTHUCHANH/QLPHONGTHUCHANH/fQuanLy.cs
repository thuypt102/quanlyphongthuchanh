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
            //XemPhong();
            //XemGV();
        }

        void XemLop()
        {
            //dtaLop.DataSource = LopDAL.Khoitao.hienThiLop();
        }
        /*void XemPhong()
        {
            dtaPhong.DataSource = LopDAL.Khoitao.hienThiPhong();
        }
        void XemGV()
        {
            dtaGV.DataSource = LopDAL.Khoitao.hienThiGV();
        }*/

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
        }


        private void btnTimKiemLop_Click(object sender, EventArgs e)
        {

        }

        void sua()
        {
            //DataGridView row = ;

        }
        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            int i;
            i = dtaLop.CurrentRow.Index;

            string maLop = dtaLop.Rows[i].Cells[0].Value.ToString();
            string tenLop = dtaLop.Rows[i].Cells[1].Value.ToString();
            string tenKhoa = dtaLop.Rows[i].Cells[2].Value.ToString();
            string IDGV = dtaLop.Rows[i].Cells[3].Value.ToString();
            string caLT = dtaLop.Rows[i].Cells[4].Value.ToString();
            int SLSV = int.Parse(dtaLop.Rows[i].Cells[5].Value.ToString());
            int Loai = int.Parse(dtaLop.Rows[i].Cells[6].Value.ToString());

           // Lop a = new Lop(maLop, tenLop, tenKhoa, IDGV, caLT, SLSV, Loai, false);

            //fCapNhatLop f = new fCapNhatLop(a);
            this.Hide();
            //f.ShowDialog();
            this.Show();
        }



        

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            int i;
            i = dtaLop.CurrentRow.Index;

            string maLop = dtaLop.Rows[i].Cells[0].Value.ToString();
            /*
            if (LopDAL.Khoitao.xoaLop(maLop))
            {
                MessageBox.Show("xóa thành công!", "Thông báo");
            }
            else
                MessageBox.Show("xóa không thành công!", "Thông báo");
            */
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            fThemGiangVien f = new fThemGiangVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            fThemPhong f = new fThemPhong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            /*int i;
            i = dtaLop.CurrentRow.Index;

            string maLop = dtaLop.Rows[i].Cells[0].Value.ToString();
            string tenLop = dtaLop.Rows[i].Cells[1].Value.ToString();
            string tenKhoa = dtaLop.Rows[i].Cells[2].Value.ToString();
            string IDGV = dtaLop.Rows[i].Cells[3].Value.ToString();
            string caLT = dtaLop.Rows[i].Cells[4].Value.ToString();
            int SLSV = int.Parse(dtaLop.Rows[i].Cells[5].Value.ToString());
            int Loai = int.Parse(dtaLop.Rows[i].Cells[6].Value.ToString());

            Lop a = new Lop(maLop, tenLop, tenKhoa, IDGV, caLT, SLSV, Loai, false);*/

            fCapNhatPhong f = new fCapNhatPhong();//a
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            /*int i;
            i = dtaLop.CurrentRow.Index;

            string maLop = dtaLop.Rows[i].Cells[0].Value.ToString();
            string tenLop = dtaLop.Rows[i].Cells[1].Value.ToString();
            string tenKhoa = dtaLop.Rows[i].Cells[2].Value.ToString();
            string IDGV = dtaLop.Rows[i].Cells[3].Value.ToString();
            string caLT = dtaLop.Rows[i].Cells[4].Value.ToString();
            int SLSV = int.Parse(dtaLop.Rows[i].Cells[5].Value.ToString());
            int Loai = int.Parse(dtaLop.Rows[i].Cells[6].Value.ToString());

            Lop a = new Lop(maLop, tenLop, tenKhoa, IDGV, caLT, SLSV, Loai, false);*/

            fCapNhatGV f = new fCapNhatGV();//a
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
