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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLPHONGTHUCHANH
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            loadNamHoc();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lbTieuDe.Hide();
            dtgLich.Show();
            string selectedValue = cmbLoai.SelectedItem.ToString();
            string tukhoa = txbTimKiem.Text;
            string nam = cmbNamHoc.Text.ToString();
            if (tukhoa == "" && selectedValue != "Tất cả")
            {
                MessageBox.Show("Vui lòng nhập từ khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (selectedValue == "Lớp")
                {
                    loadLichTheoLop(tukhoa, nam);
                }
                else if (selectedValue == "Giảng viên")
                {
                    loadLichTheoGV(tukhoa, nam);
                }
                else if(selectedValue == "Phòng")
                {
                    loadLichTheoPhong(tukhoa, nam);
                }    
                else
                    loadLich();
            }    
        }

        private void mniDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Thông báo",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
        void loadLich()
        {
            //dsTaiKhoan.DataSource = TaiKhoanBUS.Khoitao.layDStaikhoan();
            dtgLich.DataSource = LichDAL.Khoitao.getLichThucHanh();
        }
        void loadLichTheoLop(string lop, string nam)
        {
            dtgLich.DataSource = LichDAL.Khoitao.getLichLop(lop, nam);
        }
        void loadLichTheoGV(string gv, string nam)
        {
            dtgLich.DataSource = LichDAL.Khoitao.getLichGV(gv, nam);
        }
        void loadLichTheoPhong(string p, string nam)
        {
            dtgLich.DataSource = LichDAL.Khoitao.getLichPhong(p, nam);
        }
        void loadNamHoc()
        {
            List<Lich> nam = LichDAL.Khoitao.loadNamHoc();
            cmbNamHoc.DataSource = nam;
            cmbNamHoc.DisplayMember = "namHoc";
        }
    }
}
