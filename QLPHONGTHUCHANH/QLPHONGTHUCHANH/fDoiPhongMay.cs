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
    public partial class fDoiPhongMay : Form
    {
        public fDoiPhongMay()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            fCapNhatLich fcnl = new fCapNhatLich();
            this.Hide();
            fcnl.ShowDialog();
            this.Show();
        }
    }
}
