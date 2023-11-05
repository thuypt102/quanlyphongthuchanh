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
    }
}
