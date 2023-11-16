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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLPHONGTHUCHANH
{
    public partial class fLogin : Form
    {
        // Khai báo biến toàn cục để lưu thông tin đăng nhập
        public static string LoggedInUsername = "";
        public static string LoggedInPassword = "";
        //public static int LoggedInUserID = -1; // Khởi tạo giá trị mặc định -1
        public fLogin()
        {
            InitializeComponent();
            
            //Load += fLogin_Load;
        }
        
        private void fLogin_Load(object sender, EventArgs e)
        {
            txbTenDangNhap.Focus();
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
        private void formLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi ứng dụng?", "Thông báo", MessageBoxButtons.OKCancel)
                != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
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
                fMainGV fGV = new fMainGV();
                bool isAd = getType(username, pass); // Kiểm tra loại tài khoản

                if (isAd)
                {
                    // Gán thông tin đăng nhập vào biến toàn cục
                    LoggedInUsername = username;
                    LoggedInPassword = pass;

                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    // Gán thông tin đăng nhập vào biến toàn cục
                    LoggedInUsername = username;
                    LoggedInPassword = pass;

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
