using QLPHONGTHUCHANH.DAL;
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
    public partial class fThongTinQuanLy : Form
    {
        public fThongTinQuanLy()
        {
            InitializeComponent();
        }

        private void fThongTinQuanLy_Load(object sender, EventArgs e)
        {
            //Sử dụng thông tin đăng nhập đã lưu trữ từ form fLogin
            string loggedInUsername = fLogin.LoggedInUsername;
            string loggedInPassword = fLogin.LoggedInPassword;

            // Lấy thông tin người quản lý từ cơ sở dữ liệu
            DataTable quanLyInfo = TaiKhoanDAL.Khoitao.getNguoiQuanLyInfo(loggedInUsername, loggedInPassword);

            if (quanLyInfo.Rows.Count > 0)
            {
                // Hiển thị thông tin lên các textbox
                txbMaQL.Text = quanLyInfo.Rows[0]["id"].ToString();
                txbTenQL.Text = quanLyInfo.Rows[0]["hoTen"].ToString();
                txbChucVu.Text = quanLyInfo.Rows[0]["chucVu"].ToString();
                txbSDT.Text = quanLyInfo.Rows[0]["sdt"].ToString();
                txbEmail.Text = quanLyInfo.Rows[0]["email"].ToString();
            }
        }
    }
}
