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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        void loadDStaikhoan()
        {
            //dsTaiKhoan.DataSource = TaiKhoanBUS.Khoitao.layDStaikhoan();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lbTieuDe.Hide();
            dataGridView1.Show();
        }
    }
}
