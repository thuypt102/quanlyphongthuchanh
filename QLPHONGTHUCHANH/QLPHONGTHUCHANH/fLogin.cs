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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool kiemTra(string user, string pass)
        {
            return TaiKhoanDAL.Khoitao.kiemTra(user, pass);
            //return TaiKhoanBUS.Khoitao.kiemTra(user, pass);
        }
        
        bool getType(string user, string pass)
        {
            return TaiKhoanDAL.Khoitao.getType(user, pass);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbTenDangNhap.Text;
            string pass = txbMatKhau.Text;
            if (kiemTra(username, pass))
            {
                fMain f = new fMain();
                fGiangVien fGV = new fGiangVien();
                bool isAd = getType(username, pass); // Kiểm tra loại tài khoản

                if (isAd)
                {
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    this.Hide();
                    fGV.ShowDialog();
                    this.Show();
                }

            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo");
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            
            string username = txbTenDangNhap.Text;
            string pass = txbMatKhau.Text;
            if (kiemTra(username, pass))
            {
                fMain f = new fMain();
                fGiangVien fGV = new fGiangVien();
                bool isAd = getType(username, pass); // Kiểm tra loại tài khoản

                if (isAd)
                {
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    this.Hide();
                    fGV.ShowDialog();
                    this.Show();
                }

            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo");
        }
    }
}
