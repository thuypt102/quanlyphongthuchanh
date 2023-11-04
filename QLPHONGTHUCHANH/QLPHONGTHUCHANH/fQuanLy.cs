using System;
using QLPHONGTHUCHANH.DAL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLPHONGTHUCHANH
{
    public partial class fQuanLy : Form
    {
        public fQuanLy()
        {
            InitializeComponent();

            //loadLopList();
            //LopDAL.Khoitao.hienThiLop();
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
        }

        
        private void btnTimKiemLop_Click(object sender, EventArgs e)
        {

        }

        
    }
}
